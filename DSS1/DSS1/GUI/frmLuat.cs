using DSS1.OBJS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DSS1.GUI
{
    public partial class frmLuat : Form
    {
        public frmLuat()
        {
            InitializeComponent();
        }

        private void frmLuat_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadLuat();
        }

        private void LoadLuat()
        {
            Luat l = new Luat();
            DataTable tb = l.Tim("");
            dgvDanhSach.DataSource = tb;
        }


        private void LoadData()
        {
            MenhDe m = new MenhDe();
            DataTable tb = m.Tim("");

            cbVePhai.DataSource = tb;
            cbVePhai.DisplayMember = "Ten";
            cbVePhai.ValueMember = "Ma";

            DataTable tb1 = tb;
            clbVeTrai.Items.Clear();
            foreach(DataRow r in tb1.Rows)
            {                                
                clbVeTrai.Items.Add(r["Ma"].ToString() + ": " + r["Ten"].ToString());                
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            Luat l = new Luat();
            List<MenhDe> veTrai = new List<MenhDe>();
            MenhDe vePhai = new MenhDe();
            // Vetrai
            for(int i = 0; i < clbVeTrai.CheckedItems.Count; i++)
            {
                MenhDe m = new MenhDe();
                String ma = clbVeTrai.CheckedItems[i].ToString().Split(':')[0];
                m = m.TimTheoMa(int.Parse(ma));
                veTrai.Add(m);
            }
            // VePhai
            vePhai = vePhai.TimTheoMa(int.Parse(cbVePhai.SelectedValue.ToString()));

            l.Them(tbTen.Text, tbMoTa.Text, veTrai, vePhai);
            LoadLuat();
            btLamMoi_Click(sender, e);
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            Luat l = new Luat();
            List<MenhDe> veTrai = new List<MenhDe>();
            MenhDe vePhai = new MenhDe();
            // Vetrai
            for (int i = 0; i < clbVeTrai.CheckedItems.Count; i++)
            {
                MenhDe m = new MenhDe();
                String ma = clbVeTrai.CheckedItems[i].ToString().Split(':')[0];
                m = m.TimTheoMa(int.Parse(ma));
                veTrai.Add(m);
            }
            // VePhai
            vePhai = vePhai.TimTheoMa(int.Parse(cbVePhai.SelectedValue.ToString()));
            int id = int.Parse(dgvDanhSach.SelectedRows[0].Cells["Ma"].Value.ToString());
            l.Sua(id, tbTen.Text, tbMoTa.Text, veTrai, vePhai);
            LoadLuat();
            btLamMoi_Click(sender, e);
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            Luat l = new Luat();
            int id = int.Parse(dgvDanhSach.SelectedRows[0].Cells["Ma"].Value.ToString());
            l.Xoa(id);
            LoadLuat();
            btLamMoi_Click(sender, e);
        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbTen.Text = dgvDanhSach.SelectedRows[0].Cells["Ten"].Value.ToString();
            tbMoTa.Text = dgvDanhSach.SelectedRows[0].Cells["MoTa"].Value.ToString();
            cbVePhai.SelectedValue = dgvDanhSach.SelectedRows[0].Cells["MaMenhDe"].Value.ToString();
            String maLuat = dgvDanhSach.SelectedRows[0].Cells["Ma"].Value.ToString();
            Luat l = new Luat();
            l = l.TimTheoMa(int.Parse(maLuat));
            if (l != null)
            {
                List<MenhDe> veTrai = l.VeTrai;
                for (int i = 0; i < clbVeTrai.Items.Count; i++)
                    clbVeTrai.SetItemChecked(i, false);
                foreach (MenhDe m in veTrai)
                {                    
                    for (int i = 0; i < clbVeTrai.Items.Count; i++)
                    {
                        if (clbVeTrai.Items[i].ToString().Split(':')[0].Equals(m.Ma.ToString()))
                        {
                            clbVeTrai.SetItemChecked(i, true);
                        }
                    }
                }
            }
        }

        private void btLamMoi_Click(object sender, EventArgs e)
        {
            tbTen.Text = "";
            tbMoTa.Text = "";
            LoadData();
        }
    }
}
