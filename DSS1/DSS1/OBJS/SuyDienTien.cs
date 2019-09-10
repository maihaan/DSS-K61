using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DSS1.OBJS
{
    public class SuyDienTien
    {
        // Thuộc tính
        public List<Luat> TapLuat = new List<Luat>();
        public List<MenhDe> TapSKDaBiet = new List<MenhDe>();
        public List<MenhDe> TapSKCanTim = new List<MenhDe>();
        private List<float> Rank = new List<float>();
        // Phương thức
        public SuyDienTien(List<MenhDe> tapSKDB, List<MenhDe> tapSKCT)
        {
            TapSKDaBiet = tapSKDB;
            TapSKCanTim = tapSKCT;
            Luat r = new Luat();
            TapLuat = r.DocTatCa();
        }

        public List<MenhDe> SuyDien()
        {
            List<MenhDe> ketQua = new List<MenhDe>();
            Boolean tiepTuc = true;
            while(tiepTuc)
            {
                // Tinh huong 1: Tap luat rong
                if (TapLuat.Count == 0)
                {
                    tiepTuc = false;
                    break;
                }

                // Tinh huong 2: Toan bo tap su kien can tim deu thuoc tap su kien da biet
                foreach (MenhDe m in TapSKCanTim)
                {
                    if (!TapSKDaBiet.Contains(m))
                    {
                        tiepTuc = true;
                        break;
                    }
                }
                if (!tiepTuc)
                    break;

                // Tinh huong 3: Tap su kien da biet khong thay doi sau khi duyet het tap luat
                int dem = TapSKDaBiet.Count;
                Rank.Clear();
                foreach (Luat r in TapLuat)
                {
                    // Kiem tra xem ve trai cua luat co thuoc tap su kien da biet hay khong
                    // neu dung thi them ve phai cua luat vao tap su kien da biet va loai bo
                    // luat do khoi tap luat, neu khong thi bo qua
                    List<MenhDe> veTrai = r.VeTrai;
                    Boolean apDung = true;
                    int demPT = 0;
                    foreach (MenhDe m in veTrai)
                    {
                        if (!TapSKDaBiet.Contains(m))
                        {
                            apDung = false;
                        }
                        else
                            demPT++;
                    }
                    
                    if (apDung)
                    {
                        if(!TapSKDaBiet.Contains(r.VePhai))
                            TapSKDaBiet.Add(r.VePhai);
                        if(!ketQua.Contains(r.VePhai))
                            ketQua.Add(r.VePhai);
                        TapLuat.Remove(r);
                    }
                    else
                        Rank.Add((float)demPT / veTrai.Count);
                }
                if(dem == TapSKDaBiet.Count)
                {
                    tiepTuc = false;
                    break;
                }


            }
            return ketQua;
        }

        public Boolean DocKetQua()
        {
            Boolean thanhCong = true;
            foreach(MenhDe m in TapSKCanTim)
            {
                if(!TapSKDaBiet.Contains(m))
                {
                    thanhCong = false;
                    break;
                }
            }
            return thanhCong;
        }

        public Boolean SuyDienLai()
        {
            float nguong = 0.8f;
            if (Rank.Count == 0)
                return false;
            int index = 0;
            float max = 0;
            for(int i = 0; i < Rank.Count; i++)
            {
                if(Rank[i] > max)
                {
                    index = i;
                    max = Rank[i];
                }
            }
            if (Rank[index] < nguong)
                return false;
            // Lay cac menh de chua biet o ve trai cua luat co Rank cao nhat va bo sung
            // vao tap su kien da biet
            Luat r = TapLuat[index];
            foreach(MenhDe m in r.VeTrai)
            {
                if (!TapSKDaBiet.Contains(m))
                    TapSKDaBiet.Add(m);
            }
            TapSKDaBiet.Add(r.VePhai);
            TapLuat.Remove(r);
            Rank.RemoveAt(index);
            SuyDien();
            return true;
        }
    }
}
