using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pinpon;

namespace SAE_A21_FAUCON_WAHL_CUILLER
{ 

    public partial class Form1 : Form
    {
        private DataSet ds;
        private SQLiteConnection cx;
        private BindingSource bs;
        private BindingSource bs2;
        public Form1()
        {
            InitializeComponent();
            ds = new DataSet();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //aaaaaaaaaaaaaaaaaaaaa
            ///je m'appelle mahteo
            ///

            try
            {

                    
                cx=Connexion.Connec;


                DataTable dt = cx.GetSchema("Tables");

                string requete;
                foreach (DataRow ligne in dt.Rows)
                {
                    string nomtable = ligne[2].ToString();
                    requete = "select * from " + ligne[2].ToString();
                    SQLiteCommand cmd = new SQLiteCommand(requete, cx);
                    SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                    da.Fill(ds, ligne[2].ToString());
                }

                ds.Relations.Add("lien",
                    ds.Tables["Caserne"].Columns["id"],
                    ds.Tables["Engin"].Columns["idCaserne"]);


                bs = new BindingSource { DataSource = ds.Tables["Caserne"] };
                comboBox1.DisplayMember = "nom";
                comboBox1.ValueMember = "id";
                comboBox1.DataSource = bs;

                //bindingsource qui va lier la table engin et la table caserne

                bs2 = new BindingSource { DataSource = bs};
                bs2.DataMember = "lien";
                dataGridView1.DataSource = bs2;


                label1.DataBindings.Add("Text", bs2, "codeTypeEngin");

                bindingNavigator1.BindingSource=bs2;
                bindingNavigator1.Visible=false;





                /*
                 * 
                 *  ds.Relations.Add("ResasVoyages",
                    ds.Tables["tblVoyages"].Columns["CodeVoyage"],
                    ds.Tables["tblReservations"].Columns["CodeVoyage"]);


                bsVoyages = new BindingSource { DataSource = ds.Tables["tblVoyages"] };
                cboVoyages.DataSource = bsVoyages;
                cboVoyages.DisplayMember = "Destination";

                bsReservation = new BindingSource { DataSource = bsVoyages };
                bsReservation.DataMember = "ResasVoyages";
                dgvReservations.DataSource = bsReservation;

                //////////////////////////////////////////////////////


                BindingSource bsThema = new BindingSource { DataSource = ds.Tables["tblThematique"] };
                cboboxThema.DataSource = bsThema;
                cboboxThema.DisplayMember = "libThem";
                cboboxThema.ValueMember = "codeThem";

                BindingSource bsHebergement = new BindingSource { DataSource = ds.Tables["tblHebergement"] };
                cboboxHebergement.DataSource = bsHebergement;
                cboboxHebergement.DisplayMember = "NomCategorie";
                cboboxHebergement.ValueMember = "NumCategorie";
                */












            }
            catch (Exception erreur)
            {
                MessageBox.Show(erreur.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (bs2.Position < bs2.Count - 1) 
            {
                    bs2.MoveNext();
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bs2.Position < bs2.Count - 1)
            {
                bs2.MovePrevious();
            }



        }
    }
}

/* private SQLiteConnection cx;
        private DataSet ds;


        private BindingSource bsReservation;
        private BindingSource bsVoyages;
        public Form1()
        {
            InitializeComponent();
            ds = new DataSet();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {
                cx = new SQLiteConnection();
                string chcon = @"Data Source = Voyage2023.sqlite";
                cx.ConnectionString = chcon;
                cx.Open();

                    DataTable dt = cx.GetSchema("Tables");


                    string requete;
                    string liste = "";
                    foreach (DataRow ligne in dt.Rows)
                    {
                        string nomtable = ligne[2].ToString();
                        requete = "select * from " + ligne[2].ToString();
                        SQLiteCommand cmd = new SQLiteCommand(requete, cx);
                        SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                        da.Fill(ds, ligne[2].ToString());
                        liste = liste + nomtable + "\n";
                    }
                //MessageBox.Show(liste);

                //DataColumn VoyagePK = ds.Tables["tblVoyages"].Columns["CodeVoyage"];
                //ds.Tables["tblVoyages"].PrimaryKey = new DataColumn[] { VoyagePK };
                //for (int i = 0; i < 2; i++)
                //{
                //    DataRow ligne = ds.Tables["tblVoyages"].NewRow();
                //    ligne[0] = "THA";
                //    ligne[1] = "Thailande";
                //    ligne[2] = 15;
                //    ligne[3] = 2;
                //    ligne[4] = "Découverte du triangle d'or";
                //    ligne[5] = 1850;
                //    ligne[6] = false;
                //    ds.Tables["tblVoyages"].Rows.Add(ligne);
                //}

                //clé etrangere
                ForeignKeyConstraint FK = new ForeignKeyConstraint("VoyagesFK1",
                        ds.Tables["tblVoyages"].Columns["CodeVoyage"],
                        ds.Tables["tblReservations"].Columns["CodeVoyage"]);
                ds.Tables["tblReservations"].Constraints.Add(FK);



                //////////////////////////////////////////////////////
                //EXO 2

                //relation entre les tables
                ds.Relations.Add("ResasVoyages",
                    ds.Tables["tblVoyages"].Columns["CodeVoyage"],
                    ds.Tables["tblReservations"].Columns["CodeVoyage"]);

                //bs
                bsVoyages = new BindingSource { DataSource = ds.Tables["tblVoyages"] };
                cboVoyages.DataSource = bsVoyages;
                cboVoyages.DisplayMember = "Destination";

                bsReservation = new BindingSource { DataSource = bsVoyages };
                bsReservation.DataMember = "ResasVoyages";
                dgvReservations.DataSource = bsReservation;

                //////////////////////////////////////////////////////


                BindingSource bsThema = new BindingSource { DataSource = ds.Tables["tblThematique"] };
                cboboxThema.DataSource = bsThema;
                cboboxThema.DisplayMember = "libThem";
                cboboxThema.ValueMember = "codeThem";

                BindingSource bsHebergement = new BindingSource { DataSource = ds.Tables["tblHebergement"] };
                cboboxHebergement.DataSource = bsHebergement;
                cboboxHebergement.DisplayMember = "NomCategorie";
                cboboxHebergement.ValueMember = "NumCategorie";













            }
            catch (Exception erreur)
            {
                MessageBox.Show(erreur.Message);
            }
        }
*/