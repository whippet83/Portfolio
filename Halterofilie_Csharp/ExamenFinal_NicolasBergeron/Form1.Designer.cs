namespace ExamenFinal_NicolasBergeron
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pbLogin = new System.Windows.Forms.PictureBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPwd = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.pillBtnLogin = new ExamenFinal_NicolasBergeron.PillButton();
            this.lblSeePwd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(325, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Haltérophilie Canada";
            // 
            // pbLogo
            // 
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(231, 120);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(102, 98);
            this.pbLogo.TabIndex = 1;
            this.pbLogo.TabStop = false;
            // 
            // pbLogin
            // 
            this.pbLogin.Image = global::ExamenFinal_NicolasBergeron.Properties.Resources.crossfit_g8a69c8747_1920;
            this.pbLogin.Location = new System.Drawing.Point(-5, 584);
            this.pbLogin.Name = "pbLogin";
            this.pbLogin.Size = new System.Drawing.Size(975, 317);
            this.pbLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogin.TabIndex = 2;
            this.pbLogin.TabStop = false;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUser.Location = new System.Drawing.Point(137, 255);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(199, 32);
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = "Nom d\'utilisateur";
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPwd.Location = new System.Drawing.Point(137, 346);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(156, 32);
            this.lblPwd.TabIndex = 4;
            this.lblPwd.Text = "Mot de Passe";
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUser.ForeColor = System.Drawing.Color.Gray;
            this.txtUser.Location = new System.Drawing.Point(146, 290);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(632, 34);
            this.txtUser.TabIndex = 5;
            this.txtUser.Enter += new System.EventHandler(this.txtUser_Enter);
            // 
            // txtPwd
            // 
            this.txtPwd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPwd.ForeColor = System.Drawing.Color.Gray;
            this.txtPwd.Location = new System.Drawing.Point(146, 381);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(632, 34);
            this.txtPwd.TabIndex = 6;
            this.txtPwd.Enter += new System.EventHandler(this.txtPwd_Enter);
            // 
            // pillBtnLogin
            // 
            this.pillBtnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.pillBtnLogin.FlatAppearance.BorderSize = 0;
            this.pillBtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pillBtnLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pillBtnLogin.ForeColor = System.Drawing.Color.White;
            this.pillBtnLogin.Location = new System.Drawing.Point(137, 453);
            this.pillBtnLogin.Name = "pillBtnLogin";
            this.pillBtnLogin.Size = new System.Drawing.Size(641, 54);
            this.pillBtnLogin.TabIndex = 7;
            this.pillBtnLogin.Text = "Connexion";
            this.pillBtnLogin.UseVisualStyleBackColor = false;
            this.pillBtnLogin.Click += new System.EventHandler(this.pillBtnLogin_Click);
            // 
            // lblSeePwd
            // 
            this.lblSeePwd.AutoSize = true;
            this.lblSeePwd.Image = global::ExamenFinal_NicolasBergeron.Properties.Resources.icons8_eye_30px;
            this.lblSeePwd.Location = new System.Drawing.Point(732, 387);
            this.lblSeePwd.Name = "lblSeePwd";
            this.lblSeePwd.Size = new System.Drawing.Size(37, 25);
            this.lblSeePwd.TabIndex = 9;
            this.lblSeePwd.Text = "     ";
            this.lblSeePwd.Click += new System.EventHandler(this.lblSeePwd_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 892);
            this.Controls.Add(this.lblSeePwd);
            this.Controls.Add(this.pillBtnLogin);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.pbLogin);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Haltérophilie Canada";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private PictureBox pbLogo;
        private PictureBox pbLogin;
        private Label lblUser;
        private Label lblPwd;
        private TextBox txtUser;
        private TextBox txtPwd;
        private PillButton pillBtnLogin;
        private Label lblSeePwd;
    }
}