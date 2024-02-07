namespace Organizer
{
    partial class Form3
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
            this.saveBut = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.typeCombo = new System.Windows.Forms.ComboBox();
            this.text = new System.Windows.Forms.TextBox();
            this.timePic = new System.Windows.Forms.DateTimePicker();
            this.dateCal = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // saveBut
            // 
            this.saveBut.Location = new System.Drawing.Point(7, 286);
            this.saveBut.Name = "saveBut";
            this.saveBut.Size = new System.Drawing.Size(477, 68);
            this.saveBut.TabIndex = 15;
            this.saveBut.Text = "ОК";
            this.saveBut.UseVisualStyleBackColor = true;
            this.saveBut.Click += new System.EventHandler(this.saveBut_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Время";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(409, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Тип";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Текст";
            // 
            // typeCombo
            // 
            this.typeCombo.FormattingEnabled = true;
            this.typeCombo.Items.AddRange(new object[] {
            "Памятка",
            "Встреча",
            "Задание"});
            this.typeCombo.Location = new System.Drawing.Point(363, 241);
            this.typeCombo.Name = "typeCombo";
            this.typeCombo.Size = new System.Drawing.Size(121, 21);
            this.typeCombo.TabIndex = 11;
            // 
            // text
            // 
            this.text.Location = new System.Drawing.Point(91, 242);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(266, 20);
            this.text.TabIndex = 10;
            // 
            // timePic
            // 
            this.timePic.CustomFormat = "00:00:0000";
            this.timePic.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePic.Location = new System.Drawing.Point(7, 242);
            this.timePic.Name = "timePic";
            this.timePic.ShowUpDown = true;
            this.timePic.Size = new System.Drawing.Size(78, 20);
            this.timePic.TabIndex = 9;
            this.timePic.Value = new System.DateTime(2024, 2, 7, 9, 30, 0, 0);
            // 
            // dateCal
            // 
            this.dateCal.CalendarDimensions = new System.Drawing.Size(3, 1);
            this.dateCal.Location = new System.Drawing.Point(-5, 29);
            this.dateCal.MaxSelectionCount = 1;
            this.dateCal.Name = "dateCal";
            this.dateCal.TabIndex = 8;
            this.dateCal.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.dateCal_DateChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 382);
            this.Controls.Add(this.saveBut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.typeCombo);
            this.Controls.Add(this.text);
            this.Controls.Add(this.timePic);
            this.Controls.Add(this.dateCal);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveBut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox typeCombo;
        private System.Windows.Forms.TextBox text;
        private System.Windows.Forms.DateTimePicker timePic;
        private System.Windows.Forms.MonthCalendar dateCal;
    }
}