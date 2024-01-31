namespace Organizer
{
    partial class Form1
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
            this.lblLog = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.checkShow = new System.Windows.Forms.CheckBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnEnt = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLog
            // 
            this.lblLog.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLog.AutoSize = true;
            this.lblLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLog.Location = new System.Drawing.Point(25, 29);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(50, 15);
            this.lblLog.TabIndex = 0;
            this.lblLog.Text = "Логин:";
            // 
            // lblPass
            // 
            this.lblPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPass.Location = new System.Drawing.Point(25, 114);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(61, 15);
            this.lblPass.TabIndex = 0;
            this.lblPass.Text = "Пароль:";
            // 
            // checkShow
            // 
            this.checkShow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkShow.AutoSize = true;
            this.checkShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkShow.Location = new System.Drawing.Point(172, 113);
            this.checkShow.Name = "checkShow";
            this.checkShow.Size = new System.Drawing.Size(142, 19);
            this.checkShow.TabIndex = 1;
            this.checkShow.Text = "Показать пароль";
            this.checkShow.UseVisualStyleBackColor = true;
            // 
            // txtLog
            // 
            this.txtLog.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtLog.Location = new System.Drawing.Point(29, 61);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(139, 21);
            this.txtLog.TabIndex = 2;
            this.txtLog.Enter += new System.EventHandler(this.txtLog_Enter);
            this.txtLog.Leave += new System.EventHandler(this.txtLog_Leave);
            // 
            // txtPass
            // 
            this.txtPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPass.Location = new System.Drawing.Point(29, 146);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(139, 21);
            this.txtPass.TabIndex = 2;
            this.txtPass.Enter += new System.EventHandler(this.txtPass_Enter);
            this.txtPass.Leave += new System.EventHandler(this.txtPass_Leave);
            // 
            // btnEnt
            // 
            this.btnEnt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEnt.Location = new System.Drawing.Point(30, 228);
            this.btnEnt.MaximumSize = new System.Drawing.Size(150, 60);
            this.btnEnt.MinimumSize = new System.Drawing.Size(109, 55);
            this.btnEnt.Name = "btnEnt";
            this.btnEnt.Size = new System.Drawing.Size(109, 55);
            this.btnEnt.TabIndex = 3;
            this.btnEnt.Text = "Войти";
            this.btnEnt.UseVisualStyleBackColor = true;
            this.btnEnt.Click += new System.EventHandler(this.btnEnt_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(254, 228);
            this.btnExit.MaximumSize = new System.Drawing.Size(150, 60);
            this.btnExit.MinimumSize = new System.Drawing.Size(109, 55);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(109, 55);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(394, 301);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEnt);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.checkShow);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblLog);
            this.MaximumSize = new System.Drawing.Size(510, 440);
            this.MinimumSize = new System.Drawing.Size(410, 340);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.CheckBox checkShow;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnEnt;
        private System.Windows.Forms.Button btnExit;
    }
}

