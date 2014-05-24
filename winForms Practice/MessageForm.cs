using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace winForms_Practice
{
    public partial class MessageForm : Form
    {
        private const string BASIC_SOUND="signal.mp3";
        private string _defaultSound;
        public MessageForm(Note item)
        {
            try
            {
                _defaultSound = System.IO.File.ReadAllText("config.dat");
            }
            catch { }
            InitializeComponent();
            if (item.Signal != null)
            {
                if (item.Signal.Length > 0)
                {
                    try
                    {
                        Audio.Play(item.Signal);
                    }
                    catch
                    {
                        try
                        {
                            Audio.Play(_defaultSound);
                        }
                        catch
                        {
                            Audio.Play(BASIC_SOUND);
                        }
                    }
                }
                else
                {
                    try
                    {
                        Audio.Play(_defaultSound);
                    }
                    catch
                    {
                        Audio.Play(BASIC_SOUND);
                    }
                }
            }
            else
            {
                try
                {
                    Audio.Play(_defaultSound);
                }
                catch
                {
                    Audio.Play(BASIC_SOUND);
                }
            }
            _titleLabel.Text = item.Title;
            _noteTextbox.Text = item.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Audio.Stop();
        }
    }
}
