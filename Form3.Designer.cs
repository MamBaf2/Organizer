namespace Organizer
{
    partial class Form3
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dateCal = new System.Windows.Forms.MonthCalendar();
            this.timePic = new System.Windows.Forms.DateTimePicker();
            this.text = new System.Windows.Forms.TextBox();
            this.typeCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.saveBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateCal
            // 
            this.dateCal.CalendarDimensions = new System.Drawing.Size(3, 1);
            this.dateCal.Location = new System.Drawing.Point(0, 0);
            this.dateCal.MaxSelectionCount = 1;
            this.dateCal.Name = "dateCal";
            this.dateCal.TabIndex = 0;
            // 
            // timePic
            // 
            this.timePic.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePic.Location = new System.Drawing.Point(12, 213);
            this.timePic.Name = "timePic";
            this.timePic.ShowUpDown = true;
            this.timePic.Size = new System.Drawing.Size(78, 20);
            this.timePic.TabIndex = 1;
            this.timePic.Value = new System.DateTime(2024, 1, 19, 9, 30, 0, 0);
            // 
            // text
            // 
            this.text.Location = new System.Drawing.Point(96, 213);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(266, 20);
            this.text.TabIndex = 2;
            // 
            // typeCombo
            // 
            this.typeCombo.FormattingEnabled = true;
            this.typeCombo.Items.AddRange(new object[] {
            "Памятка",
            "Встреча",
            "Задание"});
            this.typeCombo.Location = new System.Drawing.Point(368, 212);
            this.typeCombo.Name = "typeCombo";
            this.typeCombo.Size = new System.Drawing.Size(121, 21);
            this.typeCombo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Текст";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(414, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Тип";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Время";
            // 
            // saveBut
            // 
            this.saveBut.Location = new System.Drawing.Point(12, 257);
            this.saveBut.Name = "saveBut";
            this.saveBut.Size = new System.Drawing.Size(477, 68);
            this.saveBut.TabIndex = 7;
            this.saveBut.Text = "ОК";
            this.saveBut.UseVisualStyleBackColor = true;
            this.saveBut.Click += new System.EventHandler(this.saveBut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 335);
            this.Controls.Add(this.saveBut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.typeCombo);
            this.Controls.Add(this.text);
            this.Controls.Add(this.timePic);
            this.Controls.Add(this.dateCal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar dateCal;
        private System.Windows.Forms.DateTimePicker timePic;
        private System.Windows.Forms.TextBox text;
        private System.Windows.Forms.ComboBox typeCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button saveBut;
    }
}

