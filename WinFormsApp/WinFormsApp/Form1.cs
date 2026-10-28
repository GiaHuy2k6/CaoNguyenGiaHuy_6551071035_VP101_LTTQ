using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Globalization;
using Microsoft.EntityFrameworkCore;
using WinFormsApp.Models;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        private DULIEUContext db = null!;
        private bool isThem = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                db = new DULIEUContext();
                LoadCONGVIEC();
                ResetFormState();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi kết nối cơ sở dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void LoadCONGVIEC()
        {
            try
            {
                var dsCongViec = db.Congviecs.Select(cv => new
                {
                    cv.MaCongViec,
                    cv.TenCongViec,
                    cv.LuongThang
                }).ToList();
                dgvCongViec.DataSource = dsCongViec;
                if (dgvCongViec.Columns["MaCongViec"] is DataGridViewColumn colMaCongViec) colMaCongViec.HeaderText = "Mã công việc";
                if (dgvCongViec.Columns["TenCongViec"] is DataGridViewColumn colTenCongViec) colTenCongViec.HeaderText = "Tên công việc";
                if (dgvCongViec.Columns["LuongThang"] is DataGridViewColumn colLuongThang) colLuongThang.HeaderText = "Lương tháng";

                dgvCongViec.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvCongViec.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu công việc: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ResetFormState()
        {
            ClearInputs();

            txtMaCV.Enabled = false;
            txtTenCV.Enabled = false;
            txtLuongThang.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThoat.Text = "Thoát";

            dgvCongViec.Enabled = true;
        }
        private void SetEditingState(bool adding)
        {
            isThem = adding;

            txtMaCV.Enabled = adding;
            txtTenCV.Enabled = true;
            txtLuongThang.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThoat.Text = "Thoát";
            dgvCongViec.Enabled = false;
        }

        private void ClearInputs()
        {
            txtMaCV.Clear();
            txtTenCV.Clear();
            txtLuongThang.Clear();
        }
        private void dgvCongViec_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvCongViec.Rows.Count)
            {
                var row = dgvCongViec.Rows[e.RowIndex];
                txtMaCV.Text = row.Cells["MaCongViec"].Value?.ToString() ?? "";
                txtTenCV.Text = row.Cells["TenCongViec"].Value?.ToString() ?? "";
                txtLuongThang.Text = row.Cells["LuongThang"].Value?.ToString() ?? "";
                txtMaCV.Enabled = false;
                txtTenCV.Enabled = false;
                txtLuongThang.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnThem.Enabled = true;
                btnThoat.Enabled = false;
            }
        }
        private void dgvCongViec_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvCongViec_CellClick(sender, e);
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            ClearInputs();
            SetEditingState(adding: true);
            txtMaCV.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaCV.Text))
            {
                MessageBox.Show("Vui lòng chọn một công việc để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SetEditingState(adding: false);
            txtTenCV.Focus();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaCV.Text))
            {
                MessageBox.Show("Vui lòng chọn một công việc để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show($"Bạn có chắc muốn xóa công việc '{txtTenCV.Text}' (Mã: {txtMaCV.Text})?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    string maCV = txtMaCV.Text.Trim();
                    var cv = db.Congviecs.Find(maCV);
                    if (cv != null)
                    {
                        db.Congviecs.Remove(cv);
                        db.SaveChanges();
                        LoadCONGVIEC();
                        ResetFormState();
                        MessageBox.Show("Xóa công việc thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadCONGVIEC();
                        ResetFormState();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy công việc để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi xóa công việc: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            ResetFormState();
        }
    }
}
