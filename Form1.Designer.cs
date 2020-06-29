namespace smtp
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
            this.ottb = new System.Windows.Forms.TextBox();
            this.otlab = new System.Windows.Forms.Label();
            this.kolab = new System.Windows.Forms.Label();
            this.plab = new System.Windows.Forms.Label();
            this.ptb = new System.Windows.Forms.TextBox();
            this.kotb = new System.Windows.Forms.TextBox();
            this.msg = new System.Windows.Forms.TextBox();
            this.sendbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ottb
            // 
            this.ottb.Location = new System.Drawing.Point(47, 45);
            this.ottb.Name = "ottb";
            this.ottb.Size = new System.Drawing.Size(201, 20);
            this.ottb.TabIndex = 0;
            // 
            // otlab
            // 
            this.otlab.Location = new System.Drawing.Point(44, 24);
            this.otlab.Name = "otlab";
            this.otlab.Size = new System.Drawing.Size(73, 18);
            this.otlab.TabIndex = 1;
            this.otlab.Text = " От кого:";
            // 
            // kolab
            // 
            this.kolab.Location = new System.Drawing.Point(337, 24);
            this.kolab.Name = "kolab";
            this.kolab.Size = new System.Drawing.Size(73, 18);
            this.kolab.TabIndex = 3;
            this.kolab.Text = "Кому:";
            // 
            // plab
            // 
            this.plab.Location = new System.Drawing.Point(44, 87);
            this.plab.Name = "plab";
            this.plab.Size = new System.Drawing.Size(73, 18);
            this.plab.TabIndex = 5;
            this.plab.Text = "Пароль:";
            // 
            // ptb
            // 
            this.ptb.Location = new System.Drawing.Point(47, 108);
            this.ptb.Name = "ptb";
            this.ptb.PasswordChar = '•';
            this.ptb.Size = new System.Drawing.Size(201, 20);
            this.ptb.TabIndex = 4;
            // 
            // kotb
            // 
            this.kotb.Location = new System.Drawing.Point(339, 45);
            this.kotb.Name = "kotb";
            this.kotb.Size = new System.Drawing.Size(201, 20);
            this.kotb.TabIndex = 6;
            // 
            // msg
            // 
            this.msg.Location = new System.Drawing.Point(54, 150);
            this.msg.Multiline = true;
            this.msg.Name = "msg";
            this.msg.Size = new System.Drawing.Size(486, 221);
            this.msg.TabIndex = 7;
            // 
            // sendbtn
            // 
            this.sendbtn.Location = new System.Drawing.Point(177, 384);
            this.sendbtn.Name = "sendbtn";
            this.sendbtn.Size = new System.Drawing.Size(205, 54);
            this.sendbtn.TabIndex = 8;
            this.sendbtn.Text = "Отправить";
            this.sendbtn.UseVisualStyleBackColor = true;
            this.sendbtn.Click += new System.EventHandler(this.sendbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(602, 450);
            this.Controls.Add(this.sendbtn);
            this.Controls.Add(this.msg);
            this.Controls.Add(this.kotb);
            this.Controls.Add(this.plab);
            this.Controls.Add(this.ptb);
            this.Controls.Add(this.kolab);
            this.Controls.Add(this.otlab);
            this.Controls.Add(this.ottb);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "send";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ottb;
        private System.Windows.Forms.Label otlab;
        private System.Windows.Forms.Label kolab;
        private System.Windows.Forms.Label plab;
        private System.Windows.Forms.TextBox ptb;
        private System.Windows.Forms.TextBox kotb;
        private System.Windows.Forms.TextBox msg;
        private System.Windows.Forms.Button sendbtn;
    }
}

