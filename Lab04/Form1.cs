using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab04.Model;

namespace Lab04
{
    public partial class Form1 : Form

    {
        Model1 dbsinhvien = new Model1();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            filldbSinhvien();
            fillDGVSinhVien();
        }

        private void filldbSinhvien()
        {
            // Lấy ds khoa
            List<KHOA> faculty = dbsinhvien.KHOAs.ToList();

            cbbKhoa.DataSource = faculty;

            cbbKhoa.DisplayMember = "FacultyName"; //Tên Hiển Thị
            cbbKhoa.ValueMember = "FacultyID"; //Giá Trị Xử Lý
        }

        private void fillDGVSinhVien()
        {
            List<SINH_VIEN> students = dbsinhvien.SINH_VIEN.ToList();

            foreach (SINH_VIEN student in students)
            {
                int newRow = dgvSinhVien.Rows.Add();

                dgvSinhVien.Rows[newRow].Cells[0].Value = student.Id;
                dgvSinhVien.Rows[newRow].Cells[1].Value = student.FullName;
                dgvSinhVien.Rows[newRow].Cells[2].Value = student.AverageScore;
                dgvSinhVien.Rows[newRow].Cells[3].Value = student.KHOA.FacultyName;
            }
        }

        private void dgvSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void quảnLíKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        // Biến để theo dõi dòng đang chỉnh sửa
        private int editingIndex = -1;

        private void btnThemSua_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các ô nhập liệu
            string id = txtMSSV.Text.Trim();
            string ten = txtHoten.Text.Trim();
            string dtb = txtDTB.Text.Trim();
            string khoa = cbbKhoa.Text.Trim();

            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrEmpty(id) ||
                string.IsNullOrEmpty(ten) ||
                string.IsNullOrEmpty(dtb) ||
                string.IsNullOrEmpty(khoa))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Nếu đang chỉnh sửa (editingIndex >= 0)
            if (editingIndex >= 0)
            {
                // Cập nhật dữ liệu vào dòng được chọn
                dgvSinhVien.Rows[editingIndex].Cells[0].Value = id;
                dgvSinhVien.Rows[editingIndex].Cells[1].Value = ten;
                dgvSinhVien.Rows[editingIndex].Cells[2].Value = dtb;
                dgvSinhVien.Rows[editingIndex].Cells[3].Value = khoa;

                MessageBox.Show("Cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                editingIndex = -1; // Reset trạng thái chỉnh sửa
            }
            else
            {
                // Kiểm tra trùng mã số sinh viên
                foreach (DataGridViewRow row in dgvSinhVien.Rows)
                {
                    if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == id)
                    {
                        MessageBox.Show("Mã số sinh viên đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // Thêm mới sinh viên vào DataGridView
                dgvSinhVien.Rows.Add(id, ten, dtb, khoa);
                MessageBox.Show("Thêm mới thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Xóa trắng các ô nhập liệu
            ClearInputFields();
        }

        // Hàm xóa trắng ô nhập liệu
        private void ClearInputFields()
        {
            txtMSSV.Clear();
            txtHoten.Clear();
            txtDTB.Clear();
            cbbKhoa.SelectedIndex = -1;
        }


        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();

            frm2.ShowDialog();
        }

        private void Thoát_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
