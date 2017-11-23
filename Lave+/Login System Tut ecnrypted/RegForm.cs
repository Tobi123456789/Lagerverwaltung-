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

        private void button2_Click(object sender, EventArgs e)
        {
            if (txt_username.Text.Length < 3 || txt_passwort.Text.Length < 5 || txt_passwort==txt_passwort_wh)
            {
                MessageBox.Show("Benutzername oder Passwort zu kurz!");
            }
            else
            {
                string dir = txt_username.Text;
                int recht=0;
                Directory.CreateDirectory("data\\" + dir);
                if (cb_administrator.Checked==true)
                    {
                    recht = 1;
                    }
                else
                {
                }

                Entity en = new Entity();
                User usr = new User();
                lager la = new lager();
                la.Lagerbestand = 2;

                en.lager.SaveChanges();
                en.lager.dispose();

                string encusr = AesCryp.Encrypt(txt_username.Text);
                string encpass = AesCryp.Encrypt(txt_passwort.Text);
                
                /*SqlConnection con = new SqlConnection("user id=team06;password=T3amO6;server=eduweb.kb.local;database=team06;");
                SqlCommand com1 = new SqlCommand("INSERT INTO User(benutzername, passwort, recht) " +
                                     "Values ('enrusr', 'encpass', 'recht')", con);
                try
                {
                    con.Open();
                    com1.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(""+ex);
                }              
                MessageBox.Show("Benutzer '" + dir + "' wurde erstellt!", txt_username.Text);
                this.Close();*/
            }
        }

        private void RegForm_Load(object sender, EventArgs e)
        {

        }
    }
}
