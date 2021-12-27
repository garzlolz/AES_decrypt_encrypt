namespace decryptEncrypt
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tb_Encrypt_Before = new System.Windows.Forms.TextBox();
            this.tb_Encrypt_Key = new System.Windows.Forms.TextBox();
            this.tb_Encrypt_After = new System.Windows.Forms.TextBox();
            this.tb_Decrypt_Before = new System.Windows.Forms.TextBox();
            this.tb_Decrypt_Key = new System.Windows.Forms.TextBox();
            this.tb_Decrypt_After = new System.Windows.Forms.TextBox();
            this.btn_Encrypt = new System.Windows.Forms.Button();
            this.btn_Decrypt = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Content = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_Encrypt_Before
            // 
            this.tb_Encrypt_Before.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_Encrypt_Before.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Encrypt_Before.ForeColor = System.Drawing.Color.White;
            this.tb_Encrypt_Before.Location = new System.Drawing.Point(20, 150);
            this.tb_Encrypt_Before.Name = "tb_Encrypt_Before";
            this.tb_Encrypt_Before.Size = new System.Drawing.Size(300, 18);
            this.tb_Encrypt_Before.TabIndex = 0;
            // 
            // tb_Encrypt_Key
            // 
            this.tb_Encrypt_Key.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_Encrypt_Key.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Encrypt_Key.ForeColor = System.Drawing.SystemColors.Window;
            this.tb_Encrypt_Key.Location = new System.Drawing.Point(20, 209);
            this.tb_Encrypt_Key.Name = "tb_Encrypt_Key";
            this.tb_Encrypt_Key.Size = new System.Drawing.Size(300, 18);
            this.tb_Encrypt_Key.TabIndex = 1;
            // 
            // tb_Encrypt_After
            // 
            this.tb_Encrypt_After.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_Encrypt_After.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Encrypt_After.ForeColor = System.Drawing.SystemColors.Window;
            this.tb_Encrypt_After.Location = new System.Drawing.Point(20, 266);
            this.tb_Encrypt_After.Name = "tb_Encrypt_After";
            this.tb_Encrypt_After.Size = new System.Drawing.Size(300, 18);
            this.tb_Encrypt_After.TabIndex = 2;
            // 
            // tb_Decrypt_Before
            // 
            this.tb_Decrypt_Before.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_Decrypt_Before.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Decrypt_Before.ForeColor = System.Drawing.SystemColors.Window;
            this.tb_Decrypt_Before.Location = new System.Drawing.Point(17, 150);
            this.tb_Decrypt_Before.Name = "tb_Decrypt_Before";
            this.tb_Decrypt_Before.Size = new System.Drawing.Size(300, 18);
            this.tb_Decrypt_Before.TabIndex = 3;
            // 
            // tb_Decrypt_Key
            // 
            this.tb_Decrypt_Key.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_Decrypt_Key.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Decrypt_Key.ForeColor = System.Drawing.SystemColors.Window;
            this.tb_Decrypt_Key.Location = new System.Drawing.Point(17, 209);
            this.tb_Decrypt_Key.Name = "tb_Decrypt_Key";
            this.tb_Decrypt_Key.Size = new System.Drawing.Size(300, 18);
            this.tb_Decrypt_Key.TabIndex = 4;
            // 
            // tb_Decrypt_After
            // 
            this.tb_Decrypt_After.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_Decrypt_After.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Decrypt_After.ForeColor = System.Drawing.SystemColors.Window;
            this.tb_Decrypt_After.Location = new System.Drawing.Point(17, 266);
            this.tb_Decrypt_After.Name = "tb_Decrypt_After";
            this.tb_Decrypt_After.Size = new System.Drawing.Size(300, 18);
            this.tb_Decrypt_After.TabIndex = 5;
            // 
            // btn_Encrypt
            // 
            this.btn_Encrypt.Font = new System.Drawing.Font("新細明體", 15F);
            this.btn_Encrypt.ForeColor = System.Drawing.Color.Red;
            this.btn_Encrypt.Location = new System.Drawing.Point(129, 333);
            this.btn_Encrypt.Name = "btn_Encrypt";
            this.btn_Encrypt.Size = new System.Drawing.Size(75, 34);
            this.btn_Encrypt.TabIndex = 6;
            this.btn_Encrypt.Text = "加密";
            this.btn_Encrypt.UseVisualStyleBackColor = true;
            this.btn_Encrypt.Click += new System.EventHandler(this.btn_Encrypt_Click);
            // 
            // btn_Decrypt
            // 
            this.btn_Decrypt.Font = new System.Drawing.Font("新細明體", 15F);
            this.btn_Decrypt.Location = new System.Drawing.Point(131, 333);
            this.btn_Decrypt.Name = "btn_Decrypt";
            this.btn_Decrypt.Size = new System.Drawing.Size(75, 34);
            this.btn_Decrypt.TabIndex = 7;
            this.btn_Decrypt.Text = "解密";
            this.btn_Decrypt.UseVisualStyleBackColor = true;
            this.btn_Decrypt.Click += new System.EventHandler(this.btn_Decrypt_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Content);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_Encrypt);
            this.panel1.Controls.Add(this.tb_Encrypt_After);
            this.panel1.Controls.Add(this.tb_Encrypt_Key);
            this.panel1.Controls.Add(this.tb_Encrypt_Before);
            this.panel1.Location = new System.Drawing.Point(47, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 382);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btn_Decrypt);
            this.panel2.Controls.Add(this.tb_Decrypt_After);
            this.panel2.Controls.Add(this.tb_Decrypt_Key);
            this.panel2.Controls.Add(this.tb_Decrypt_Before);
            this.panel2.Location = new System.Drawing.Point(448, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(327, 382);
            this.panel2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 20F);
            this.label1.ForeColor = System.Drawing.SystemColors.Menu;
            this.label1.Location = new System.Drawing.Point(89, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 34);
            this.label1.TabIndex = 7;
            this.label1.Text = "字串加密";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 20F);
            this.label2.ForeColor = System.Drawing.SystemColors.Menu;
            this.label2.Location = new System.Drawing.Point(102, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 34);
            this.label2.TabIndex = 8;
            this.label2.Text = "字串解密";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 30F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(287, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 50);
            this.label3.TabIndex = 10;
            this.label3.Text = "AES加解密";
            // 
            // Content
            // 
            this.Content.AutoSize = true;
            this.Content.ForeColor = System.Drawing.SystemColors.Window;
            this.Content.Location = new System.Drawing.Point(17, 132);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(86, 15);
            this.Content.TabIndex = 8;
            this.Content.Text = "加密前字串:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(17, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "加密後字串:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(17, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "金鑰:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(14, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "解密前字串:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(14, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "金鑰:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Window;
            this.label8.Location = new System.Drawing.Point(14, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "解密後字串:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Encrypt_Before;
        private System.Windows.Forms.TextBox tb_Encrypt_Key;
        private System.Windows.Forms.TextBox tb_Encrypt_After;
        private System.Windows.Forms.TextBox tb_Decrypt_Before;
        private System.Windows.Forms.TextBox tb_Decrypt_Key;
        private System.Windows.Forms.TextBox tb_Decrypt_After;
        private System.Windows.Forms.Button btn_Encrypt;
        private System.Windows.Forms.Button btn_Decrypt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Content;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

