namespace winForms_Practice
{
    partial class MessageForm
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
            this.button1 = new System.Windows.Forms.Button();
            this._titleLabel = new System.Windows.Forms.Label();
            this._noteTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 127);
            this.button1.TabIndex = 0;
            this.button1.Text = "Stop";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // _titleLabel
            // 
            this._titleLabel.AutoSize = true;
            this._titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._titleLabel.Location = new System.Drawing.Point(227, 13);
            this._titleLabel.Name = "_titleLabel";
            this._titleLabel.Size = new System.Drawing.Size(165, 20);
            this._titleLabel.TabIndex = 1;
            this._titleLabel.Text = "AAAAAAAAAAAAA";
            // 
            // _noteTextbox
            // 
            this._noteTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._noteTextbox.Location = new System.Drawing.Point(227, 41);
            this._noteTextbox.Multiline = true;
            this._noteTextbox.Name = "_noteTextbox";
            this._noteTextbox.ReadOnly = true;
            this._noteTextbox.Size = new System.Drawing.Size(509, 99);
            this._noteTextbox.TabIndex = 2;
            // 
            // MessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 156);
            this.Controls.Add(this._noteTextbox);
            this.Controls.Add(this._titleLabel);
            this.Controls.Add(this.button1);
            this.MaximumSize = new System.Drawing.Size(764, 195);
            this.MinimumSize = new System.Drawing.Size(764, 195);
            this.Name = "MessageForm";
            this.Text = "MessageForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label _titleLabel;
        private System.Windows.Forms.TextBox _noteTextbox;
    }
}