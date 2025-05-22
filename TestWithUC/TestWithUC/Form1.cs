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
using _1_1View_UC;

namespace TestWithUC
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SQLiteConnection cx = Connexion.Connec; //On se connecte

            DataTable dt = cx.GetSchema("Tables"); //On crée un DataTable pour contenir les données de la table

            string requete;

            foreach (DataRow row in dt.Rows)
            {
                string nomtable = row["TABLE_NAME"].ToString(); //On récupère le nom de la table
                requete = "SELECT * FROM " + nomtable;
                SQLiteCommand cmd = new SQLiteCommand(requete, cx);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);

                da.Fill(MesDatas.DsGlobal, nomtable);
            }

            OneToOneViewUC o = new OneToOneViewUC(MesDatas.DsGlobal);
            o.Dock = DockStyle.Fill; //On remplit le UserControl
            this.Controls.Add(o); //On l'ajoute au Form
        }
    }
}