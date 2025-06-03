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
using newMission;
using System.Security.Cryptography;

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
            //85, 180


        }
        private void ShowControl(UserControl newUC)
        {
            // Supprimer tous les UC sauf celui qu'on veut afficher
            newUC.Location = new Point(85, 180);
            foreach (Control c in this.Controls.OfType<UserControl>().ToList())
            {
                this.Controls.Remove(c);
                c.Dispose(); // Libère les ressources
            }

           
                this.Controls.Add(newUC);
                newUC.BringToFront();
        

        }

        private void button1_Click(object sender, EventArgs e)
        {

            OneToOneViewUC o = new OneToOneViewUC(MesDatas.DsGlobal);
            ShowControl(o);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            newMission.newMission o2 = new newMission.newMission(MesDatas.DsGlobal);

            ShowControl(o2);
        }
    }
}