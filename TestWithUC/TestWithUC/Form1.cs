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
             

            OneToOneViewUC oneToOneViewUC = new OneToOneViewUC(MesDatas.DsGlobal);
            oneToOneViewUC.Dock = DockStyle.Fill; // Remplir le formulaire
            this.Controls.Add(oneToOneViewUC); // Ajouter le contrôle au formulaire
        }
    }
}