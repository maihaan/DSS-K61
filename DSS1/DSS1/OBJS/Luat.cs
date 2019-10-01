using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;

namespace DSS1.OBJS
{
    public class Luat
    {
        DataAccess da = new DataAccess();

        // Thuoc tinh
        public int Ma { get; set; }
        public String Ten { get; set; }        
        public String MoTa { get; set; }
        public List<MenhDe> VeTrai { get; set; }
        public MenhDe VePhai { get; set; }

        // Phuong thuc
        public int Them(String ten,  String moTa, List<MenhDe> veTrai, MenhDe vePhai)
        {
            String queryLuat = "INSERT INTO tbLuat(Ten, MoTa, MaMenhDe) VALUES(N'"
                + ten + "', N'"
                + moTa + "', "
                + vePhai.Ma + ")";
            int dem = da.Write(queryLuat);
            int ma = da.GetMaxColumnValue("tbLuat", "Ma");
            int demVT = 0;
            foreach(MenhDe md in veTrai)
            {
                String queryVeTrai = "INSERT INTO tbVeTrai(MaLuat, MaMenhDe) VALUES("
                    + ma + ", "
                    + md.Ma + ")";
                demVT += da.Write(queryVeTrai);
            }
            return dem;
        }

        public int Sua(int ma, String ten, String moTa, List<MenhDe> veTrai, MenhDe vePhai)
        {
            String queryLuat = "UPDATE tbLuat SET Ten=N'"
                + ten + "', MoTa=N'"
                + moTa + "', MaMenhDe="
                + VePhai.Ma + " WHERE Ma=" + ma;            
            int dem = da.Write(queryLuat);

            // Cap nhat cho ve trai
            // Buoc 1: Doc cac ve trai cu cua luat can cap nhat
            Luat r= new Luat();
            r = r.TimTheoMa(ma);
            if (r != null)
            {
                List<MenhDe> veTraiCu = r.VeTrai;

                // Buoc 2: Doi chieu ve trai cu va ve trai moi de lap cac danh sach
                List<int> dsCapNhat = new List<int>();
                List<int> dsThemMoi = new List<int>();
                List<int> dsXoa = new List<int>();
                foreach (MenhDe mdc in veTraiCu)
                {
                    Boolean timThay = false;
                    foreach (MenhDe mdm in veTrai)
                    {
                        if (mdc.Ma == mdm.Ma)
                        {
                            dsCapNhat.Add(mdc.Ma);
                            timThay = true;
                            break;
                        }
                    }
                    if (!timThay)
                        dsXoa.Add(mdc.Ma);
                }
                foreach (MenhDe mdm in veTrai)
                {
                    Boolean timThay = false;
                    foreach (MenhDe mdc in veTraiCu)
                    {
                        if (mdm.Ma == mdc.Ma)
                        {
                            timThay = true;
                            break;
                        }
                    }
                    if (!timThay)
                        dsThemMoi.Add(mdm.Ma);
                }

                // Buoc 3: Thuc thi cac danh sach
                foreach (int maMenhDe in dsThemMoi)
                {
                    String query = "INSERT INTO tbVeTrai(MaLuat, MaMenhDe) VALUES("
                        + ma + ", "
                        + maMenhDe + ")";
                    da.Write(query);
                }
                foreach (int maMenhDe in dsXoa)
                {
                    String query = "DELETE tbVeTrai WHERE MaMenhDe="
                        + maMenhDe;
                    da.Write(query);
                }
            }
            return dem;
        }

        public int Xoa(int ma)
        {
            String query = "DELETE tbMenhDe WHERE Ma=" + ma;
            int dem = da.Write(query);
            return dem;
        }

        public DataTable Tim(String dieuKien)
        {
            // SELECT Ma, Ten, MoTa FROM tbMenhDe WHERE dieuKien
            String query = "SELECT Ma, Ten, MoTa FROM tbMenhDe";
            if (!String.IsNullOrEmpty(dieuKien))
                query += " WHERE " + dieuKien;
            DataTable tb = new DataTable();
            tb = da.Read(query);
            return tb;
        }

        public Luat TimTheoMa(int ma)
        {
            // Lay danh sach cac menh de ve trai co ma luat can tim
            String queryVeTrai = "SELECT MaMenhDe FROM tbVeTrai WHERE MaLuat=" + ma;
            DataTable tbVeTrai = da.Read(queryVeTrai);
            if(tbVeTrai != null && tbVeTrai.Rows.Count > 0)
            {
                List<MenhDe> veTrai = new List<MenhDe>();
                foreach(DataRow r in tbVeTrai.Rows)
                {
                    int maMenhDe = int.Parse(r["MaMenhDe"].ToString());
                    MenhDe md = new MenhDe();
                    veTrai.Add(md.TimTheoMa(maMenhDe));
                }
                String queryLuat = "SELECT * FROM tbLuat WHERE Ma=" + ma;
                DataTable tbLuat = da.Read(queryLuat);
                if(tbLuat != null && tbLuat.Rows.Count > 0)
                {
                    Luat r = new Luat();
                    r.Ma = ma;
                    r.Ten = tbLuat.Rows[0]["Ten"].ToString();
                    r.MoTa = tbLuat.Rows[0]["MoTa"].ToString();
                    r.VeTrai = veTrai;
                    MenhDe md = new MenhDe();
                    int maMenhDeVePhai = int.Parse(tbLuat.Rows[0]["MaMenhDe"].ToString());
                    r.VePhai = md.TimTheoMa(maMenhDeVePhai);
                    return r;
                }
            }
            return null;
        }

        public List<Luat> DocTatCa()
        {
            List<Luat> ds = new List<Luat>();
            DataTable tb = Tim("");
            if(tb != null && tb.Rows.Count > 0)
            {
                foreach(DataRow rw in tb.Rows)
                {
                    int ma = int.Parse(rw["Ma"].ToString());
                    ds.Add(TimTheoMa(ma));
                }
            }            
            return ds;
        }
    }
}
