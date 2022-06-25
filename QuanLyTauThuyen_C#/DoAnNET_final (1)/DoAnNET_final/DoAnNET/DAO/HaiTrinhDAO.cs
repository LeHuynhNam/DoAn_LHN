using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnNET.DAO
{
    class HaiTrinhDAO
    {
        private static HaiTrinhDAO instance;

        public static HaiTrinhDAO Ins
        {
            get { if (instance == null) instance = new HaiTrinhDAO(); return instance; }
            set { instance = value; }
        }

        private HaiTrinhDAO() { }

        public DataTable showHT()
        {
            try
            {
                string sql = "exec prc_showHT ";
                DataTable kq = DataProvider.Instance.ExecuteQuery(sql);
                return kq;
            }
            catch
            {
                return null;
            }
        }
        public bool addHT(string matau, string ngaydi, string ngayve, string giadau, string dautieuthu)
        {
            try
            {
                string sql = "exec  prc_addHT @matau , @ngaydi , @ngayve , @dautieuthu , @giadau  ";
                int kq = DataProvider.Instance.ExecuteNonQuery(sql, new object[] { matau, ngaydi, ngayve, dautieuthu, giadau });
                if (kq != 0)
                    return true;
                return false;
            }
            catch
            {
                return false;
            }
        }
        public bool addCTHT(string maht, string masp, string sl, string gia)
        {
            try
            {
                string sql = "exec  prc_addCTHT @maht ,  @masp , @sl , @gia ";
                int kq = DataProvider.Instance.ExecuteNonQuery(sql, new object[] { maht, masp, sl, gia });
                if (kq != 0)
                    return true;
                return false;
            }
            catch
            {
                return false;
            }
        }

        public string getMaHT()
        {
            try
            {
                string sql = "exec  prc_getMaHT ";
                string kq = DataProvider.Instance.ExecuteScalar(sql).ToString();
                return kq;
            }
            catch
            {
                return null;
            }
        }
        public DataTable findHT(string text)
        {
            try
            {
                string sql = "exec prc_findHT @text ";
                DataTable kq = DataProvider.Instance.ExecuteQuery(sql, new object[] { text });
                return kq;
            }
            catch
            {
                return null;
            }
        }

        public DataTable showCTHT(string maht)
        {
            try
            {
                string sql = "exec prc_showCTHT @maht ";
                DataTable kq = DataProvider.Instance.ExecuteQuery(sql, new object[] { maht });
                return kq;
            }
            catch
            {
                return null;
            }
        }


    }
}
