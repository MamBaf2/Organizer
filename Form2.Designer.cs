namespace Organizer
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEvent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cat = new System.Windows.Forms.RadioButton();
            this.ev = new System.Windows.Forms.RadioButton();
            this.filBut = new System.Windows.Forms.Button();
            this.finBut = new System.Windows.Forms.Button();
            this.addBut = new System.Windows.Forms.Button();
            this.cBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDate,
            this.colTime,
            this.colEvent});
            this.dataGridView1.Location = new System.Drawing.Point(8, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(347, 318);
            this.dataGridView1.TabIndex = 0;
            // 
            // colDate
            // 
            this.colDate.HeaderText = "Дата";
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            // 
            // colTime
            // 
            this.colTime.HeaderText = "Время";
            this.colTime.Name = "colTime";
            this.colTime.ReadOnly = true;
            // 
            // colEvent
            // 
            this.colEvent.HeaderText = "Событие";
            this.colEvent.Name = "colEvent";
            this.colEvent.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cBox);
            this.groupBox1.Controls.Add(this.ev);
            this.groupBox1.Controls.Add(this.cat);
            this.groupBox1.Location = new System.Drawing.Point(8, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 70);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.filBut);
            this.groupBox2.Controls.Add(this.finBut);
            this.groupBox2.Controls.Add(this.addBut);
            this.groupBox2.Location = new System.Drawing.Point(12, 412);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(343, 65);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Операции";
            // 
            // cat
            // 
            this.cat.AutoSize = true;
            this.cat.Location = new System.Drawing.Point(6, 19);
            this.cat.Name = "cat";
            this.cat.Size = new System.Drawing.Size(78, 17);
            this.cat.TabIndex = 0;
            this.cat.TabStop = true;
            this.cat.Text = "Категории";
            this.cat.UseVisualStyleBackColor = true;
            // 
            // ev
            // 
            this.ev.AutoSize = true;
            this.ev.Location = new System.Drawing.Point(6, 42);
            this.ev.Name = "ev";
            this.ev.Size = new System.Drawing.Size(69, 17);
            this.ev.TabIndex = 1;
            this.ev.TabStop = true;
            this.ev.Text = "События";
            this.ev.UseVisualStyleBackColor = true;
            // 
            // filBut
            // 
            this.filBut.Location = new System.Drawing.Point(10, 17);
            this.filBut.Name = "filBut";
            this.filBut.Size = new System.Drawing.Size(105, 40);
            this.filBut.TabIndex = 3;
            this.filBut.Text = "Фильтр";
            this.filBut.UseVisualStyleBackColor = true;
            this.filBut.Click += new System.EventHandler(this.button1_Click);
            // 
            // finBut
            // 
            this.finBut.Location = new System.Drawing.Point(121, 17);
            this.finBut.Name = "finBut";
            this.finBut.Size = new System.Drawing.Size(105, 40);
            this.finBut.TabIndex = 4;
            this.finBut.Text = "Поиск";
            this.finBut.UseVisualStyleBackColor = true;
            // 
            // addBut
            // 
            this.addBut.Location = new System.Drawing.Point(232, 17);
            this.addBut.Name = "addBut";
            this.addBut.Size = new System.Drawing.Size(105, 40);
            this.addBut.TabIndex = 5;
            this.addBut.Text = "Добавить";
            this.addBut.UseVisualStyleBackColor = true;
            // 
            // cBox
            // 
            this.cBox.FormattingEnabled = true;
            this.cBox.Location = new System.Drawing.Point(146, 19);
            this.cBox.Name = "cBox";
            this.cBox.Size = new System.Drawing.Size(195, 21);
            this.cBox.TabIndex = 6;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 487);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEvent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton ev;
        private System.Windows.Forms.RadioButton cat;
        private System.Windows.Forms.Button filBut;
        private System.Windows.Forms.Button finBut;
        private System.Windows.Forms.Button addBut;
        private System.Windows.Forms.ComboBox cBox;
    }
}