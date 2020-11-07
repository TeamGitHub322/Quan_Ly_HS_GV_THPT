using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTHPT.HOCSINHDATA
{
    public partial class frmHocSinh : Form
    {
        List<string> HS;
        HOCSINHDATA hocsinh = new HOCSINHDATA();
        DataTable dt = new DataTable();
        public frmHocSinh()
        {
            InitializeComponent();

        }
        private void ADD_LIST()
        {
            HS.Clear();
            HS.Add(tbx_ID.Text.Trim());
            HS.Add(tbx_NAME.Text.Trim());
            HS.Add(tbx_CLASSID.Text.Trim());
            HS.Add(tbx_DATE.Text.Trim());
            HS.Add(tbx_SEX.Text.Trim());
            HS.Add(tbx_HOME.Text.Trim());
        }
        private void LOADHS()
        {
            dt = hocsinh.SHOWDATA();
            DGVHS.DataSource = dt;
            DGVHS.AutoResizeColumns();
        }

        private void HOCSINH_Load(object sender, EventArgs e)
        {
            HS = new List<string>();

            LOADHS();

            for (int i = 1; i < DGVHS.ColumnCount; i++)
            {
                DGVHS.Columns[i].ReadOnly = true;
            }
        }
        
}
        

