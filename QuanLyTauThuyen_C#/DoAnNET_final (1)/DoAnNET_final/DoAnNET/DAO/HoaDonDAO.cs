using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnNET.DAO
{
    class HoaDonDAO
    {
        private static HoaDonDAO instance;

        public static HoaDonDAO Ins
        {
            get { if (instance == null) instance = new HoaDonDAO(); return instance; }
            set { instance = value; }
        }

        private HoaDonDAO() { }

        public DataTable showHD()
        {
            try
            {
                string sql = "exec prc_showHD ";
                DataTable kq = DataProvider.Instance.ExecuteQuery(sql);
                return kq;
            }
            catch
            {
                return null;
            }
        }
        public DataTable showCTHD(string mahd)
        {
            try
            {
                string sql = "exec prc_showCTHD @mahd ";
                DataTable kq = DataProvider.Instance.ExecuteQuery(sql, new object[] { mahd });
                return kq;
            }
            catch
            {
                return null;
            }
        }
        public bool editHD(string ma, string tt)
        {
            try
            {
                string sql = "exec  prc_editHD @ma ,  @tt ";
                int kq = DataProvider.Instance.ExecuteNonQuery(sql, new object[] { ma, tt });
                if (kq != 0)
                    return true;
                return false;
            }
            catch
            {
                return false;
            }
        }
        public DataTable findHD(string text)
        {
            try
            {
                string sql = "exec prc_findHD @text ";
                DataTable kq = DataProvider.Instance.ExecuteQuery(sql, new object[] { text });
                return kq;
            }
            catch
            {
                return null;
            }
        }
        public bool addHD(string makh, string tinhtrang)
        {
            try
            {
                if (makh == null)
                {
                    string sql1 = "exec prc_addHD null , @ngaylap , @tinhtrang";
                    int kq1 = DataProvider.Instance.ExecuteNonQuery(sql1, new object[] { DateTime.Today.ToShortDateString(), tinhtrang });
                    if (kq1 != 0)
                        return true;
                    return false;
                }
                else
                {
                    string sql = "exec  prc_addHD @makh ,  @ngaylap , @tinhtrang ";
                    int kq = DataProvider.Instance.ExecuteNonQuery(sql, new object[] { makh, DateTime.Today.ToShortDateString(), tinhtrang });
                    if (kq != 0)
                        return true;
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public string getMaHD()
        {
            try
            {
                string sql = "exec  prc_getMaHD ";
                string kq = DataProvider.Instance.ExecuteScalar(sql).ToString();
                return kq;
            }
            catch
            {
                return null;
            }
        }
        public bool addCTHD(string mahd, string masp, string sl, string gia)
        {
            try
            {
                string sql = "exec  prc_addCTHD @mahd ,  @masp , @sl , @gia ";
                int kq = DataProvider.Instance.ExecuteNonQuery(sql, new object[] { mahd, masp, sl, gia });
                if (kq != 0)
                    return true;
                return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
