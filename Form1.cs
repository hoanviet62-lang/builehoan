using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyResponsive
{
    public partial class Form1 : Form
    {
        private TextBox txtMa;
        private TextBox txtTen;
        private TextBox txtEmail;
        private TextBox txtSDT;

        private DataGridView dgv;

        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThoat;

        private Panel buttonPanel;

        public Form1()
        {
            InitializeComponent();
            TaoGiaoDien();
        }

        private void TaoGiaoDien()
        {
            Text = "Quản lý thông tin";
            StartPosition = FormStartPosition.CenterScreen;
            MinimumSize = new Size(800, 500);

            // =========================
            // TABLELAYOUTPANEL CHÍNH
            // =========================

            TableLayoutPanel main = new TableLayoutPanel();

            main.Dock = DockStyle.Fill;
            main.ColumnCount = 2;
            main.RowCount = 1;

            main.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 30F));

            main.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 70F));

            // =========================
            // CỘT TRÁI - GROUPBOX
            // =========================

            GroupBox groupThongTin = new GroupBox();

            groupThongTin.Text = "Thông tin";
            groupThongTin.Dock = DockStyle.Fill;
            groupThongTin.Padding = new Padding(10);

            TableLayoutPanel inputPanel = new TableLayoutPanel();

            inputPanel.Dock = DockStyle.Fill;
            inputPanel.ColumnCount = 1;
            inputPanel.RowCount = 8;

            for (int i = 0; i < 8; i++)
            {
                inputPanel.RowStyles.Add(
                    new RowStyle(SizeType.Percent, 12.5F));
            }

            Label lblMa = new Label();
            lblMa.Text = "Mã:";
            lblMa.Dock = DockStyle.Fill;
            lblMa.TextAlign = ContentAlignment.MiddleLeft;

            txtMa = new TextBox();
            txtMa.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Left |
                AnchorStyles.Right;

            Label lblTen = new Label();
            lblTen.Text = "Tên:";
            lblTen.Dock = DockStyle.Fill;
            lblTen.TextAlign = ContentAlignment.MiddleLeft;

            txtTen = new TextBox();
            txtTen.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Left |
                AnchorStyles.Right;

            Label lblEmail = new Label();
            lblEmail.Text = "Email:";
            lblEmail.Dock = DockStyle.Fill;
            lblEmail.TextAlign = ContentAlignment.MiddleLeft;

            txtEmail = new TextBox();
            txtEmail.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Left |
                AnchorStyles.Right;

            Label lblSDT = new Label();
            lblSDT.Text = "SĐT:";
            lblSDT.Dock = DockStyle.Fill;
            lblSDT.TextAlign = ContentAlignment.MiddleLeft;

            txtSDT = new TextBox();
            txtSDT.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Left |
                AnchorStyles.Right;

            inputPanel.Controls.Add(lblMa, 0, 0);
            inputPanel.Controls.Add(txtMa, 0, 1);

            inputPanel.Controls.Add(lblTen, 0, 2);
            inputPanel.Controls.Add(txtTen, 0, 3);

            inputPanel.Controls.Add(lblEmail, 0, 4);
            inputPanel.Controls.Add(txtEmail, 0, 5);

            inputPanel.Controls.Add(lblSDT, 0, 6);
            inputPanel.Controls.Add(txtSDT, 0, 7);

            groupThongTin.Controls.Add(inputPanel);

            // =========================
            // CỘT PHẢI - PANEL
            // =========================

            Panel rightPanel = new Panel();

            rightPanel.Dock = DockStyle.Fill;

            // =========================
            // DATAGRIDVIEW
            // =========================

            dgv = new DataGridView();

            dgv.Dock = DockStyle.Fill;

            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.ReadOnly = true;

            dgv.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgv.MultiSelect = false;

            dgv.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgv.RowHeadersVisible = false;

            dgv.Columns.Add("Ma", "Mã");
            dgv.Columns.Add("Ten", "Tên");
            dgv.Columns.Add("Email", "Email");
            dgv.Columns.Add("SDT", "SĐT");

            // =========================
            // PANEL CHỨA BUTTON
            // =========================

            buttonPanel = new Panel();

            buttonPanel.Dock = DockStyle.Bottom;
            buttonPanel.Height = 55;

            // =========================
            // BUTTON THÊM
            // =========================

            btnThem = new Button();

            btnThem.Text = "Thêm";
            btnThem.Size = new Size(80, 35);

            btnThem.Anchor =
                AnchorStyles.Bottom |
                AnchorStyles.Right;

            // =========================
            // BUTTON SỬA
            // =========================

            btnSua = new Button();

            btnSua.Text = "Sửa";
            btnSua.Size = new Size(80, 35);

            btnSua.Anchor =
                AnchorStyles.Bottom |
                AnchorStyles.Right;

            // =========================
            // BUTTON XÓA
            // =========================

            btnXoa = new Button();

            btnXoa.Text = "Xóa";
            btnXoa.Size = new Size(80, 35);

            btnXoa.Anchor =
                AnchorStyles.Bottom |
                AnchorStyles.Right;

            // =========================
            // BUTTON THOÁT
            // =========================

            btnThoat = new Button();

            btnThoat.Text = "Thoát";
            btnThoat.Size = new Size(80, 35);

            btnThoat.Anchor =
                AnchorStyles.Bottom |
                AnchorStyles.Right;

            buttonPanel.Controls.Add(btnThem);
            buttonPanel.Controls.Add(btnSua);
            buttonPanel.Controls.Add(btnXoa);
            buttonPanel.Controls.Add(btnThoat);

            // Đặt vị trí button
            buttonPanel.Resize += ButtonPanel_Resize;

            // =========================
            // THÊM CONTROL VÀO PANEL
            // =========================

            rightPanel.Controls.Add(dgv);
            rightPanel.Controls.Add(buttonPanel);

            // =========================
            // THÊM VÀO MAIN
            // =========================

            main.Controls.Add(groupThongTin, 0, 0);
            main.Controls.Add(rightPanel, 1, 0);

            Controls.Clear();
            Controls.Add(main);

            // =========================
            // SỰ KIỆN
            // =========================

            btnThem.Click += BtnThem_Click;
            btnSua.Click += BtnSua_Click;
            btnXoa.Click += BtnXoa_Click;
            btnThoat.Click += BtnThoat_Click;

            dgv.CellClick += Dgv_CellClick;

            ButtonPanel_Resize(null, EventArgs.Empty);
        }

        // =========================
        // VỊ TRÍ BUTTON
        // =========================

        private void ButtonPanel_Resize(object sender, EventArgs e)
        {
            if (buttonPanel == null)
                return;

            int khoangCach = 5;

            int y =
                buttonPanel.ClientSize.Height
                - btnThem.Height
                - 10;

            btnThoat.Location = new Point(
                buttonPanel.ClientSize.Width
                - btnThoat.Width
                - 10,
                y);

            btnXoa.Location = new Point(
                btnThoat.Left
                - btnXoa.Width
                - khoangCach,
                y);

            btnSua.Location = new Point(
                btnXoa.Left
                - btnSua.Width
                - khoangCach,
                y);

            btnThem.Location = new Point(
                btnSua.Left
                - btnThem.Width
                - khoangCach,
                y);
        }

        // =========================
        // NÚT THÊM
        // =========================

        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMa.Text) ||
                string.IsNullOrWhiteSpace(txtTen.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập Mã và Tên.");

                return;
            }

            dgv.Rows.Add(
                txtMa.Text,
                txtTen.Text,
                txtEmail.Text,
                txtSDT.Text);

            XoaTrang();

            MessageBox.Show("Thêm thành công.");
        }

        // =========================
        // NÚT SỬA
        // =========================

        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow == null)
            {
                MessageBox.Show(
                    "Vui lòng chọn dòng cần sửa.");

                return;
            }

            dgv.CurrentRow.Cells["Ma"].Value =
                txtMa.Text;

            dgv.CurrentRow.Cells["Ten"].Value =
                txtTen.Text;

            dgv.CurrentRow.Cells["Email"].Value =
                txtEmail.Text;

            dgv.CurrentRow.Cells["SDT"].Value =
                txtSDT.Text;

            MessageBox.Show("Sửa thành công.");

            XoaTrang();
        }

        // =========================
        // NÚT XÓA
        // =========================

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow == null)
            {
                MessageBox.Show(
                    "Vui lòng chọn dòng cần xóa.");

                return;
            }

            DialogResult result =
                MessageBox.Show(
                    "Bạn có chắc muốn xóa?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                dgv.Rows.Remove(
                    dgv.CurrentRow);

                XoaTrang();

                MessageBox.Show("Xóa thành công.");
            }
        }

        // =========================
        // NÚT THOÁT
        // =========================

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        // =========================
        // CLICK VÀO BẢNG
        // =========================

        private void Dgv_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row =
                dgv.Rows[e.RowIndex];

            txtMa.Text =
                row.Cells["Ma"].Value?.ToString();

            txtTen.Text =
                row.Cells["Ten"].Value?.ToString();

            txtEmail.Text =
                row.Cells["Email"].Value?.ToString();

            txtSDT.Text =
                row.Cells["SDT"].Value?.ToString();
        }

        // =========================
        // XÓA TRẮNG
        // =========================

        private void XoaTrang()
        {
            txtMa.Clear();
            txtTen.Clear();
            txtEmail.Clear();
            txtSDT.Clear();

            txtMa.Focus();
        }
    }
}