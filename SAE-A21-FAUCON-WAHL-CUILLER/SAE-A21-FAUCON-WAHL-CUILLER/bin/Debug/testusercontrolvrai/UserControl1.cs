using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Reflection.Emit;

namespace testusercontrolvrai
{
    public partial class Plinker: UserControl
    {
        private int plinks=0;
        private int plinksperclick = 1;
        private int upgrade_price = 10;
        private int bought_upgrades = 1;
        public Plinker()
        {
            InitializeComponent();
            label1.Text = "Plinks : 0";
            button2.Text = $"X2 plinks : {upgrade_price}";
            button1.Click += Button1_Click;
            button2.Click += Button2_Click;

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void UserControl1_Click(object sender, EventArgs e)
        {
           
        }

        private void Button1_Click(object sender, EventArgs e)
        {
                plinks+=plinksperclick;
                UpdatePlinksCount();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (plinks >= upgrade_price)
            {
                plinksperclick*=2;
                bought_upgrades++;
                plinks-=upgrade_price;
                UpdatePlinksCount();
                upgrade_price =(int)(upgrade_price * (Math.Pow(2, bought_upgrades)));
                button2.Text = $"X2 plinks : {upgrade_price}";
            }
        }

        private void UpdatePlinksCount()
        {
            label1.Text = $"Plinks : {plinks}";
        }
    }
}
