using DSS1.OBJS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DSS1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            MenhDe m = new MenhDe();
            DataTable tb = m.Tim("");
            clbSuKienChuaBiet.Items.Clear();
            foreach (DataRow r in tb.Rows)
            {
                clbSuKienChuaBiet.Items.Add(r["Ma"].ToString() + ": " + r["Ten"].ToString());
            }

            DataTable tb1 = tb;
            clbSuKienDaBiet.Items.Clear();
            foreach (DataRow r in tb1.Rows)
            {
                clbSuKienDaBiet.Items.Add(r["Ma"].ToString() + ": " + r["Ten"].ToString());
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btSuyLuan_Click(object sender, EventArgs e)
        {
            // Doc du lieu tu form de tao 2 tap SKDB va SKCB
            List<MenhDe> tapSKDB = new List<MenhDe>();
            List<MenhDe> tapSKCB = new List<MenhDe>();
            for(int i = 0; i < clbSuKienDaBiet.CheckedItems.Count; i++)
            {
                MenhDe m = new MenhDe();
                String ma = clbSuKienDaBiet.CheckedItems[i].ToString().Split(':')[0].Trim();
                m = m.TimTheoMa(int.Parse(ma));
                if (m != null)
                    tapSKDB.Add(m);
            }
            for (int i = 0; i < clbSuKienChuaBiet.CheckedItems.Count; i++)
            {
                MenhDe m = new MenhDe();
                String ma = clbSuKienChuaBiet.CheckedItems[i].ToString().Split(':')[0].Trim();
                m = m.TimTheoMa(int.Parse(ma));
                if (m != null)
                    tapSKCB.Add(m);
            }

            // Khoi tao suy dien tien
            if(tapSKDB.Count == 0 || tapSKCB.Count == 0)
            {
                MessageBox.Show("Bạn phải chọn các sự kiện đã biết và chưa biết");
                return;
            }
            SuyDienTien sd = new SuyDienTien(tapSKDB, tapSKCB);
            if(sd.TapLuat.Count == 0)
            {
                MessageBox.Show("Bạn nhập tập luật trước khi suy diễn");
                return;
            }
            List<MenhDe> ketQua = sd.SuyDien();
            if(ketQua.Count > 0)
            {
                String dienGiai = "Kết quả suy luận là:\r\n";
                foreach(MenhDe m in ketQua)
                {
                    dienGiai += m.Ten + ": " + m.MoTa + "\r\n";
                }
                tbDienGiai.Text = dienGiai;
            }
            else
            {
                tbDienGiai.Text = "Không suy diễn được";
            }
        }
    }
}
