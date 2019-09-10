using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DSS1.OBJS
{
    public class MenhDe
    {
        DataAccess da = new DataAccess();

        // Thuoc tinh
        public int Ma { get; set; }
        public String Ten { get; set; }        
        public String MoTa { get; set; }

        // Phuong thuc
        public int Them(String ten, String moTa)
        {
            String query = "INSERT INTO tbMenhDe(Ten, MoTa) VALUES(N'"
                + ten + "', N'"
                + moTa + "')";
            int dem = da.Write(query);
            return dem;
        }
        
        public int Sua(String ten, int ma, String moTa)
        {
            String query = "UPDATE tbMenhDe SET Ten=N'"
                + ten + "', MoTa=N'"
                + moTa + "' WHERE Ma=" + ma;
            int dem = da.Write(query);
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

        public MenhDe TimTheoMa(int ma)
        {
            // SELECT Ma, Ten, MoTa FROM tbMenhDe WHERE dieuKien
            String query = "SELECT Ma, Ten, MoTa FROM tbMenhDe WHERE Ma=" + ma;
            DataTable tb = new DataTable();
            tb = da.Read(query);
            if(tb != null)
            {
                MenhDe m = new MenhDe();
                m.Ma = ma;
                m.Ten = tb.Rows[0]["Ten"].ToString();
                m.MoTa = tb.Rows[0]["MoTa"].ToString();
                return m;
            }
            else
                return null;
        }
    }
}
