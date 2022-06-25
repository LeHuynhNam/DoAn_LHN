using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnNET.DAO
{
    class SanPhamDAO
    {
        private static SanPhamDAO instance;

        public static SanPhamDAO Ins
        {
            get { if (instance == null) instance = new SanPhamDAO(); return instance; }
            set { instance = value; }
        }

        private SanPhamDAO() { }

        public DataTable showSP()
        {
            try
            {
                string sql = "exec prc_showSP ";
                DataTable kq = DataProvider.Instance.ExecuteQuery(sql);
                return kq;
            }
            catch
            {
                return null;
            }
        }

        public DataTable findSP(string text)
        {
            try
            {
                string sql = "exec prc_findSP @text";
                DataTable kq = DataProvider.Instance.ExecuteQuery(sql, new object[] { text });
                return kq;
            }
            catch
            {
                return null;
            }
        }

        public DataTable showGia(string ma)
        {
            try
            {
                string sql = "exec prc_showGiaSP @ma";
                DataTable kq = DataProvider.Instance.ExecuteQuery(sql, new object[] { ma });
                return kq;
            }
            catch
            {
                return null;
            }
        }
        public bool addSP(string ten, string dvt)
        {
            try
            {
                string sql = "exec  prc_addSP @ten , @dvt ";
                int kq = DataProvider.Instance.ExecuteNonQuery(sql, new object[] { ten, dvt });
                if (kq != 0)
                    return true;
                return false;
            }
            catch
            {
                return false;
            }
        }
        public bool addGiaSP(string gia, string ngaycapnhat, string masp)
        {
            try
            {
                string sql = "exec  prc_addGiaSP @ma , @ngaycn , @gia ";
                int kq = DataProvider.Instance.ExecuteNonQuery(sql, new object[] { masp, ngaycapnhat, gia });
                if (kq != 0)
                    return true;
                return false;
            }
            catch
            {
                return false;
            }
        }
        public bool editGiaSP(string gia, string ngaycapnhat, string masp)
        {
            try
            {
                string sql = "exec  prc_editGiaSP @ma , @ngaycn , @gia ";
                int kq = DataProvider.Instance.ExecuteNonQuery(sql, new object[] { masp, ngaycapnhat, gia });
                if (kq != 0)
                    return true;
                return false;
            }
            catch
            {
                return false;
            }
        }
        public bool checkGiaSP(string ngaycapnhat, string masp)
        {
            try
            {
                string sql = "exec  prc_checkGiaSP @ma , @ngaycn ";
                int kq = int.Parse(DataProvider.Instance.ExecuteScalar(sql, new object[] { masp, ngaycapnhat}).ToString());
                if (kq != 0)
                    return true;
                return false;
            }
            catch
            {
                return false;
            }
        }
        public string getGiaSP(string masp)
        {
            try
            {
                string sql = "exec  prc_getGiaSP @ma ";
                string kq = DataProvider.Instance.ExecuteScalar(sql, new object[] { masp}).ToString();
                return kq;
            }
            catch
            {
                return null;
            }
        }
        public string getIDSP()
        {
            try
            {
                string sql = "exec  prc_getIDSP";
                string kq = DataProvider.Instance.ExecuteScalar(sql).ToString();
                return kq;
            }
            catch
            {
                return null;
            }
        }
    }
}
