using DoAnNET.POJO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnNET.DAO
{
    class KhachHangDAO
    {
        private static KhachHangDAO instance;

        public static KhachHangDAO Ins
        {
            get { if (instance == null) instance = new KhachHangDAO(); return instance; }
            set { instance = value; }
        }

        private KhachHangDAO() { }


        public DataTable showKH()
        {
            try
            {
                string sql = "exec prc_showKH ";
                DataTable kq = DataProvider.Instance.ExecuteQuery(sql);
                return kq;
            }
            catch
            {
                return null;
            }
        }
        public DataTable findKH(string text)
        {
            try
            {
                string sql = "exec prc_findKH @text ";
                DataTable kq = DataProvider.Instance.ExecuteQuery(sql, new object[] { text });
                return kq;
            }
            catch
            {
                return null;
            }
        }

        public bool addKH(khachHang kh)
        {
            try
            {
                string sql = "exec prc_addKH @tenkh , @sdt , @masothue , @diachi , @loaikh ";
                int kq = DataProvider.Instance.ExecuteNonQuery(sql, new object[] { kh.hoten,kh.sdt,kh.masothue,kh.diachi,kh.loaikh });
                if (kq != 0)
                    return true;
                return false;
            }
            catch
            {
                return false;
            }
        }

        public bool updateKH(khachHang kh)
        {
            try
            {
                string sql = "exec prc_changeKH @id , @tenkh , @sdt , @masothue , @diachi , @loaikh";
                int kq = DataProvider.Instance.ExecuteNonQuery(sql, new object[] {kh.id, kh.hoten, kh.sdt, kh.masothue, kh.diachi, kh.loaikh });
                if (kq != 0)
                    return true;
                return false;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool deleteKH(khachHang kh)
        {
            try
            {
                string sql = "exec prc_deleteKH @id";
                int kq = DataProvider.Instance.ExecuteNonQuery(sql, new object[] { kh.id });
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
