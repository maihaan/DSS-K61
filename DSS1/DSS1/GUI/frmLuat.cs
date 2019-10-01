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
            LoadData();
        }
    }
}
