using DoAnNET.POJO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnNET.DAO
{
    class NhanVienDAO
    {
        private static NhanVienDAO instance;

        public static NhanVienDAO Ins
        {
            get { if (instance == null) instance = new NhanVienDAO(); return instance; }
            set { instance = value; }
        }

        private NhanVienDAO() { }

        public DataTable hienThiNV()
        {
            try
            {
                string sql = "exec prc_showNV ";
                DataTable kq = DataProvider.Instance.ExecuteQuery(sql);
                return kq;
            }
            catch
            {
                return null;
            }
        }

        public DataTable timNV(string text)
        {
            try
            {
                string sql = "exec prc_findNV @text ";
                DataTable kq = DataProvider.Instance.ExecuteQuery(sql, new object[] { text });             
                return kq;
            }
            catch
            {
                return null;
            }
        }

        public DataTable getLoaiNV()
        {
            try
            {
                string sql = "exec prc_getLoaiNV";
                DataTable kq = DataProvider.Instance.ExecuteQuery(sql);
                DataColumn[] key = new DataColumn[1];
                key[0] = kq.Columns["maloai"];
                kq.PrimaryKey = key;
                return kq;
            }
            catch
            {
                return null;
            }
        }

        public bool addNV(nhanVien nv)
        {
            try
            {
                string sql = "exec prc_addNV @ten , @ngaysinh , @diachi , @mabhxh , @loainv , @cccd";
                int kq = DataProvider.Instance.ExecuteNonQuery(sql, new object[] { nv.hoten, nv.ngaysinh, nv.diachi, nv.mabhxh, nv.maloai, nv.cccd });
                if (kq != 0)
                    return true;
                return false;
            }
            catch
            {
                return false;
            }
        }

        public bool updateNV(nhanVien nv)
        {
            try
            {
                string sql = "exec prc_changeNV @id , @ten , @ngaysinh , @diachi , @mabhxh , @loainv , @cccd";
                int kq = DataProvider.Instance.ExecuteNonQuery(sql, new object[] { nv.id, nv.hoten, nv.ngaysinh, nv.diachi, nv.mabhxh, nv.maloai, nv.cccd });
                if (kq != 0)
                    return true;
                return false;
            }
            catch
            {
                return false;
            }
        }

        public bool deleteNV(nhanVien nv)
        {
            try
            {
                string sql = "exec prc_deleteNV @id";
                int kq = DataProvider.Instance.ExecuteNonQuery(sql, new object[] { nv.id });
                if (kq != 0)
                    return true;
                return false;
            }
            catch
            {
                return false;
            }
        }

        public DataTable getNVbyTau(string ma)
        {
            try
            {
                string sql = "exec prc_showNVbyTT @matau";
                DataTable kq = DataProvider.Instance.ExecuteQuery(sql, new object[] { ma });
                return kq;
            }
            catch
            {
                return null;
            }
        }

        public DataTable getNVFree()
        {
            try
            {
                string sql = "exec prc_getNVFree";
                DataTable kq = DataProvider.Instance.ExecuteQuery(sql);
                return kq;
            }
            catch
            {
                return null;
            }
        }

        public int getNumsTV(string matau)
        {
            try
            {
                string sql = "exec prc_countTV @matau";
                int kq = int.Parse(DataProvider.Instance.ExecuteScalar(sql, new object[]{matau}).ToString());
                return kq;
            }
            catch
            {
                return -1;
            }
        }

        public DataTable getTTFree()
        {
            try
            {
                string sql = "exec prc_getTTFree";
                DataTable kq = DataProvider.Instance.ExecuteQuery(sql);
                return kq;
            }
            catch
            {
                return null;
            }
        }

        public bool updateTTTV(string id, string matau)
        {
            try
            {
                string sql = "exec prc_updateTTNV @manv , @matau ";
                int kq = DataProvider.Instance.ExecuteNonQuery(sql, new object[] { id, matau });
                if (kq != 0)
                    return true;
                return false;
            }
            catch
            {
                return false;
            }
        }
        public bool delMaTauNV(string id)
        {
            try
            {
                string sql = "exec prc_delMaTauNV @id ";
                int kq = DataProvider.Instance.ExecuteNonQuery(sql, new object[] { id });
                if (kq != 0)
                    return true;
                return false;
            }
            catch
            {
                return false;
            }
        }
        public bool delTT(string matau)
        {
            try
            {
                string sql = "exec prc_delTT @matau ";
                int kq = DataProvider.Instance.ExecuteNonQuery(sql, new object[] { matau });
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
