using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using Pinpon;

namespace SAE_A21_FAUCON_WAHL_CUILLER
{
    public partial class UserControl1 : UserControl
    {


        private SQLiteConnection cx;
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

            cx = Connexion.Connec; //On se connecte

        }
    }
}
