using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi6
{
    public partial class QLKhoa : Form
    {
        public QLKhoa()
        {
            InitializeComponent();
        }

        private void QLKhoa_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void dgvkhoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void QLKhoa_Load(object sender, EventArgs e)
        {
            try
            {
                var context = new Model1();
                var listKhoa = context.Faculties
                    .Select(f => new
                    {
                        f.FacultyID,
                        f.FacultyName,
                        f.TotalProfessor
                    }).ToList();

                dgvkhoa.DataSource = listKhoa;

                dgvkhoa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadData()
        {
            using (var context = new Model1())
            {
                var listKhoa = context.Faculties
                    .Select(f => new
                    {
                        f.FacultyID,
                        f.FacultyName,
                        f.TotalProfessor
                    }).ToList();

                dgvkhoa.DataSource = listKhoa;
            }
        }

        private void Them_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new Model1())
                {
                    var khoa = new Faculty
                    {
                        FacultyID = int.Parse(txtmakhoa.Text),
                        FacultyName = txttenkhoa.Text,
                        TotalProfessor = int.Parse(txtslgiaosu.Text),
                    };

                    context.Faculties.Add(khoa);
                    context.SaveChanges();

                    MessageBox.Show("Thêm khoa thành công!");
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

        private void sua_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvkhoa.CurrentRow != null)
                {
                    int facultyID = Convert.ToInt32(dgvkhoa.CurrentRow.Cells["FacultyID"].Value);

                    using (var context = new Model1())
                    {
                        var faculty = context.Faculties.FirstOrDefault(f => f.FacultyID == facultyID);

                        if (faculty != null)
                        {
                            // Lấy thông tin từ các ô nhập liệu
                            faculty.FacultyName = txttenkhoa.Text;
                            faculty.TotalProfessor = int.Parse(txtslgiaosu.Text);

                            context.SaveChanges();

                            MessageBox.Show("Cập nhật khoa thành công!");
                            LoadData(); // Tải lại dữ liệu lên DataGridView
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy khoa để sửa.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một khoa để sửa.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvkhoa.CurrentRow != null)
                {
                    int facultyID = Convert.ToInt32(dgvkhoa.CurrentRow.Cells["FacultyID"].Value);

                    var result = MessageBox.Show("Bạn có chắc chắn muốn xóa khoa này không?",
                                                 "Xác nhận xóa",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        using (var context = new Model1())
                        {
                            var faculty = context.Faculties.FirstOrDefault(f => f.FacultyID == facultyID);

                            if (faculty != null)
                            {
                                context.Faculties.Remove(faculty);
                                context.SaveChanges();

                                MessageBox.Show("Xóa khoa thành công!");
                                LoadData(); // Tải lại dữ liệu lên DataGridView
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy khoa để xóa.");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một khoa để xóa.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

        private void dgvkhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0) // Kiểm tra xem dòng được chọn có hợp lệ không (không phải tiêu đề)
                {
                    // Lấy dòng hiện tại mà người dùng click
                    DataGridViewRow row = dgvkhoa.Rows[e.RowIndex];

                    // Gán dữ liệu từ dòng được chọn vào các TextBox
                    txtmakhoa.Text = row.Cells["FacultyID"].Value.ToString();
                    txttenkhoa.Text = row.Cells["FacultyName"].Value.ToString();
                    txtslgiaosu.Text = row.Cells["TotalProfessor"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
