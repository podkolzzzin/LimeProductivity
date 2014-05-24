namespace winForms_Practice
{
    partial class LimeProductivity
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LimeProductivity));
            this._calendar = new System.Windows.Forms.MonthCalendar();
            this._dateNotesList = new System.Windows.Forms.ListView();
            this.Время = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Название = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._planGroupBox = new System.Windows.Forms.GroupBox();
            this._btnSaveNote = new System.Windows.Forms.Button();
            this._btnPlanOpenFile = new System.Windows.Forms.Button();
            this._signalTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this._noteTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._timeTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this._titleTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._dateTimeSetter = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this._passwordCheckbox = new System.Windows.Forms.TextBox();
            this._usePasswordCheckbox = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this._settingsSignalTextBox = new System.Windows.Forms.TextBox();
            this._btnAddNote = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this._planGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // _calendar
            // 
            this._calendar.Location = new System.Drawing.Point(18, 18);
            this._calendar.Name = "_calendar";
            this._calendar.TabIndex = 0;
            this._calendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this._calendar_DateChanged);
            // 
            // _dateNotesList
            // 
            this._dateNotesList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Время,
            this.Название});
            this._dateNotesList.Location = new System.Drawing.Point(18, 193);
            this._dateNotesList.Name = "_dateNotesList";
            this._dateNotesList.Size = new System.Drawing.Size(164, 298);
            this._dateNotesList.TabIndex = 1;
            this._dateNotesList.UseCompatibleStateImageBehavior = false;
            this._dateNotesList.View = System.Windows.Forms.View.Details;
            // 
            // Время
            // 
            this.Время.Text = "Время";
            this.Время.Width = 48;
            // 
            // Название
            // 
            this.Название.Text = "Название";
            this.Название.Width = 112;
            // 
            // _planGroupBox
            // 
            this._planGroupBox.Controls.Add(this._btnSaveNote);
            this._planGroupBox.Controls.Add(this._btnPlanOpenFile);
            this._planGroupBox.Controls.Add(this._signalTextBox);
            this._planGroupBox.Controls.Add(this.label5);
            this._planGroupBox.Controls.Add(this._noteTextBox);
            this._planGroupBox.Controls.Add(this.label3);
            this._planGroupBox.Controls.Add(this._timeTextBox);
            this._planGroupBox.Controls.Add(this.label4);
            this._planGroupBox.Controls.Add(this._titleTextBox);
            this._planGroupBox.Controls.Add(this.label2);
            this._planGroupBox.Controls.Add(this.label1);
            this._planGroupBox.Controls.Add(this._dateTimeSetter);
            this._planGroupBox.Location = new System.Drawing.Point(194, 18);
            this._planGroupBox.Name = "_planGroupBox";
            this._planGroupBox.Size = new System.Drawing.Size(578, 303);
            this._planGroupBox.TabIndex = 2;
            this._planGroupBox.TabStop = false;
            this._planGroupBox.Text = "План";
            // 
            // _btnSaveNote
            // 
            this._btnSaveNote.Location = new System.Drawing.Point(379, 271);
            this._btnSaveNote.Name = "_btnSaveNote";
            this._btnSaveNote.Size = new System.Drawing.Size(193, 23);
            this._btnSaveNote.TabIndex = 5;
            this._btnSaveNote.Text = "Сохранить";
            this._btnSaveNote.UseVisualStyleBackColor = true;
            this._btnSaveNote.Click += new System.EventHandler(this._btnSaveNote_Click);
            // 
            // _btnPlanOpenFile
            // 
            this._btnPlanOpenFile.Location = new System.Drawing.Point(475, 72);
            this._btnPlanOpenFile.Name = "_btnPlanOpenFile";
            this._btnPlanOpenFile.Size = new System.Drawing.Size(36, 23);
            this._btnPlanOpenFile.TabIndex = 3;
            this._btnPlanOpenFile.Text = "...";
            this._btnPlanOpenFile.UseVisualStyleBackColor = true;
            this._btnPlanOpenFile.Click += new System.EventHandler(this._btnPlanOpenFile_Click);
            // 
            // _signalTextBox
            // 
            this._signalTextBox.Location = new System.Drawing.Point(66, 74);
            this._signalTextBox.Name = "_signalTextBox";
            this._signalTextBox.ReadOnly = true;
            this._signalTextBox.Size = new System.Drawing.Size(403, 20);
            this._signalTextBox.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Сигнал:";
            // 
            // _noteTextBox
            // 
            this._noteTextBox.Location = new System.Drawing.Point(19, 127);
            this._noteTextBox.Multiline = true;
            this._noteTextBox.Name = "_noteTextBox";
            this._noteTextBox.Size = new System.Drawing.Size(553, 138);
            this._noteTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Заметка:";
            // 
            // _timeTextBox
            // 
            this._timeTextBox.Location = new System.Drawing.Point(66, 47);
            this._timeTextBox.Mask = "00:00";
            this._timeTextBox.Name = "_timeTextBox";
            this._timeTextBox.Size = new System.Drawing.Size(41, 20);
            this._timeTextBox.TabIndex = 2;
            this._timeTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Название:";
            // 
            // _titleTextBox
            // 
            this._titleTextBox.Location = new System.Drawing.Point(289, 22);
            this._titleTextBox.Name = "_titleTextBox";
            this._titleTextBox.Size = new System.Drawing.Size(222, 20);
            this._titleTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Время:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Дата:";
            // 
            // _dateTimeSetter
            // 
            this._dateTimeSetter.Location = new System.Drawing.Point(67, 20);
            this._dateTimeSetter.Name = "_dateTimeSetter";
            this._dateTimeSetter.Size = new System.Drawing.Size(126, 20);
            this._dateTimeSetter.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this._passwordCheckbox);
            this.groupBox2.Controls.Add(this._usePasswordCheckbox);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this._settingsSignalTextBox);
            this.groupBox2.Location = new System.Drawing.Point(194, 328);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(578, 222);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Настройки";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(379, 185);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(193, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "Сохранить";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Пароль:";
            // 
            // _passwordCheckbox
            // 
            this._passwordCheckbox.Location = new System.Drawing.Point(73, 101);
            this._passwordCheckbox.MaxLength = 16;
            this._passwordCheckbox.Name = "_passwordCheckbox";
            this._passwordCheckbox.PasswordChar = '*';
            this._passwordCheckbox.ReadOnly = true;
            this._passwordCheckbox.Size = new System.Drawing.Size(137, 20);
            this._passwordCheckbox.TabIndex = 9;
            this._passwordCheckbox.TextChanged += new System.EventHandler(this._passwordCheckbox_TextChanged);
            // 
            // _usePasswordCheckbox
            // 
            this._usePasswordCheckbox.AutoSize = true;
            this._usePasswordCheckbox.Location = new System.Drawing.Point(17, 80);
            this._usePasswordCheckbox.Name = "_usePasswordCheckbox";
            this._usePasswordCheckbox.Size = new System.Drawing.Size(193, 17);
            this._usePasswordCheckbox.TabIndex = 8;
            this._usePasswordCheckbox.Text = "Доступ к расписанию по паролю";
            this._usePasswordCheckbox.UseVisualStyleBackColor = true;
            this._usePasswordCheckbox.CheckedChanged += new System.EventHandler(this._usePasswordCheckbox_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(17, 57);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(85, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Автозапуск";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(475, 27);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(36, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Сигнал по умолчанию:";
            // 
            // _settingsSignalTextBox
            // 
            this._settingsSignalTextBox.Location = new System.Drawing.Point(142, 29);
            this._settingsSignalTextBox.Name = "_settingsSignalTextBox";
            this._settingsSignalTextBox.ReadOnly = true;
            this._settingsSignalTextBox.Size = new System.Drawing.Size(327, 20);
            this._settingsSignalTextBox.TabIndex = 0;
            this._settingsSignalTextBox.Text = "signal.mp3";
            // 
            // _btnAddNote
            // 
            this._btnAddNote.Location = new System.Drawing.Point(18, 513);
            this._btnAddNote.Name = "_btnAddNote";
            this._btnAddNote.Size = new System.Drawing.Size(164, 37);
            this._btnAddNote.TabIndex = 4;
            this._btnAddNote.Text = "Добавить";
            this._btnAddNote.UseVisualStyleBackColor = true;
            this._btnAddNote.Click += new System.EventHandler(this._btnAddNote_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(81, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 5;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // LimeProductivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label8);
            this.Controls.Add(this._btnAddNote);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this._planGroupBox);
            this.Controls.Add(this._dateNotesList);
            this.Controls.Add(this._calendar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "LimeProductivity";
            this.Text = "Lime Productivity";
            this._planGroupBox.ResumeLayout(false);
            this._planGroupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar _calendar;
        private System.Windows.Forms.ListView _dateNotesList;
        private System.Windows.Forms.GroupBox _planGroupBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker _dateTimeSetter;
        private System.Windows.Forms.Button _btnAddNote;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button _btnPlanOpenFile;
        private System.Windows.Forms.TextBox _signalTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox _noteTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox _timeTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _titleTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox _passwordCheckbox;
        private System.Windows.Forms.CheckBox _usePasswordCheckbox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox _settingsSignalTextBox;
        private System.Windows.Forms.Button _btnSaveNote;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ColumnHeader Время;
        private System.Windows.Forms.ColumnHeader Название;
        private System.Windows.Forms.NotifyIcon notifyIcon1;


    }
}

