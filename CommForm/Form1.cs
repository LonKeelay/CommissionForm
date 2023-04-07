using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommForm
{
    public partial class frmSelector : Form
    {
        float[] priceList;
        private static float[] linePrices = { 13, 23, 30 };
        private static float[] colorPrices = { 17, 28, 38 };
        private static float[] shadePrices = { 21, 35, 50 };

        public frmSelector()
        {
            InitializeComponent();
        }
        private void frmSelector_Load(object sender, EventArgs e)
        {
            priceList = linePrices;
            txtHeadHalfFull.SelectedIndex = 0;
            txtLinColSh.SelectedIndex = 0;
            numBackground.Visible = false;
        }
        private void update()
        {
            float basePrice = priceList[txtHeadHalfFull.SelectedIndex];
            lblBasePrice.Text = "$" + basePrice.ToString();
            basePrice += (float)numHeads.Value * priceList[0] * (float)0.5;
            lblHeadMod.Text = "+$" + ((float)numHeads.Value * priceList[0] * (float)0.5).ToString();
            basePrice += (float)numHalfs.Value * priceList[1] * (float)0.5;
            lblHalfMod.Text = "+$" + ((float)numHalfs.Value * priceList[1] * (float)0.5).ToString();
            basePrice += (float)numFulls.Value * priceList[2] * (float)0.5;
            lblFullMod.Text = "+$" + ((float)numFulls.Value * priceList[2] * (float)0.5).ToString();
            if (chkNSFW.Checked)
            {
                lblNSFW.Text = "+$" + (basePrice * (float)0.2).ToString();
                basePrice *= (float)1.2;
            }
            else lblNSFW.Text = "+$0";

            if (chkBackground.Checked) basePrice += (float)numBackground.Value;

            lblFinPriceNum.Text = "$" + ((int)basePrice).ToString();
        }

        private void txtLinColSh_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (txtLinColSh.SelectedIndex)
            {
                case 0:
                    priceList = linePrices;
                    break;
                case 1:
                    priceList = colorPrices;
                    break;
                case 2:
                    priceList = shadePrices;
                    break;
            }

            update();
        }

        private void updateHandler(object sender, EventArgs e)
        {
            update();
        }

        private void chkBackground_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBackground.Checked)
            {
                numBackground.Visible = true;
            }
            else
            {
                numBackground.Visible = false;
            }
            update();
        }
    }
}
