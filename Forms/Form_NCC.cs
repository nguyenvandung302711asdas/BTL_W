using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BLL;
using DTO;

namespace DONGHO.Forms
{
    public partial class Form_NCC : Form
    {
        public Form_NCC()
        {
            InitializeComponent();
            LoadDataGridView();
        }

        int mancc = 0;
        public bool b = false;

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            SupplierDTO nccDTO = new SupplierDTO
            {
                SupplierID = mancc,
                ContactName = txtTen.Text,
                Email = txtEmail.Text,
                Address = txtDiaChi.Text,
                Phone = txtSDT.Text
            };

            if (SupplierBL.GetInstance.ThemNCCFull(nccDTO))
            {
               // MessageBox.Show("Loi");
                Alert("Thêm thành công...", Form_Notification.enmType.Success);
                ClearInputs();
                LoadDataGridView();
                b = true;
            }
            else
            {
                MessageBox.Show("lOI DU LIEU");
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            SupplierDTO nccDTO = new SupplierDTO
            {
                SupplierID = mancc,
                ContactName = txtTen.Text,
                Email = txtEmail.Text,
                Address = txtDiaChi.Text,
                Phone = txtSDT.Text
            };

            if (SupplierBL.GetInstance.CapNhatNCC(nccDTO))
            {
                Alert("Đã cập nhật thành công...", Form_Notification.enmType.Success);
                ClearInputs();
                LoadDataGridView();
                b = true;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (SupplierBL.GetInstance.XoaNCC(mancc.ToString()))
            {
                Alert("Đã ngừng hợp tác thành công...", Form_Notification.enmType.Success);
                ClearInputs();
                LoadDataGridView();
                b = true;
            }
        }

        private void dgvNCC_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvNCC.SelectedRows.Count == 1)
                {
                    ResetInputColors();
                    DataGridViewRow dr = dgvNCC.SelectedRows[0];
                    mancc = int.Parse(dr.Cells["SupplierID"].Value.ToString().Trim());
                    txtTen.Text = dr.Cells["ContactName"].Value.ToString().Trim();
                    txtDiaChi.Text = dr.Cells["Address"].Value.ToString().Trim();
                    txtSDT.Text = dr.Cells["Phone"].Value.ToString().Trim();
                    txtEmail.Text = dr.Cells["Email"].Value.ToString().Trim();
                }
            }
            catch (Exception)
            {
                Alert("Có lỗi khi chọn nhà cung cấp.", Form_Notification.enmType.Error);
            }
        }

        private void Form_NCC_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            DataTable dt = SupplierBL.GetInstance.GetDanhSachNhaCungCap();

            dgvNCC.Rows.Clear();
            dgvNCC.Columns.Clear();

            dgvNCC.Columns.Add("SupplierID", "Mã NCC");
            dgvNCC.Columns.Add("ContactName", "Tên NCC");
            dgvNCC.Columns.Add("Address", "Địa chỉ");
            dgvNCC.Columns.Add("Phone", "SĐT");
            dgvNCC.Columns.Add("Email", "Email");

            foreach (DataRow row in dt.Rows)
            {
                dgvNCC.Rows.Add(row["SupplierID"], row["ContactName"], row["Address"], row["Phone"], row["Email"]);
            }
        }

        private bool ValidateInputs()
        {
            ResetInputColors();
            bool isValid = true;
            StringBuilder errorMsg = new StringBuilder();

            if (string.IsNullOrWhiteSpace(txtTen.Text) || txtTen.Text.Length > 50)
            {
                txtTen.BackColor = Color.OrangeRed;
                errorMsg.AppendLine("Tên NCC không được để trống và tối đa 50 ký tự.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtDiaChi.Text) || txtDiaChi.Text.Length > 200)
            {
                txtDiaChi.BackColor = Color.OrangeRed;
                errorMsg.AppendLine("Địa chỉ không được để trống và tối đa 200 ký tự.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtSDT.Text) || txtSDT.Text.Length < 10 || txtSDT.Text.Length > 12)
            {
                txtSDT.BackColor = Color.OrangeRed;
                errorMsg.AppendLine("Số điện thoại phải từ 10 đến 12 ký tự.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                txtEmail.BackColor = Color.OrangeRed;
                errorMsg.AppendLine("Email không được để trống.");
                isValid = false;
            }

            if (!isValid)
            {
                Form_ThongBao frm = new Form_ThongBao();
                frm.lblThongBao.Text = errorMsg.ToString();
                frm.ShowDialog();
            }

            return isValid;
        }

        private void ClearInputs()
        {
            txtTen.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            txtEmail.Text = "";
        }

        private void ResetInputColors()
        {
            txtTen.BackColor = Color.White;
            txtDiaChi.BackColor = Color.White;
            txtSDT.BackColor = Color.White;
            txtEmail.BackColor = Color.White;
        }

        public void Alert(string msg, Form_Notification.enmType type)
        {
            Form_Notification frm = new Form_Notification();
            frm.TopMost = true;
            frm.showAlert(msg, type);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
