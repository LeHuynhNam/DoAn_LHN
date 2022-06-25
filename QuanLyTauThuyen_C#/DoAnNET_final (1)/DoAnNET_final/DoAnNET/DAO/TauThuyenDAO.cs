using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnNET.DAO
{
    class TauThuyenDAO
    {
        private static TauThuyenDAO instance;

        public static TauThuyenDAO Ins
        {
            get { if (instance == null) instance = new TauThuyenDAO(); return instance; }
            set { instance = value; }
        }

        private TauThuyenDAO() { }

        public DataTable showTT()
        {
            try
            {
                string sql = "exec prc_showTT ";
                DataTable kq = DataProvider.Instance.ExecuteQuery(sql);
                return kq;
            }
            catch
            {
                return null;
            }
        }
        public bool changeTT(string matau, string ttmoi)
        {
            try
            {
                string sql = "exec  prc_changeTT @matau , @ttmoi ";
                int kq = DataProvider.Instance.ExecuteNonQuery(sql, new object[] { matau, ttmoi });
                if (kq != 0)
                    return true;
                return false;
            }
            catch
            {
                return false;
            }
        }
        public int findTT(string matau)
        {
            try
            {
                string sql = "exec  prc_findTT @matau  ";
                int kq = DataProvider.Instance.ExecuteNonQuery(sql, new object[] { matau });
                if (kq > 0)
                    return 0;
                return 1;
            }
            catch
            {
                return 2;
            }
        }
        public bool addTT(string matau, string loaitau)
        {
            try
            {
                string sql = "exec  prc_addTT @matau , @loaitau ";
                int kq = DataProvider.Instance.ExecuteNonQuery(sql, new object[] { matau, loaitau });
                if (kq != 0)
                    return true;
                return false;
            }
            catch
            {
                return false;
            }
        }
        public bool editTT(string matau, string loai)
        {
            try
            {
                string sql = "exec  prc_editTT @matau , @loai ";
                int kq = DataProvider.Instance.ExecuteNonQuery(sql, new object[] { matau, loai });
                if (kq != 0)
                    return true;
                return false;
            }
            catch
            {
                return false;
            }
        }
        public DataTable findTTText(string text)
        {
            try
            {
                string sql = "exec prc_findTTText @text ";
                DataTable kq = DataProvider.Instance.ExecuteQuery(sql, new object[] { text });
                return kq;
            }
            catch
            {
                return null;
            }
        }
    }
}
