using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace WindowsFormsApp3
{
    public partial class FormOrderList : Form
    {
        public FormOrderList()
        {
            InitializeComponent();
        }

        private void FormOrderList_Load(object sender, EventArgs e)
        {
            lblBuyerInfo.Text = DlobalBar.Customer;

            foreach (ArrayList item in DlobalBar.listOrderItemCollection)
            {
                string itemname = (string)item[0];
                int price = (int)item[1];
                int qty = (int)item[2];
                int sumprice = (int)item[3];
                string suger = (string)item[4];
                string ice = (string)item[5];
                string bonus = (string)item[6];

                lbxOrdItem.Items.Add($"{itemname} {price}元 {qty}杯 單品總價{sumprice}元 {suger} {ice} {bonus}");
            }
        }

        private void btnDeleteSelect_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {

        }

        private void btnRcipe_Click(object sender, EventArgs e)
        {

        }

        private void btnExitItem_Click(object sender, EventArgs e)
        {

        }
    }
}
