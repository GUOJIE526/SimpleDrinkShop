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
            //EXE: 買一送一(同品項) 第二件半價(低價者) 兩件75折(同品項) 買二送一(同品項)
            cboxOnSale.Items.Add("無折扣");
            cboxOnSale.Items.Add("買一送一");
            cboxOnSale.Items.Add("第二件半價");
            cboxOnSale.Items.Add("兩件75折");
            cboxOnSale.Items.Add("買二送一");
            cboxOnSale.SelectedIndex = 0;

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
            CalculateOrderSum();
        }

        void CalculateOrderSum()
        {
            int sum = 0;
            foreach (ArrayList item in DlobalBar.listOrderItemCollection)
            {
                int sumitem = (int)item[3];
                sum += sumitem;
            }
            if((DlobalBar.isBag) && (DlobalBar.listOrderItemCollection.Count) > 0)
            {
                sum += 2;
                lblBag.Visible = true;
            }
            else
            {
                lblBag.Visible = false;
            }
            if ((DlobalBar.isOutgo) && (DlobalBar.listOrderItemCollection.Count > 0))
            {
                lblOutgo.Visible = true;
            }
            else
            {
                lblOutgo.Visible = false;
            }


            lblSumPrice.Text = $"訂單總價: {sum}";
        }

        private void btnDeleteSelect_Click(object sender, EventArgs e)
        {
            if(lbxOrdItem.SelectedIndex >= 0)
            {
                int selectindex = lbxOrdItem.SelectedIndex;
                lbxOrdItem.Items.RemoveAt(selectindex);
                DlobalBar.listOrderItemCollection.RemoveAt(selectindex);
                CalculateOrderSum();
            }
            else
            {
                MessageBox.Show("請選擇品項", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            lbxOrdItem.Items.Clear();
            DlobalBar.listOrderItemCollection.Clear();
            CalculateOrderSum();
            lblBag.Visible = false;
            lblOutgo.Visible= false;
        }

        private void btnRcipe_Click(object sender, EventArgs e)
        {
            string strOutputFile = @"D:\資策會課程\GuoJiesDev\DotNwt\WindowsFormsApp3";
            Random rand = new Random();
            int numRnd = rand.Next(1000, 10000);
            string strFileName = DateTime.Now.ToString("yyMMddHHmmss") + numRnd + "訂購檔.txt";
            string str完整路徑檔名 = strOutputFile + @"\" + strFileName;
            //Console.WriteLine(str完整路徑檔名);

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = strOutputFile;
            sfd.FileName = strFileName;
            sfd.Filter = "文字檔 Text File|*.txt|資料檔 Data|*.pdf";// | 左邊是描述 右邊是要求
            DialogResult R = sfd.ShowDialog();

            if (R == DialogResult.OK)
            {
                //確認
                str完整路徑檔名 = sfd.FileName;
            }
            else
            {
                //取消
                return;
            }
            //訂單內容輸出
            List<string> listOrderOutput = new List<string>();
            listOrderOutput.Add("*********** 冷飲訂購單 **********");
            listOrderOutput.Add("--------------------------------");
            listOrderOutput.Add($"訂購時間: {DateTime.Now}");
            listOrderOutput.Add($"訂購人: {DlobalBar.Customer}");
            listOrderOutput.Add("========== <<訂購品項>> =========");
            foreach (ArrayList item in DlobalBar.listOrderItemCollection)
            {
                string itemname = (string)item[0];
                int price = (int)item[1];
                int qty = (int)item[2];
                int sumprice = (int)item[3];
                string suger = (string)item[4];
                string ice = (string)item[5];
                string bonus = (string)item[6];

                listOrderOutput.Add($"{itemname} {price}元 {qty}杯 單品總價{sumprice}元 {suger} {ice} {bonus}");
            }
            listOrderOutput.Add("========== <<訂購品項>> =========");
            if (DlobalBar.isOutgo)
            {
                listOrderOutput.Add($"{lblOutgo.Text}");
            }
            if(DlobalBar.isBag)
            {
                listOrderOutput.Add($"{lblBag.Text}");
            }
            listOrderOutput.Add("--------------------------------");
            listOrderOutput.Add($"{lblSumPrice.Text}");
            listOrderOutput.Add("================================");
            listOrderOutput.Add("*********** 謝謝光臨 ************");

            System.IO.File.WriteAllLines(str完整路徑檔名, listOrderOutput, Encoding.UTF8);
            MessageBox.Show("訂單儲存成功!!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExitItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
