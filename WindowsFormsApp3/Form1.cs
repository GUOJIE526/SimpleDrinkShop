using System;
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
    public partial class Form1 : Form
    {
        List<string> listDrink = new List<string>();//key
        List<int> listPrice = new List<int>();//value
        List<string> listSuger = new List<string>();
        List<string> listIce = new List<string>();
        List<string> listBonus = new List<string>();//key
        List<int> listBonusPrice = new List<int>();//value
        int qty = 0;
        int price = 0;
        int sumprice = 0;
        string pdname = "";
        string suger = "";
        string ice = "";
        string bonus = "";
        bool isOutgo = false;
        bool isbuyBag = false;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listDrink.Add("麥香紅茶");
            listDrink.Add("茉莉綠茶");
            listDrink.Add("波霸奶茶");
            listDrink.Add("玫瑰花茶");
            listDrink.Add("現打西瓜汁");

            listPrice.Add(30);
            listPrice.Add(30);
            listPrice.Add(40);
            listPrice.Add(50);
            listPrice.Add(35);

            listSuger.Add("正常甜");
            listSuger.Add("半糖甜");
            listSuger.Add("微糖甜");
            listSuger.Add("無糖");

            listIce.Add("正常冰");
            listIce.Add("少冰");
            listIce.Add("微冰");
            listIce.Add("去冰");

            listBonus.Add("不加料");
            listBonus.Add("珍珠");
            listBonus.Add("波霸");
            listBonus.Add("芋圓");
            listBonus.Add("椰果");

            listBonusPrice.Add(0);
            listBonusPrice.Add(10);
            listBonusPrice.Add(5);
            listBonusPrice.Add(15);
            listBonusPrice.Add(5);

            for(int i = 0; i < listDrink.Count; i++)
            {
                string strItem = $"{listDrink[i]} {listPrice[i]}元";
                lboxDrink.Items.Add(strItem);
            }

            foreach (string item in listSuger)
            {
                cboxSuger.Items.Add(item);
            }

            foreach(string item in listIce)
            {
                cboxIce.Items.Add(item);
            }

            for (int i = 0; i < listBonus.Count; i++)
            {
                string strItem = $"{listBonus[i]} {listBonusPrice[i]}元";
                cboxBonus.Items.Add(strItem);
            }

            //表單預設值
            cboxSuger.SelectedIndex = 0;
            suger = listSuger[cboxSuger.SelectedIndex];
            cboxIce.SelectedIndex = 0;
            ice = listIce[cboxIce.SelectedIndex];
            cboxBonus.SelectedIndex = 0;
            bonus = listBonus[cboxBonus.SelectedIndex];

            lboxDrink.SelectedIndex = 0;
            pdname = listDrink[lboxDrink.SelectedIndex];
            qty = 1;
            txtQty.Text = qty.ToString();
            price = listPrice[lboxDrink.SelectedIndex] + listBonusPrice[cboxBonus.SelectedIndex];
            lblPrice.Text = $"{price}元";
            sumprice = price * qty;
            lblSum.Text = $"{sumprice}元";

            chkOutGo.Checked = false;
            isOutgo = chkOutGo.Checked;
            chkBag.Checked = false;
            isbuyBag = chkBag.Checked;
        }

        void CalculateSumPrice()
        {
            if (lboxDrink.SelectedIndex >= 0)
            {
                sumprice = price * qty;
                lblSum.Text = $"{sumprice}元";
            }
        }

        private void lboxDrink_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboxSuger_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboxIce_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboxBonus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chkOutGo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkBag_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnPay_Click(object sender, EventArgs e)
        {

        }
    }
}
