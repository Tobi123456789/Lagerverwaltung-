namespace Login_System_Tut_ecnrypted
{
    partial class Login
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
            this.btn_anmelden = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usrTxt = new System.Windows.Forms.TextBox();
            this.passTxt = new System.Windows.Forms.TextBox();
            this.lbl_benutzerlogin = new System.Windows.Forms.Label();
            this.lbl_passwort_vergessen = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_anmelden
            // 
            this.btn_anmelden.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_anmelden.Location = new System.Drawing.Point(323, 216);
            this.btn_anmelden.Name = "btn_anmelden";
            this.btn_anmelden.Size = new System.Drawing.Size(222, 36);
            this.btn_anmelden.TabIndex = 3;
            this.btn_anmelden.Text = "Anmelden";
            this.btn_anmelden.UseVisualStyleBackColor = true;
            this.btn_anmelden.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Benutzername:";
            // 
            // usrTxt
            // 
            this.usrTxt.Location = new System.Drawing.Point(323, 122);
            this.usrTxt.Name = "usrTxt";
            this.usrTxt.Size = new System.Drawing.Size(222, 20);
            this.usrTxt.TabIndex = 1;
            // 
            // passTxt
            // 
            this.passTxt.Location = new System.Drawing.Point(323, 148);
            this.passTxt.Name = "passTxt";
            this.passTxt.PasswordChar = '*';
            this.passTxt.Size = new System.Drawing.Size(222, 20);
            this.passTxt.TabIndex = 2;
            // 
            // lbl_benutzerlogin
            // 
            this.lbl_benutzerlogin.AutoSize = true;
            this.lbl_benutzerlogin.Font = new System.Drawing.Font("MS Reference Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_benutzerlogin.Location = new System.Drawing.Point(317, 40);
            this.lbl_benutzerlogin.Name = "lbl_benutzerlogin";
            this.lbl_benutzerlogin.Size = new System.Drawing.Size(228, 35);
            this.lbl_benutzerlogin.TabIndex = 5;
            this.lbl_benutzerlogin.Text = "Benutzerlogin";
            // 
            // lbl_passwort_vergessen
            // 
            this.lbl_passwort_vergessen.AutoSize = true;
            this.lbl_passwort_vergessen.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_passwort_vergessen.Location = new System.Drawing.Point(320, 171);
            this.lbl_passwort_vergessen.Name = "lbl_passwort_vergessen";
            this.lbl_passwort_vergessen.Size = new System.Drawing.Size(108, 13);
            this.lbl_passwort_vergessen.TabIndex = 6;
            this.lbl_passwort_vergessen.Text = "Passwort vergessen?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(632, 417);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Lagerverwaltung+, 2017, ABsoft";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(803, 439);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_passwort_vergessen);
            this.Controls.Add(this.lbl_benutzerlogin);
            this.Controls.Add(this.passTxt);
            this.Controls.Add(this.usrTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_anmelden);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_anmelden;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usrTxt;
        private System.Windows.Forms.TextBox passTxt;
        private System.Windows.Forms.Label lbl_benutzerlogin;
        private System.Windows.Forms.Label lbl_passwort_vergessen;
        private System.Windows.Forms.Label label3;
    }
}

