namespace App
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.Pass_word = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Button();
            this.sign = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.password_back = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(409, 78);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(489, 46);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(409, 158);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(489, 46);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("宋体", 16F);
            this.name.Location = new System.Drawing.Point(252, 78);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(151, 62);
            this.name.TabIndex = 2;
            this.name.Text = "User_ID:";
            this.name.Click += new System.EventHandler(this.name_Click);
            // 
            // Pass_word
            // 
            this.Pass_word.Font = new System.Drawing.Font("宋体", 16F);
            this.Pass_word.Location = new System.Drawing.Point(232, 158);
            this.Pass_word.Name = "Pass_word";
            this.Pass_word.Size = new System.Drawing.Size(171, 62);
            this.Pass_word.TabIndex = 3;
            this.Pass_word.Text = "Password:";
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("宋体", 16F);
            this.login.Location = new System.Drawing.Point(597, 380);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(181, 72);
            this.login.TabIndex = 4;
            this.login.Text = "登录";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // sign
            // 
            this.sign.Font = new System.Drawing.Font("宋体", 16F);
            this.sign.Location = new System.Drawing.Point(267, 380);
            this.sign.Name = "sign";
            this.sign.Size = new System.Drawing.Size(181, 72);
            this.sign.TabIndex = 5;
            this.sign.Text = "注册";
            this.sign.UseVisualStyleBackColor = true;
            this.sign.Click += new System.EventHandler(this.sign_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // password_back
            // 
            this.password_back.Font = new System.Drawing.Font("宋体", 14F);
            this.password_back.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.password_back.Location = new System.Drawing.Point(769, 241);
            this.password_back.Name = "password_back";
            this.password_back.Size = new System.Drawing.Size(129, 27);
            this.password_back.TabIndex = 6;
            this.password_back.Text = "找回密码";
            this.password_back.Click += new System.EventHandler(this.password_back_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("宋体", 14F);
            this.label1.Location = new System.Drawing.Point(592, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 27);
            this.label1.TabIndex = 7;
            this.label1.Text = "忘记密码?：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 591);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password_back);
            this.Controls.Add(this.sign);
            this.Controls.Add(this.login);
            this.Controls.Add(this.Pass_word);
            this.Controls.Add(this.name);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label Pass_word;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button sign;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label password_back;
        private System.Windows.Forms.Label label1;
    }
}

