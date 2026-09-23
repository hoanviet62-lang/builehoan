using System.Drawing;
using System.Windows.Forms;

namespace QuanLyResponsive
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtDisplay;
        private Button btn0, btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9;
        private Button btnAdd, btnSub, btnMul, btnDiv, btnEquals, btnClear;

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
            this.txtDisplay = new TextBox();
            this.btn0 = new Button(); this.btn1 = new Button(); this.btn2 = new Button();
            this.btn3 = new Button(); this.btn4 = new Button(); this.btn5 = new Button();
            this.btn6 = new Button(); this.btn7 = new Button(); this.btn8 = new Button();
            this.btn9 = new Button();
            this.btnAdd = new Button(); this.btnSub = new Button();
            this.btnMul = new Button(); this.btnDiv = new Button();
            this.btnEquals = new Button(); this.btnClear = new Button();

            this.SuspendLayout();

            this.txtDisplay.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            this.txtDisplay.Location = new Point(20, 20);
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.Size = new Size(260, 39);
            this.txtDisplay.Text = "0";
            this.txtDisplay.TextAlign = HorizontalAlignment.Right;

            Button[] numBtns = { btn0, btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };
            for (int i = 0; i < 10; i++)
            {
                numBtns[i] = new Button();
                numBtns[i].Text = i.ToString();
                numBtns[i].Font = new Font("Segoe UI", 12F, FontStyle.Bold);
                numBtns[i].Size = new Size(55, 45);
                numBtns[i].Click += new System.EventHandler(this.NumberButton_Click);
            }

            numBtns[7].Location = new Point(20, 75);  numBtns[8].Location = new Point(85, 75);  numBtns[9].Location = new Point(150, 75);
            numBtns[4].Location = new Point(20, 130); numBtns[5].Location = new Point(85, 130); numBtns[6].Location = new Point(150, 130);
            numBtns[1].Location = new Point(20, 185); numBtns[2].Location = new Point(85, 185); numBtns[3].Location = new Point(150, 185);
            numBtns[0].Location = new Point(85, 240);

            Button[] opBtns = { btnDiv, btnMul, btnSub, btnAdd };
            string[] opTexts = { "/", "*", "-", "+" };
            for (int i = 0; i < 4; i++)
            {
                opBtns[i] = new Button();
                opBtns[i].Text = opTexts[i];
                opBtns[i].Font = new Font("Segoe UI", 12F, FontStyle.Bold);
                opBtns[i].Size = new Size(55, 45);
                opBtns[i].Location = new Point(215, 75 + i * 55);
                opBtns[i].Click += new System.EventHandler(this.OperatorButton_Click);
                this.Controls.Add(opBtns[i]);
            }

            this.btnClear.Text = "C";
            this.btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.btnClear.Size = new Size(55, 45);
            this.btnClear.Location = new Point(20, 240);
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            this.btnEquals.Text = "=";
            this.btnEquals.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.btnEquals.Size = new Size(55, 45);
            this.btnEquals.Location = new Point(150, 240);
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);

            foreach (var b in numBtns) this.Controls.Add(b);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.txtDisplay);

            this.ClientSize = new Size(295, 305);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "May Tinh";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}