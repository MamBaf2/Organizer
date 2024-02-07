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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.filBut = new System.Windows.Forms.Button();
            this.delBut = new System.Windows.Forms.Button();
            this.addBut = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.text = new System.Windows.Forms.TextBox();
            this.cBox = new System.Windows.Forms.ComboBox();
            this.ev = new System.Windows.Forms.RadioButton();
            this.cat = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEvent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.filBut);
            this.groupBox2.Controls.Add(this.delBut);
            this.groupBox2.Controls.Add(this.addBut);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(27, 403);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(343, 65);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Операции";
            // 
            // filBut
            // 
            this.filBut.BackColor = System.Drawing.Color.White;
            this.filBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filBut.Location = new System.Drawing.Point(10, 17);
            this.filBut.Name = "filBut";
            this.filBut.Size = new System.Drawing.Size(105, 40);
            this.filBut.TabIndex = 3;
            this.filBut.Text = "Фильтр";
            this.filBut.UseVisualStyleBackColor = false;
            this.filBut.Click += new System.EventHandler(this.filBut_Click);
            // 
            // delBut
            // 
            this.delBut.BackColor = System.Drawing.Color.White;
            this.delBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delBut.Location = new System.Drawing.Point(121, 17);
            this.delBut.Name = "delBut";
            this.delBut.Size = new System.Drawing.Size(105, 40);
            this.delBut.TabIndex = 4;
            this.delBut.Text = "Удалить";
            this.delBut.UseVisualStyleBackColor = false;
            this.delBut.Click += new System.EventHandler(this.delBut_Click);
            // 
            // addBut
            // 
            this.addBut.BackColor = System.Drawing.Color.White;
            this.addBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addBut.Location = new System.Drawing.Point(232, 17);
            this.addBut.Name = "addBut";
            this.addBut.Size = new System.Drawing.Size(105, 40);
            this.addBut.TabIndex = 5;
            this.addBut.Text = "Добавить";
            this.addBut.UseVisualStyleBackColor = false;
            this.addBut.Click += new System.EventHandler(this.addBut_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.text);
            this.groupBox1.Controls.Add(this.cBox);
            this.groupBox1.Controls.Add(this.ev);
            this.groupBox1.Controls.Add(this.cat);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(23, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 70);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск";
            // 
            // text
            // 
            this.text.Location = new System.Drawing.Point(146, 20);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(195, 21);
            this.text.TabIndex = 7;
            // 
            // cBox
            // 
            this.cBox.FormattingEnabled = true;
            this.cBox.Items.AddRange(new object[] {
            "❕",
            "🤝",
            "🎯"});
            this.cBox.Location = new System.Drawing.Point(146, 19);
            this.cBox.Name = "cBox";
            this.cBox.Size = new System.Drawing.Size(195, 23);
            this.cBox.TabIndex = 6;
            // 
            // ev
            // 
            this.ev.AutoSize = true;
            this.ev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ev.Location = new System.Drawing.Point(6, 42);
            this.ev.Name = "ev";
            this.ev.Size = new System.Drawing.Size(77, 19);
            this.ev.TabIndex = 1;
            this.ev.TabStop = true;
            this.ev.Text = "События";
            this.ev.UseVisualStyleBackColor = true;
            // 
            // cat
            // 
            this.cat.AutoSize = true;
            this.cat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cat.Location = new System.Drawing.Point(6, 19);
            this.cat.Name = "cat";
            this.cat.Size = new System.Drawing.Size(87, 19);
            this.cat.TabIndex = 0;
            this.cat.TabStop = true;
            this.cat.Text = "Категории";
            this.cat.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColType,
            this.colDate,
            this.colTime,
            this.colEvent});
            this.dataGridView1.Location = new System.Drawing.Point(23, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(347, 318);
            this.dataGridView1.TabIndex = 3;
            // 
            // ColType
            // 
            this.ColType.HeaderText = "Тип";
            this.ColType.Name = "ColType";
            this.ColType.ReadOnly = true;
            this.ColType.Width = 35;
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
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(394, 483);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.MaximumSize = new System.Drawing.Size(450, 562);
            this.MinimumSize = new System.Drawing.Size(410, 522);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Органайзер";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button filBut;
        private System.Windows.Forms.Button delBut;
        private System.Windows.Forms.Button addBut;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cBox;
        private System.Windows.Forms.RadioButton ev;
        private System.Windows.Forms.RadioButton cat;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox text;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEvent;
    }
}