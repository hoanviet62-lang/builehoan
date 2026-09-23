using System.Drawing;
using System.Windows.Forms;

namespace QuanLyResponsive
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private ListBox lstMenu, lstSelected;
        private Button btnAdd, btnRemove;
        private Label lblMenu, lblSelected, lblTotal;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lstMenu = new ListBox();
            this.lstSelected = new ListBox();
            this.btnAdd = new Button();
            this.btnRemove = new Button();
            this.lblMenu = new Label();
            this.lblSelected = new Label();
            this.lblTotal = new Label();
            this.SuspendLayout();

            this.lblMenu.Text = "Thực đơn";
            this.lblMenu.Location = new Point(20, 15);
            this.lblMenu.AutoSize = true;

            this.lstMenu.Location = new Point(20, 40);
            this.lstMenu.Size = new Size(150, 160);

            this.btnAdd.Text = ">";
            this.btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.btnAdd.Location = new Point(185, 70);
            this.btnAdd.Size = new Size(50, 35);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            this.btnRemove.Text = "<";
            this.btnRemove.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.btnRemove.Location = new Point(185, 120);
            this.btnRemove.Size = new Size(50, 35);
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);

            this.lblSelected.Text = "Món đã chọn";
            this.lblSelected.Location = new Point(250, 15);
            this.lblSelected.AutoSize = true;

            this.lstSelected.Location = new Point(250, 40);
            this.lstSelected.Size = new Size(150, 160);

            this.lblTotal.Text = "Tổng tiền: 0 VNĐ";
            this.lblTotal.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.lblTotal.ForeColor = Color.Red;
            this.lblTotal.Location = new Point(20, 215);
            this.lblTotal.AutoSize = true;

            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.lstMenu);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblSelected);
            this.Controls.Add(this.lstSelected);
            this.Controls.Add(this.lblTotal);

            this.ClientSize = new Size(425, 255);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Quan Ly Thuc Don";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}