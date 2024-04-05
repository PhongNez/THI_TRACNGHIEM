using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THI_TN_TEST
{
    public partial class frmThi : DevExpress.XtraEditors.XtraForm
    {
        public frmThi()
        {
            InitializeComponent();
            Init();
        }
        private void Init()
        {
            comboBox2.Items.Add('A');
            comboBox2.Items.Add('B');
            comboBox2.Items.Add('C');
            comboBox2.SelectedIndex = 0;
            String strLenh = "EXEC SP_LAYMONTHI D18CQCN01";
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null)
            {
                return;
            }
            DataTable dt = new DataTable();
            BindingSource dsmh = new BindingSource();
            if (Program.myReader.HasRows)
            {
                // Khởi tạo DataTable

                // Thêm các cột vào DataTable dựa trên cấu trúc của SqlDataReader
                for (int i = 0; i < Program.myReader.FieldCount; i++)
                {
                    dt.Columns.Add(Program.myReader.GetName(i), Program.myReader.GetFieldType(i));
                }

                // Đọc dữ liệu từ SqlDataReader và thêm vào DataTable
                while (Program.myReader.Read())
                {
                    DataRow row = dt.NewRow();

                    for (int i = 0; i < Program.myReader.FieldCount; i++)
                    {
                        row[i] = Program.myReader[i];
                    }

                    dt.Rows.Add(row);
                }

                // Bây giờ bạn có thể sử dụng DataTable (dt) với dữ liệu từ SqlDataReader
                // Ví dụ: In ra số hàng của DataTable
                Console.WriteLine("Số hàng trong DataTable: " + dt.Rows.Count);
            }
            else
            {
                Console.WriteLine("Không có dữ liệu trả về từ truy vấn.");
            }
            dsmh.DataSource = dt;
            comboBox1.DataSource = dsmh;//Sao chép bds_dspm đã load ở form đăng nhập
            comboBox1.DisplayMember = "MALOP";
            comboBox1.ValueMember = "MAMH";
            // Get the selected subject code
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}