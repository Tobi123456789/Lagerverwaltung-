using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_System_Tut_ecnrypted
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "lagerverwaltungDataSet.Lager". Sie können sie bei Bedarf verschieben oder entfernen.
            this.lagerTableAdapter.Fill(this.lagerverwaltungDataSet.Lager);
        }
    }
}
