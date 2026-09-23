using System;
using System.Collections.Generic;
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
            dtpBirthDate.Format = DateTimePickerFormat.Custom;
            dtpBirthDate.CustomFormat = "dd/MM/yyyy";

            // Nạp danh sách Khóa học với DisplayMember và ValueMember
            var courses = new List<Course>
            {
                new Course { Id = "C01", Name = "Lập trình C# WinForms" },
                new Course { Id = "C02", Name = "Thiết kế Web Responsive" },
                new Course { Id = "C03", Name = "Cơ sở dữ liệu SQL Server" }
            };

            cboCourse.DataSource = courses;
            cboCourse.DisplayMember = "Name";
            cboCourse.ValueMember = "Id";
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string phone = mtxtPhone.Text;
            string birthDate = dtpBirthDate.Value.ToString("dd/MM/yyyy");
            string course = cboCourse.Text;
            string gender = rdoMale.Checked ? "Nam" : (rdoFemale.Checked ? "Nữ" : "Chưa chọn");
            
            string genderDetail = rdoMale.Checked ? "Nam" : "Nữ";
            string confirm = chkConfirm.Checked ? "Đã đồng ý điều khoản" : "Chưa đồng ý điều khoản";

            string info = $"SĐT: {phone}\n" +
                          $"Ngày sinh: {birthDate}\n" +
                          $"Giới tính: {genderDetail}\n" +
                          $"Khóa học: {course} (Mã: {cboCourse.SelectedValue})\n" +
                          $"Trạng thái: {confirm}";

            MessageBox.Show(info, "Thông Tin Đăng Ký", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    public class Course
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
}