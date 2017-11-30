using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

using AesEncDec;
using System.IO;

namespace Login_System_Tut_ecnrypted
{
    public partial class regform : Form
    {
        public regform()
        {
            InitializeComponent();
        }
        bool recht;
        private void button2_Click(object sender, EventArgs e)
        {
            if (txt_username.Text.Length < 3 || txt_passwort.Text.Length < 5 || txt_passwort==txt_passwort_wh)
            {
                MessageBox.Show("Benutzername oder Passwort zu kurz!");
            }
            else
            {
                string dir = txt_username.Text;
                
               

                string encusr = AesCryp.Encrypt(txt_username.Text);
                string encpass = AesCryp.Encrypt(txt_passwort.Text);

                team06Entities en = new team06Entities();
                User usr = new User();       //usr als objekt der klasse User
                lager la = new lager();      //same

                usr.benutzername = encusr;
                usr.passwort = encpass;
                usr.recht = recht;

                en.User.Add(usr);
                en.SaveChanges();
                en.Dispose();
       
                MessageBox.Show("Benutzer '" + dir + "' wurde erstellt!", txt_username.Text);
                this.Close();
            }
        }

        private void RegForm_Load(object sender, EventArgs e)
        {

        }

        private void cb_administrator_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_administrator.Checked == true)
            {
                recht = true;
            }
            else
            {
            }
        }
    }
}
