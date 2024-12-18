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
    public partial class TimKiemSV : Form
    {
        public TimKiemSV()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtdemsl_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void find_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new Model1())
                {
                    var query = context.Students.AsQueryable();

                    if (!string.IsNullOrWhiteSpace(txtmasv.Text))
                    {
                        if (int.TryParse(txtmasv.Text, out int studentID))
                        {
                            query = query.Where(s => s.StudentID == studentID);
                        }
                        else
                        {
                            MessageBox.Show("Mã sinh viên không hợp lệ.");
                            return;
                        }
                    }

                    if (!string.IsNullOrWhiteSpace(txttensv.Text))
                    {
                        query = query.Where(s => s.FullName.Contains(txttensv.Text));
                    }

                    if (cbkhoa.SelectedValue != null && (int)cbkhoa.SelectedValue != -1) 
                    {
                        int facultyID = (int)cbkhoa.SelectedValue;
                        query = query.Where(s => s.FacultyID == facultyID);
                    }

                    var result = query.Select(s => new
                    {
                        s.StudentID,
                        s.FullName,
                        s.Faculty.FacultyName
                    }).ToList();

                    dataGridView1.DataSource = result;

                    txtdemsl.Text = result.Count.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

        private void refesh_Click(object sender, EventArgs e)
        {
            txtmasv.Clear();
            txttensv.Clear();

            cbkhoa.SelectedIndex = 0; 

            LoadData();
        }

        private void TimKiemSV_Load(object sender, EventArgs e)
        {
            try
            {
                using (var context = new Model1())
                {
                    var listKhoa = context.Faculties
                        .Select(f => new
                        {
                            f.FacultyID,
                            f.FacultyName
                        }).ToList();

                    listKhoa.Insert(0, new { FacultyID = -1, FacultyName = "" }); 

                    cbkhoa.DataSource = listKhoa;
                    cbkhoa.DisplayMember = "FacultyName";
                    cbkhoa.ValueMember = "FacultyID";

                    cbkhoa.SelectedIndex = 0;

                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }
        private void LoadData()
        {
            try
            {
                using (var context = new Model1())
                {
                    var listSV = context.Students
                        .Select(s => new
                        {
                            s.StudentID,
                            s.FullName,
                            s.Faculty.FacultyName
                        }).ToList();

                    dataGridView1.DataSource = listSV;

                    txtdemsl.Text = listSV.Count.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }
    }
}
