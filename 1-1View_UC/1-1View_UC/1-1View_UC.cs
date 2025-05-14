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
using System.Drawing.Drawing2D;

namespace _1_1View_UC
{
    public partial class OneToOneViewUC: UserControl
    {

        private DataSet _ds;
        private BindingSource bs;
        private BindingSource bs2;

        public OneToOneViewUC()
        {
            InitializeComponent();
        }

        public OneToOneViewUC(DataSet ds) {
            InitializeComponent();
             _ds = ds;
        }


      


    private void OneToOneViewUC_Load(object sender, EventArgs e)
        {










            ////////////:A enlever
            SQLiteConnection cx = Connexion.Connec; //On se connecte
            DataTable dt = cx.GetSchema("Tables"); //On crée un DataTable pour contenir les données de la table

            string requete; _ds = new DataSet();

            foreach (DataRow row in dt.Rows)
            {
                string nomtable = row["TABLE_NAME"].ToString(); //On récupère le nom de la table
                requete = "SELECT * FROM " + nomtable;
                SQLiteCommand cmd = new SQLiteCommand(requete, cx);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);

                da.Fill(_ds, nomtable);
            }



            if (!DesignMode)
            {

                _ds.Relations.Add("lien",
                        _ds.Tables["Caserne"].Columns["id"],
                        _ds.Tables["Engin"].Columns["idCaserne"]);
                ////////////////////////////
                ///



                //Ajout d'un BindingSource pour récuperer les casernes
                bs = new BindingSource { DataSource = _ds.Tables["Caserne"] };
                cboCasernes.DisplayMember = "nom";
                cboCasernes.ValueMember = "id";
                cboCasernes.DataSource = bs;


            //Ajout d'un BindingSource pour récuperer les engins
            bs2 = new BindingSource { DataSource = bs };
            bs2.DataMember = "lien";
            //creer un string qui contient le numero de la caserne, puis le type d'engin, puis son code


            lblTypeEngin.DataBindings.Add("Text", bs2, "codeTypeEngin");

            dataGridView1.DataSource = bs2;

            }
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
