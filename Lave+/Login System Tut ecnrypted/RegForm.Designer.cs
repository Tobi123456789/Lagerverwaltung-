namespace Login_System_Tut_ecnrypted
{
    partial class regform
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
            this.txt_passwort = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.lbl_passwort = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.bn_user_anlegen = new System.Windows.Forms.Button();
            this.txt_passwort_wh = new System.Windows.Forms.TextBox();
            this.lbl_passwort_wh = new System.Windows.Forms.Label();
            this.lbl_administrator = new System.Windows.Forms.Label();
            this.cb_administrator = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txt_passwort
            // 
            this.txt_passwort.Location = new System.Drawing.Point(264, 46);
            this.txt_passwort.Name = "txt_passwort";
            this.txt_passwort.Size = new System.Drawing.Size(115, 20);
            this.txt_passwort.TabIndex = 8;
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(264, 20);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(115, 20);
            this.txt_username.TabIndex = 9;
            // 
            // lbl_passwort
            // 
            this.lbl_passwort.AutoSize = true;
            this.lbl_passwort.Location = new System.Drawing.Point(203, 49);
            this.lbl_passwort.Name = "lbl_passwort";
            this.lbl_passwort.Size = new System.Drawing.Size(53, 13);
            this.lbl_passwort.TabIndex = 7;
            this.lbl_passwort.Text = "Passwort:";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(203, 23);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(55, 13);
            this.lbl_username.TabIndex = 6;
            this.lbl_username.Text = "Username";
            // 
            // bn_user_anlegen
            // 
            this.bn_user_anlegen.Location = new System.Drawing.Point(256, 144);
            this.bn_user_anlegen.Name = "bn_user_anlegen";
            this.bn_user_anlegen.Size = new System.Drawing.Size(75, 23);
            this.bn_user_anlegen.TabIndex = 4;
            this.bn_user_anlegen.Text = "Registrieren";
            this.bn_user_anlegen.UseVisualStyleBackColor = true;
            this.bn_user_anlegen.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_passwort_wh
            // 
            this.txt_passwort_wh.Location = new System.Drawing.Point(264, 72);
            this.txt_passwort_wh.Name = "txt_passwort_wh";
            this.txt_passwort_wh.Size = new System.Drawing.Size(115, 20);
            this.txt_passwort_wh.TabIndex = 10;
            // 
            // lbl_passwort_wh
            // 
            this.lbl_passwort_wh.AutoSize = true;
            this.lbl_passwort_wh.Location = new System.Drawing.Point(145, 72);
            this.lbl_passwort_wh.Name = "lbl_passwort_wh";
            this.lbl_passwort_wh.Size = new System.Drawing.Size(113, 13);
            this.lbl_passwort_wh.TabIndex = 11;
            this.lbl_passwort_wh.Text = "Passwort wiederholen:";
            // 
            // lbl_administrator
            // 
            this.lbl_administrator.AutoSize = true;
            this.lbl_administrator.Location = new System.Drawing.Point(261, 95);
            this.lbl_administrator.Name = "lbl_administrator";
            this.lbl_administrator.Size = new System.Drawing.Size(70, 13);
            this.lbl_administrator.TabIndex = 12;
            this.lbl_administrator.Text = "Administrator:";
            // 
            // cb_administrator
            // 
            this.cb_administrator.Location = new System.Drawing.Point(337, 95);
            this.cb_administrator.Name = "cb_administrator";
            this.cb_administrator.Size = new System.Drawing.Size(95, 16);
            this.cb_administrator.TabIndex = 0;
            this.cb_administrator.CheckedChanged += new System.EventHandler(this.cb_administrator_CheckedChanged);
            // 
            // regform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 236);
            this.Controls.Add(this.cb_administrator);
            this.Controls.Add(this.lbl_administrator);
            this.Controls.Add(this.lbl_passwort_wh);
            this.Controls.Add(this.txt_passwort_wh);
            this.Controls.Add(this.txt_passwort);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.lbl_passwort);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.bn_user_anlegen);
            this.Name = "regform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User anlegen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_passwort;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label lbl_passwort;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Button bn_user_anlegen;
        private System.Windows.Forms.TextBox txt_passwort_wh;
        private System.Windows.Forms.Label lbl_passwort_wh;
        private System.Windows.Forms.Label lbl_administrator;
        private System.Windows.Forms.CheckBox cb_administrator;
    }
}