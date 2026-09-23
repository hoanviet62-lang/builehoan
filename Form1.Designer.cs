using System.Drawing;
using System.Windows.Forms;

namespace QuanLyResponsive
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private MaskedTextBox mtxtPhone;
        private DateTimePicker dtpBirthDate;
        private ComboBox cboCourse;
        private RadioButton rdoMale, rdoFemale;
        private CheckBox chkConfirm;
        private Button btnRegister;
        private Label lblPhone, lblBirth, lblGender, lblCourse;

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
            this.lblPhone = new Label();
            this.lblBirth = new Label();
            this.lblGender = new Label();
            this.lblCourse = new Label();
            this.mtxtPhone = new MaskedTextBox();
            this.dtpBirthDate = new DateTimePicker();
            this.cboCourse = new ComboBox();
            this.rdoMale = new RadioButton();
            this.rdoFemale = new RadioButton();
            this.chkConfirm = new CheckBox();
            this.btnRegister = new Button();
            this.SuspendLayout();

            // SĐT Mask
            this.lblPhone.Text = "Số điện thoại:";
            this.lblPhone.Location = new Point(20, 20);
            this.lblPhone.AutoSize = true;

            this.mtxtPhone.Mask = "(000) 000-0000";
            this.mtxtPhone.Location = new Point(120, 17);
            this.mtxtPhone.Size = new Size(200, 23);

            // Ngày sinh
            this.lblBirth.Text = "Ngày sinh:";
            this.lblBirth.Location = new Point(20, 60);
            this.lblBirth.AutoSize = true;

            this.dtpBirthDate.Location = new Point(120, 57);
            this.dtpBirthDate.Size = new Size(200, 23);

            // Giới tính
            this.lblGender.Text = "Giới tính:";
            this.lblGender.Location = new Point(20, 100);
            this.lblGender.AutoSize = true;

            this.rdoMale.Text = "Nam";
            this.rdoMale.Location = new Point(120, 98);
            this.rdoMale.Size = new Size(60, 20);
            this.rdoMale.Checked = true;

            this.rdoFemale.Text = "Nữ";
            this.rdoFemale.Location = new Point(190, 98);
            this.rdoFemale.Size = new Size(60, 20);

            // Khóa học
            this.lblCourse.Text = "Khóa học:";
            this.lblCourse.Location = new Point(20, 140);
            this.lblCourse.AutoSize = true;

            this.cboCourse.Location = new Point(120, 137);
            this.cboCourse.Size = new Size(200, 23);
            this.cboCourse.DropDownStyle = ComboBoxStyle.DropDownList;

            // Cam kết
            this.chkConfirm.Text = "Đồng ý với các điều khoản đăng ký";
            this.chkConfirm.Location = new Point(120, 175);
            this.chkConfirm.AutoSize = true;

            // Nút Đăng ký
            this.btnRegister.Text = "Đăng ký";
            this.btnRegister.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnRegister.Location = new Point(120, 215);
            this.btnRegister.Size = new Size(100, 35);
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);

            // Controls
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.mtxtPhone);
            this.Controls.Add(this.lblBirth);
            this.Controls.Add(this.dtpBirthDate);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.rdoMale);
            this.Controls.Add(this.rdoFemale);
            this.Controls.Add(this.lblCourse);
            this.Controls.Add(this.cboCourse);
            this.Controls.Add(this.chkConfirm);
            this.Controls.Add(this.btnRegister);

            this.ClientSize = new Size(350, 270);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Form Dang Ky";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}