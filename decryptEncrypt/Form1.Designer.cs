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
            this.tb_Encrypt_Before = new System.Windows.Forms.TextBox();
            this.tb_Encrypt_Key = new System.Windows.Forms.TextBox();
            this.tb_Encrypt_After = new System.Windows.Forms.TextBox();
            this.tb_Decrypt_Before = new System.Windows.Forms.TextBox();
            this.tb_Decrypt_Key = new System.Windows.Forms.TextBox();
            this.tb_Decrypt_After = new System.Windows.Forms.TextBox();
            this.btn_Encrypt = new System.Windows.Forms.Button();
            this.btn_Decrypt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_Encrypt_Before
            // 
            this.tb_Encrypt_Before.Location = new System.Drawing.Point(139, 54);
            this.tb_Encrypt_Before.Name = "tb_Encrypt_Before";
            this.tb_Encrypt_Before.Size = new System.Drawing.Size(213, 25);
            this.tb_Encrypt_Before.TabIndex = 0;
            // 
            // tb_Encrypt_Key
            // 
            this.tb_Encrypt_Key.Location = new System.Drawing.Point(157, 111);
            this.tb_Encrypt_Key.Name = "tb_Encrypt_Key";
            this.tb_Encrypt_Key.Size = new System.Drawing.Size(204, 25);
            this.tb_Encrypt_Key.TabIndex = 1;
            // 
            // tb_Encrypt_After
            // 
            this.tb_Encrypt_After.Location = new System.Drawing.Point(140, 170);
            this.tb_Encrypt_After.Name = "tb_Encrypt_After";
            this.tb_Encrypt_After.Size = new System.Drawing.Size(183, 25);
            this.tb_Encrypt_After.TabIndex = 2;
            // 
            // tb_Decrypt_Before
            // 
            this.tb_Decrypt_Before.Location = new System.Drawing.Point(137, 271);
            this.tb_Decrypt_Before.Name = "tb_Decrypt_Before";
            this.tb_Decrypt_Before.Size = new System.Drawing.Size(185, 25);
            this.tb_Decrypt_Before.TabIndex = 3;
            // 
            // tb_Decrypt_Key
            // 
            this.tb_Decrypt_Key.Location = new System.Drawing.Point(142, 326);
            this.tb_Decrypt_Key.Name = "tb_Decrypt_Key";
            this.tb_Decrypt_Key.Size = new System.Drawing.Size(191, 25);
            this.tb_Decrypt_Key.TabIndex = 4;
            // 
            // tb_Decrypt_After
            // 
            this.tb_Decrypt_After.Location = new System.Drawing.Point(143, 391);
            this.tb_Decrypt_After.Name = "tb_Decrypt_After";
            this.tb_Decrypt_After.Size = new System.Drawing.Size(238, 25);
            this.tb_Decrypt_After.TabIndex = 5;
            // 
            // btn_Encrypt
            // 
            this.btn_Encrypt.Location = new System.Drawing.Point(440, 113);
            this.btn_Encrypt.Name = "btn_Encrypt";
            this.btn_Encrypt.Size = new System.Drawing.Size(75, 23);
            this.btn_Encrypt.TabIndex = 6;
            this.btn_Encrypt.Text = "button1";
            this.btn_Encrypt.UseVisualStyleBackColor = true;
            this.btn_Encrypt.Click += new System.EventHandler(this.btn_Encrypt_Click);
            // 
            // btn_Decrypt
            // 
            this.btn_Decrypt.Location = new System.Drawing.Point(458, 328);
            this.btn_Decrypt.Name = "btn_Decrypt";
            this.btn_Decrypt.Size = new System.Drawing.Size(75, 23);
            this.btn_Decrypt.TabIndex = 7;
            this.btn_Decrypt.Text = "button2";
            this.btn_Decrypt.UseVisualStyleBackColor = true;
            this.btn_Decrypt.Click += new System.EventHandler(this.btn_Decrypt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Decrypt);
            this.Controls.Add(this.btn_Encrypt);
            this.Controls.Add(this.tb_Decrypt_After);
            this.Controls.Add(this.tb_Decrypt_Key);
            this.Controls.Add(this.tb_Decrypt_Before);
            this.Controls.Add(this.tb_Encrypt_After);
            this.Controls.Add(this.tb_Encrypt_Key);
            this.Controls.Add(this.tb_Encrypt_Before);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }
}

