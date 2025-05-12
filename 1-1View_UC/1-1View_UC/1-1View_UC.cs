using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Emit;

namespace _1_1View_UC
{
    public partial class UserControl1: UserControl
    {
        internal class Connexion
        {
            // Objet Connection
            private static SQLiteConnection connec;

            // Constructeur privé pour empêcher l'instanciation directe depuis l'extérieur.
            private Connexion() { }

            // Méthode publique pour obtenir l'instance unique de la classe.
            public static SQLiteConnection Connec
            {
                get
                {
                    // Si l'instance n'existe pas, on la crée.
                    if (connec == null)
                    {
                        try
                        {
                            // Chaîne de connexion à votre base de données
                            string chaine = @"Data Source = SDIS67.db";
                            connec = new SQLiteConnection(chaine);
                            connec.Open();
                        }
                        catch (SQLiteException err)
                        {
                            Console.WriteLine($"Erreur lors de l'ouverture de la connexion : {err.Message}");
                        }
                    }
                    //Dans tous les cas on renvoie la connexion
                    return connec;
                }
            }

            // Méthode pour fermer proprement la connexion
            public static void FermerConnexion()
            {
                if (connec != null)
                {
                    try
                    {
                        connec.Close();
                        connec.Dispose();
                        connec = null; // Libération pour permettre une nouvelle connexion propre
                    }
                    catch (Exception err)
                    {
                        Console.WriteLine($"Erreur lors de la fermeture de la connexion : {err.Message}");
                    }
                }
            }
        }


        private SQLiteConnection cx;
        private DataSet ds = new DataSet();
        private BindingSource bs;
        private BindingSource bs2;

        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

            ////////////:A enlever
            cx = Connexion.Connec; //On se connecte

            DataTable dt = cx.GetSchema("Tables"); //On crée un DataTable pour contenir les données de la table


            string requete;

            string[] tablesVoulues = { "Engin", "Caserne" }; // Les deux tables à charger

            foreach (string nomtable in tablesVoulues)
            {
                requete = "SELECT * FROM " + nomtable;

                SQLiteCommand cmd = new SQLiteCommand(requete, cx);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);

                da.Fill(ds, nomtable); // Remplit le DataSet avec la table
            }


            //Ajout de la relation //TODO : L'enlever, il va etre fait de base
            ds.Relations.Add("lien",
                    ds.Tables["Caserne"].Columns["id"],
                    ds.Tables["Engin"].Columns["idCaserne"]);
            ////////////////////////////
            ///

            //Ajout d'un BindingSource pour récuperer les casernes
            bs = new BindingSource { DataSource = ds.Tables["Caserne"] };
            cboCasernes.DisplayMember = "nom";
            cboCasernes.ValueMember = "id";
            cboCasernes.DataSource = bs;


            //Ajout d'un BindingSource pour récuperer les engins
            bs2 = new BindingSource { DataSource = bs };
            bs2.DataMember = "lien";
            //creer un string qui contient le numero de la caserne, puis le type d'engin, puis son code

            lblTypeEngin.Text = (bs2.Current as DataRowView)?["idCaserne"] + "-" +
                    (bs2.Current as DataRowView)?["codeTypeEngin"] + "-" +
                    (bs2.Current as DataRowView)?["numero"];

            dataGridView1.DataSource = bs2;
        }



        private void btnFirst_Click(object sender, EventArgs e)
        {
            bs2.MoveFirst();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (bs2.Position == 0)
            {
                bs2.MoveLast();
            } else
            {
                bs2.MovePrevious();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (bs2.Position == bs2.Count-1)
            {
                bs2.MoveFirst();
            }
            else
            {
                bs2.MoveNext();
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            bs2.MoveLast();
        }
    }
}
