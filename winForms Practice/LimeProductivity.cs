using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace winForms_Practice
{
    public partial class LimeProductivity : Form
    {
        private Note _currentNote;
        private ProductivityManager _manager;
        public LimeProductivity()
        {
            if (System.IO.File.Exists("config.bin"))
            {
                var result=new PasswordForm().ShowDialog();
                while (result != DialogResult.OK)
                {
                    if (result == DialogResult.Cancel)
                    {
                        this.Close();
                        return;
                    }
                    result = new PasswordForm().ShowDialog();
                }
            }
            InitializeComponent();
            _calendar.MaxSelectionCount = 1;
            _dateNotesList.ItemSelectionChanged+=_dateNotesList_ItemSelectionChanged;
            _dateNotesList.KeyDown += _dateNotesList_KeyDown;
            this.Resize += LimeProductivity_Resize;
            _manager = new ProductivityManager();
            _showOnDateList(_manager.GetDateNotes(new DateTime(DateTime.Now.Year,DateTime.Now.Month,DateTime.Now.Day,0,0,0)));
            _showBold();
            _showPlanGroupBox(false);           
        }

        void LimeProductivity_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                notifyIcon1.Visible = true;
                Hide();         
            }
        }

        void _dateNotesList_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                {
                    var del=_manager.Remove(_dateNotesList.SelectedIndices[0], _calendar.SelectionStart);
                    if (del == _currentNote) _clearInps();
                    _showBold();
                    _updateNoteList();
                }
            }
            catch{}
        }
        void _showBold()
        {
            _calendar.BoldedDates = _manager.GetNotesDates();
        }
        void _dateNotesList_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            _isAddNoteMode = false;
            _showOnInps();
            _showPlanGroupBox(true);
        }
        private void _showOnInps()
        {
            if (_dateNotesList.SelectedIndices.Count == 0) return;
            int id = _dateNotesList.SelectedIndices[0];
            Note n=_manager.GetNote(id,_calendar.SelectionStart);
            _dateTimeSetter.Value = n.Time;
            _timeTextBox.Text = n.Time.Hour + ":" + n.Time.Minute;
            _titleTextBox.Text = n.Title;
            _currentNote = n;
            if (n.Signal != null)
                _signalTextBox.Text = n.Signal;
            _noteTextBox.Text = n.Text;
        }
        private void _showPlanGroupBox(bool show)
        {
            foreach (Control item in _planGroupBox.Controls)
            {
                item.Enabled = show;
            }
        }
        private void _usePasswordCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (_usePasswordCheckbox.Checked)
            {
                _passwordCheckbox.ReadOnly = false;
            }
            else
            {
                _passwordCheckbox.ReadOnly = true;
            }
        }
        private void _btnPlanOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "MP3 files|*.mp3";
            var result=ofd.ShowDialog();
            if (result == DialogResult.OK && _currentNote!=null)
            {
                _currentNote.Signal = ofd.FileName;
                _signalTextBox.Text = (new System.IO.FileInfo(_currentNote.Signal)).Name;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "MP3 files|*.mp3";
            ofd.ShowDialog();
            _manager.AppSettings.Signal = ofd.FileName;
            _settingsSignalTextBox.Text = (new System.IO.FileInfo(_manager.AppSettings.Signal)).Name;
        }

        private void _btnAddNote_Click(object sender, EventArgs e)
        {
            _showPlanGroupBox(true);
            
            _currentNote = new Note();
            _isAddNoteMode = true;
        }
        private bool _isAddNoteMode;
        private bool _updateCurrentNoteFields()
        {
            _currentNote.Time = _dateTimeSetter.Value;
            string[] t = _timeTextBox.Text.Split(':');
            try
            {
                _currentNote.Time=_currentNote.Time.AddHours(-_currentNote.Time.Hour);
                _currentNote.Time=_currentNote.Time.AddMinutes(-_currentNote.Time.Minute);
                _currentNote.Time = _currentNote.Time.AddHours((double)Convert.ToInt32(t[0]));
                _currentNote.Time = _currentNote.Time.AddMinutes((double)(Convert.ToInt32(t[1])));
            }
            catch { }
            _currentNote.Text = _noteTextBox.Text;
            _currentNote.Title = _titleTextBox.Text;
            if (_currentNote.Title.Length == 0)
            {
                MessageBox.Show("Невозможно сохранить заметку. Не указанно название.");
                return false;
            }
            return true;
        }
        private void _clearInps()
        {
            _dateTimeSetter.Value = DateTime.Now;
            _timeTextBox.Text = "";
            _noteTextBox.Text = "";
            _titleTextBox.Text = "";
            _signalTextBox.Text = "";
            _showPlanGroupBox(false);

        }
        private void _updateNoteList()
        {
            var notes = _manager.GetDateNotes(_calendar.SelectionStart);
            _showOnDateList(notes);
        }
        private void _showOnDateList(List<Note> notes)
        {
            _dateNotesList.Items.Clear();
            ListViewItem lItem;
            foreach (Note item in notes)
            {
                lItem = new ListViewItem(item.Time.Hour + ":" + item.Time.Minute);
                lItem.SubItems.Add(item.Title);
                _dateNotesList.Items.Add(lItem);
            }       
        }
        private void _btnSaveNote_Click(object sender, EventArgs e)
        {
            if (_isAddNoteMode)
            {
                if (_updateCurrentNoteFields())
                {
                    _manager.Add(_currentNote);
                    _clearInps();
                }
            }
            else
            {
                if (_updateCurrentNoteFields())
                {
                    _updateCurrentNoteFields();
                    _manager.Update();
                    _clearInps();
                }
            }
            if (TimeUtil.IsSameDay(_currentNote.Time ,_calendar.SelectionStart))
                _updateNoteList();
        }

        private void _calendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            var notes = _manager.GetDateNotes(e.Start);
            _showOnDateList(notes);
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            notifyIcon1.Visible = false;
            WindowState = FormWindowState.Normal;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            SetAutorunValue(((CheckBox)sender).Checked);
        }
        public bool SetAutorunValue(bool autorun)
        {
            string ExePath = System.Windows.Forms.Application.ExecutablePath;
            RegistryKey reg;
            reg = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\");
            try
            {
                if (autorun)
                    reg.SetValue("lime productivity", ExePath);
                else
                    reg.DeleteValue("lime productivity");

                reg.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }

        private void _passwordCheckbox_TextChanged(object sender, EventArgs e)
        {
            var tb = (TextBox)sender;
            System.IO.File.WriteAllText("config.bin",tb.Text.GetHashCode().ToString());
        }









    }
}
