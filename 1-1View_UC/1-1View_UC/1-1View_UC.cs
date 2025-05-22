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
            if (!DesignMode)
            {


                _ds.Relations.Add("lien",
                _ds.Tables["Caserne"].Columns["id"],
                _ds.Tables["Engin"].Columns["idCaserne"]);
           



                //Ajout d'un BindingSource pour récuperer les casernes
                bs = new BindingSource { DataSource = _ds.Tables["Caserne"] };
                cboCasernes.DisplayMember = "nom";
                cboCasernes.ValueMember = "id";
                cboCasernes.DataSource = bs;


                //Ajout d'un BindingSource pour récuperer les engins
                bs2 = new BindingSource { DataSource = bs };
                bs2.DataMember = "lien";


                bs2.PositionChanged += Bs2_PositionChanged;
                bs2.Position = 0;
                UpdateCasernesLabel();

                bs.CurrentChanged += Bs_CurrentChanged;




            }
        }

        private void Bs_CurrentChanged(object sender, EventArgs e)
        {
            UpdateCasernesLabel();
        }
        private void Bs2_PositionChanged(object sender, EventArgs e)
        {
            UpdateCasernesLabel();
        }

        private void UpdateCasernesLabel()
        {
            lblTypeEngin.Text = GetCaserneEnginInfo();
            lblDateRecep.Text = GetCaserneEnginDate(); 
            lblMission.Text = GetCaserneEnginMissionStatus();
            lblPanne.Text = GetCaserneEnginPanneStatus();
            pctPinpom.Image = GetCaserneEnginImage();

        }

        private Image GetCaserneEnginImage()
        {
            if (bs.Current is DataRowView caserneRow && bs2.Current is DataRowView enginRow)
            {
                string typeEngin = enginRow["codeTypeEngin"].ToString();
                object resource = Properties.Resources.ResourceManager.GetObject(typeEngin);

                if (resource is Image image)
                {
                    return image;
                }
                else
                {
                    // L'objet trouvé n'était pas une image
                    return null;
                }
            }

            return null;
        }
        private string GetCaserneEnginInfo()
        {
            if (bs.Current is DataRowView caserneRow && bs2.Current is DataRowView enginRow)
            {
                string caserneNum = caserneRow["id"].ToString();
                string typeEngin = enginRow["codeTypeEngin"].ToString();
                string code = enginRow["numero"].ToString();
                return $"{caserneNum}-{typeEngin}-{code}";
            }
            return string.Empty;
        }

        private string GetCaserneEnginDate()
        {
            if (bs.Current is DataRowView caserneRow && bs2.Current is DataRowView enginRow)
            {
                string date = enginRow["dateReception"].ToString();
                return date;
            }
            return string.Empty;
        }

        private string GetCaserneEnginMissionStatus()
        {
            if (bs.Current is DataRowView caserneRow && bs2.Current is DataRowView enginRow)
            {
                string status = "";
                if (enginRow["enMission"].ToString() == "0")
                {
                    status+="Disponible";
                }
                else if (enginRow["enMission"].ToString() == "1")
                {
                    status+="En mission";
                }
                return status;
            }
            return string.Empty;
        }

        private string GetCaserneEnginPanneStatus()
        {
            if (bs.Current is DataRowView caserneRow && bs2.Current is DataRowView enginRow)
            {
                string status = "";
                if (enginRow["enPanne"].ToString() == "0")
                {
                    status += "Fonctionnel :D";
                }
                else if (enginRow["enPanne"].ToString() == "1")
                {
                    status += "En panne :(";
                }
                return status;
            }
            return string.Empty;
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
