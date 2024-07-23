namespace PasswordAuthAppDemoo2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelGeneratedPassword = new System.Windows.Forms.Label();
            this.labelTimer = new System.Windows.Forms.Label();
            this.txtEnteredPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelGeneratedPassword
            // 
            this.labelGeneratedPassword.AutoSize = true;
            this.labelGeneratedPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelGeneratedPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelGeneratedPassword.Location = new System.Drawing.Point(47, 62);
            this.labelGeneratedPassword.Name = "labelGeneratedPassword";
            this.labelGeneratedPassword.Size = new System.Drawing.Size(121, 40);
            this.labelGeneratedPassword.TabIndex = 0;
            this.labelGeneratedPassword.Text = "Şifre : ";
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTimer.Location = new System.Drawing.Point(520, 198);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(150, 31);
            this.labelTimer.TabIndex = 1;
            this.labelTimer.Text = "Kalan Süre:";
            // 
            // txtEnteredPassword
            // 
            this.txtEnteredPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEnteredPassword.Location = new System.Drawing.Point(520, 62);
            this.txtEnteredPassword.Name = "txtEnteredPassword";
            this.txtEnteredPassword.Size = new System.Drawing.Size(237, 45);
            this.txtEnteredPassword.TabIndex = 2;
            this.txtEnteredPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogin.Location = new System.Drawing.Point(619, 127);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(97, 40);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Giriş";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.BackColor = System.Drawing.Color.White;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelResult.ForeColor = System.Drawing.Color.Lime;
            this.labelResult.Location = new System.Drawing.Point(516, 265);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 20);
            this.labelResult.TabIndex = 4;
            this.labelResult.Click += new System.EventHandler(this.labelResult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PasswordAuthAppDemoo2.Properties.Resources.Adsız_tasarım__4_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(843, 454);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtEnteredPassword);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.labelGeneratedPassword);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "authenticator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelGeneratedPassword;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.TextBox txtEnteredPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Timer timer1;
    }
}