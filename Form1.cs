using System;
using System.Windows.Forms;

namespace QuanLyResponsive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstMenu.Items.Add("Hamburger - 50k");
            lstMenu.Items.Add("Pizza - 120k");
            lstMenu.Items.Add("Gá Rán - 35k");
            lstMenu.Items.Add("Pepsi - 15k");
            TinhTongTien();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lstMenu.SelectedItem != null)
            {
                lstSelected.Items.Add(lstMenu.SelectedItem);
                TinhTongTien();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstSelected.SelectedItem != null)
            {
                lstSelected.Items.Remove(lstSelected.SelectedItem);
                TinhTongTien();
            }
        }

        private void TinhTongTien()
        {
            int total = 0;
            foreach (var item in lstSelected.Items)
            {
                string str = item.ToString();
                int price = int.Parse(str.Substring(str.LastIndexOf('-') + 1).Replace("k", "").Trim());
                total += price * 1000;
            }
            lblTotal.Text = $"Tổng tiền: {total:N0} VNĐ";
        }
    }
}