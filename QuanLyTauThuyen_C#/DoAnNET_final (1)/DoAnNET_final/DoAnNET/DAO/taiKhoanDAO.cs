using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DoAnNET.DAO;
using System.Security.Cryptography;

namespace DoAnNET
{
    class taiKhoanDAO
    {
        private static taiKhoanDAO instance;

        public static taiKhoanDAO Ins
        {
            get { if (instance == null) instance = new taiKhoanDAO(); return instance; }
            set { instance = value; }
        }

        private taiKhoanDAO() { }

        public string checkLogin(string usn, string pwd)
        {
            byte[] pass = ASCIIEncoding.ASCII.GetBytes(pwd);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(pass);
            string hasPass = "";
            foreach(byte b in hasData)
            {
                hasPass += b;
            }
            try
            {
                string sql = "exec prc_getLogin @usn , @pwd";
                string kq = DataProvider.Instance.ExecuteScalar(sql, new object[] { usn, hasPass }).ToString().Trim();
                return kq;
            }
            catch
            {
                return "0";
            }
        }
        public DataTable showTK()
        {
            try
            {
                string sql = "exec prc_showTK ";
                DataTable kq = DataProvider.Instance.ExecuteQuery(sql);
                return kq;
            }
            catch
            {
                return null;
            }
        }
        public DataTable showNVChuaTK()
        {
            try
            {
                string sql = "exec prc_showNVChuaTK ";
                DataTable kq = DataProvider.Instance.ExecuteQuery(sql);
                return kq;
            }
            catch
            {
                return null;
            }
        }
        public bool addTK(string manv, string tendn, string matkhau)
        {
            byte[] pass = ASCIIEncoding.ASCII.GetBytes(matkhau);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(pass);
            string hasPass = "";
            foreach (byte b in hasData)
            {
                hasPass += b;
            }

            try
            {
                string sql = "exec  prc_addTK @manv , @tendn , @matkhau ";
                int kq = DataProvider.Instance.ExecuteNonQuery(sql, new object[] { manv, tendn, hasPass });
                if (kq != 0)
                    return true;
                return false;
            }
            catch
            {
                return false;
            }
        }
        public bool checkTenTK(string tendn)
        {
            try
            {
                string sql = "exec  prc_checkTenTK @tendn ";
                int kq = int.Parse(DataProvider.Instance.ExecuteScalar(sql, new object[] { tendn }).ToString());
                if (kq == 0)
                    return true;
                return false;
            }
            catch
            {
                return false;
            }
        }
        public bool editMKTK(string tendn, string mk)
        {
            byte[] pass = ASCIIEncoding.ASCII.GetBytes(mk);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(pass);
            string hasPass = "";
            foreach (byte b in hasData)
            {
                hasPass += b;
            }
            try
            {
                string sql = "exec  prc_editMKTK  @tendn , @matkhau ";
                int kq = DataProvider.Instance.ExecuteNonQuery(sql, new object[] { tendn, hasPass });
                if (kq != 0)
                    return true;
                return false;
            }
            catch
            {
                return false;
            }
        }
        public DataTable findTK(string text)
        {
            try
            {
                string sql = "exec prc_findTK @text ";
                DataTable kq = DataProvider.Instance.ExecuteQuery(sql, new object[] { text });
                return kq;
            }
            catch
            {
                return null;
            }
        }
        public bool delTK(string tendn)
        {
            try
            {
                string sql = "exec prc_delTK @text ";
                int kq = DataProvider.Instance.ExecuteNonQuery(sql, new object[] { tendn });
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
