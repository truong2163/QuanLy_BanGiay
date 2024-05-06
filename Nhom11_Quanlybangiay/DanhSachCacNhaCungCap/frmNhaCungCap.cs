using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using System.Data.OleDb;
using Microsoft.Office.Interop.Excel;
using System.IO;
using app = Microsoft.Office.Interop.Excel.Application;
using ExcelDataReader;
using Excel = Microsoft.Office.Interop.Excel;
namespace Nhom11_Quanlybangiay.DanhSachCacNhaCungCap
{
    public partial class frmNhaCungCap : Form
    {
        public frmNhaCungCap()
        {
            InitializeComponent();
        }
        dataNCC data = new dataNCC();
        int kiemtracell;
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenNCC.Text) || string.IsNullOrWhiteSpace(txtDiaChi.Text) || string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("Dữ liệu không hợp lệ!!!");
            }
            else if (txtSDT.Text.Length != 10)
            {
                MessageBox.Show("Điện thoại phải có 10 số!!!");
            }
            else
            {

                if (kiemtracell == 1)
                {
                    data.sua(Convert.ToInt32(txtMaNCC.Text), txtTenNCC.Text, txtSDT.Text, txtDiaChi.Text, cbNhap.Text);  // SỬA NHÀ CUNG CẤP VỚI THAM SỐ TRUYỀN VÀO
                    dgvncc.DataSource = data.getThongTinNCC();
                    clear();
                }
                else
                {
                    data.sua2(Convert.ToInt32(txtMaNCC.Text), txtTenNCC.Text, txtSDT.Text, txtDiaChi.Text, cbNhap.Text);  // SỬA NHÀ CUNG CẤP VỚI THAM SỐ TRUYỀN VÀO
                    dgvncc.DataSource = data.getThongTinNCC();
                    clear();
                }

            }
        }
        public void Getheader() // TẠO HEADER
        {
            dgvncc.Columns[0].HeaderText = "Mã";
            dgvncc.Columns[1].HeaderText = "Tên nhà cung cấp";
            dgvncc.Columns[2].HeaderText = "Số điện thoại";
            dgvncc.Columns[3].HeaderText = "Địa chỉ";
            dgvncc.Columns[4].HeaderText = "Tình trạng nhập";
            dgvncc.Columns[0].Width = 50;
            dgvncc.Columns[1].Width = 150;
            dgvncc.Columns[2].Width = 150;
            dgvncc.Columns[3].Width = 300;
        }
        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            dgvncc.DataSource = data.getThongTinNCC();
            cbNhap.SelectedIndex = 0;
            Getheader();
            lblTK.Text = "Tổng số nhà cung cấp: " + dgvncc.Rows.Count;
        }

        private void clear() // DỌN SÁCH Ô TEXTBOX
        {
            txtMaNCC.Enabled = false;
            txtMaNCC.Clear();
            txtTenNCC.Clear();
            txtDiaChi.Clear();
            txtSDT.Clear();
        }
        private void txtTenNCC_TextChanged(object sender, EventArgs e)
        {
            kiemtracell = 1;
        }
        private void dgvncc_CellClick(object sender, DataGridViewCellEventArgs e)  // CELL CLICK
        {
            try
            {
                int d = e.RowIndex;
                txtMaNCC.Text = dgvncc.Rows[d].Cells[0].Value.ToString();
                txtTenNCC.Text = dgvncc.Rows[d].Cells[1].Value.ToString();
                txtSDT.Text = dgvncc.Rows[d].Cells[2].Value.ToString();
                txtDiaChi.Text = dgvncc.Rows[d].Cells[3].Value.ToString();
                cbNhap.Text = dgvncc.Rows[d].Cells[4].Value.ToString();
                txtMaNCC.Enabled = false;
                txtSDT.Text.Trim();
                kiemtracell = 0;
            }
            catch (Exception)
            {

                //TRƯỜNG HỢP XỬ LÍ NGOẠI LỆ D =-1
            }
        }

        private void button2_Click(object sender, EventArgs e) //BTN THÊM
        {
            if (string.IsNullOrWhiteSpace(txtTenNCC.Text) || string.IsNullOrWhiteSpace(txtDiaChi.Text) || string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("Dữ liệu không hợp lệ!!!");
            }
            else if (txtSDT.Text.Length != 10)
            {
                MessageBox.Show("Điện thoại phải có 10 số!!!");
            }
            else
            {
                data.them(txtTenNCC.Text, txtSDT.Text, txtDiaChi.Text, cbNhap.Text); // THUỘC TÍNH THÊM
                dgvncc.DataSource = data.getThongTinNCC();
                clear();
                lblTK.Text = "Tổng số nhà cung cấp: " + dgvncc.Rows.Count;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có chắc chắn xóa không, mọi thông tin liên quan về nhà cung cấp này sẽ bị xóa?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kq.Equals(DialogResult.Yes))
            {
                data.xoa(Convert.ToInt32(txtMaNCC.Text));
                dgvncc.DataSource = data.getThongTinNCC();
                clear();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        { // XỬ LÝ NGOẠI LỆ KHI XEM MÃ NCC TRỐNG
           
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
            dgvncc.DataSource = data.getThongTinNCC();
            txtMaNCC.Enabled = true;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtMaNCC.Text))
            {
                MessageBox.Show("Không được để trắng dữ liệu");
            }
            else
            {
                dgvncc.DataSource = data.timtheoma(Convert.ToInt32(txtMaNCC.Text));
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            dgvncc.DataSource = data.timtheotem(txtTenNCC.Text);

        }
        private void xuatfileExcel(DataGridView g, string duongDan, string tentep) // HÀM XUẤT FILE EXCEL
        {
            app obj = new app(); // KHƠI TẠO APP
            obj.Application.Workbooks.Add(Type.Missing); // ĐỐI TƯỢNG OBJ ĐỂ LƯU TRỮ
            obj.Columns.ColumnWidth = 25;
            for (int i = 1; i < g.Columns.Count + 1; i++) // chạy hàng ngang
            {
                obj.Cells[1, i] = g.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < g.Rows.Count; i++)  // CHẠY HÀNG DỌC
            {
                for (int j = 0; j < g.Columns.Count; j++) // CHẠY HÀNG NGANG
                {
                    if (g.Rows[i].Cells[j].Value != null) // Khác NULL THÌ CHÈN VÀO
                    {
                        obj.Cells[i + 2, j + 1] = g.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            obj.ActiveWorkbook.SaveCopyAs(duongDan + tentep + ".xlsx"); // LƯU TÊN TỆP
            obj.ActiveWorkbook.Saved = true;

        }


        private void btnExport_Click(object sender, EventArgs e)
        {



            try
            {

                MessageBox.Show("Máy bạn phải có ổ D");
                xuatfileExcel(dgvncc, @"E:\", "Workbook");
                MessageBox.Show("Xuất file thành công. ", "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                System.Diagnostics.Process.Start("Excel.exe", @"E:\Workbook.xlsx");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Xuất file không thành công", "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
               
            
      
        }


        private List<string> getListSheet(string urlFile)
        {
            try
            {
                List<string> sheets = new List<string>();
                string connec = string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=""Excel 8.0;HDR=YES;IMEX=1;""", urlFile);
                DbProviderFactory factory = DbProviderFactories.GetFactory("System.Data.OleDb");
                DbConnection connection = factory.CreateConnection();
                connection.ConnectionString = connec;
                connection.Open();
                System.Data.DataTable dt = connection.GetSchema("Tables");
                connection.Close();
                foreach (DataRow row in dt.Rows)
                {
                    string sheetnames = (string)row["TABLE_NAME"];
                    sheets.Add(sheetnames);
                }
                return sheets;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private void btnIm_Click(object sender, EventArgs e)
        {
            dgvcheckdulieu.DataSource = Import();
            for (int i = 0; i < dgvcheckdulieu.Rows.Count; i++)
            {
                string tenncc = dgvcheckdulieu.Rows[i].Cells[1].Value.ToString();
                string sdt = dgvcheckdulieu.Rows[i].Cells[2].Value.ToString();
                string diachi = dgvcheckdulieu.Rows[i].Cells[3].Value.ToString();
                string tinhtrangnhap = dgvcheckdulieu.Rows[i].Cells[4].Value.ToString();

                data.kiemtranhacungcap(tenncc);
                if(tenncc.Length==0||sdt.Length!=9||diachi.Length==0)
                {

                }   
                else if(tinhtrangnhap.Equals("N")||tinhtrangnhap.Equals("K"))
                {
                    if (data.kiemtrancc == 0)
                    {
                        data.them(tenncc, "0"+sdt, diachi, tinhtrangnhap);
                        dgvncc.DataSource = data.getThongTinNCC();
                        lblTK.Text = "Tổng số nhà cung cấp: " + dgvncc.Rows.Count;
                    }
                }    
                
            }
            MessageBox.Show("Import thành công", "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        public System.Data.DataTable Import()
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel Workbook|*xlsx", ValidateNames = true })
            {
                System.Data.DataTable dt = new System.Data.DataTable();
                if (ofd.ShowDialog() == DialogResult.OK)
                {

                    using (var stream = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read))
                    {
                        IExcelDataReader reader;
                        if (ofd.FilterIndex == 2)
                        {
                            reader = ExcelReaderFactory.CreateBinaryReader(stream);
                        }
                        else
                        {
                            reader = ExcelReaderFactory.CreateOpenXmlReader(stream);
                        }
                        DataSet ds = new DataSet();
                        ds = reader.AsDataSet(new ExcelDataSetConfiguration()
                        {
                            ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                            {
                                UseHeaderRow = true
                            }
                        });
                        foreach (System.Data.DataTable item in ds.Tables)
                        {
                            dt = item;
                        }
                        reader.Close();

                    }
                    return dt;
                }
            }
            return null;
        }

        private void dgvncc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
