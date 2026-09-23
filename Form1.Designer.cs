using System.Drawing;
using System.Windows.Forms;

namespace QuanLyResponsive
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtUsername, txtPassword;
        private CheckBox chkShowPassword;
        private Button btnLogin, btnExit;
        private Label lblUsername, lblPassword, lblTitle;
        private ErrorProvider errorProvider1;

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
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new Label();
            this.lblUsername = new Label();
            this.lblPassword = new Label();
            this.txtUsername = new TextBox();
            this.txtPassword = new TextBox();
            this.chkShowPassword = new CheckBox();
            this.btnLogin = new Button();
            this.btnExit = new Button();
            this.errorProvider1 = new ErrorProvider(this.components);

            this.SuspendLayout();

            this.lblTitle.Text = "ĐĂNG NHẬP HỆ THỐNG";
            this.lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.DarkBlue;
            this.lblTitle.Location = new Point(50, 15);
            this.lblTitle.AutoSize = true;

            this.lblUsername.Text = "Tên đăng nhập:";
            this.lblUsername.Location = new Point(20, 60);
            this.lblUsername.AutoSize = true;

            this.txtUsername.Location = new Point(120, 57);
            this.txtUsername.Size = new Size(180, 23);

            this.lblPassword.Text = "Mật khẩu:";
            this.lblPassword.Location = new Point(20, 100);
            this.lblPassword.AutoSize = true;

            this.txtPassword.Location = new Point(120, 97);
            this.txtPassword.Size = new Size(180, 23);
            this.txtPassword.UseSystemPasswordChar = true;

            this.chkShowPassword.Text = "Hiện mật khẩu";
            this.chkShowPassword.Location = new Point(120, 130);
            this.chkShowPassword.AutoSize = true;
            this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);

            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.btnLogin.Location = new Point(120, 165);
            this.btnLogin.Size = new Size(85, 30);
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            this.btnExit.Text = "Thoát";
            this.btnExit.Location = new Point(215, 165);
            this.btnExit.Size = new Size(85, 30);
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);

            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.chkShowPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnExit);

            this.AcceptButton = this.btnLogin;
            this.CancelButton = this.btnExit;

            this.ClientSize = new Size(330, 215);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Form Dang Nhap";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}