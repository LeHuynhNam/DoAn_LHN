using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DoAnNET.DAO
{
    class loadDataSet
    {
        SqlConnection con = new SqlConnection("Data Source=NGCHIUTRNC995;Initial Catalog=QLTAU;User ID=sa; Password=123");
        DataSet dt = new DataSet();
        public loadDataSet()
        {
            loadTK();
            loadNhanVien();
            loadTauThuyen();
        }
        public void loadTK()
        {
            string sql = "select * from taiKhoan";
            SqlDataAdapter adt = new SqlDataAdapter(sql, con);
            adt.Fill(dt, "taiKhoan");
            DataColumn[] key = new DataColumn[1];
            key[0] = dt.Tables["taiKhoan"].Columns["tendangnhap"];
            dt.Tables["taiKhoan"].PrimaryKey = key;
        }
        public DataTable getTaiKhoan()
        {
            return dt.Tables["taiKhoan"];
        }
        public void loadNhanVien()
        {
            string sql = "select * from nhanvien";
            SqlDataAdapter adt = new SqlDataAdapter(sql, con);
            adt.Fill(dt, "nhanVien");
            DataColumn[] key = new DataColumn[1];
            key[0] = dt.Tables["nhanVien"].Columns["id"];
            dt.Tables["nhanVien"].PrimaryKey = key;
        }
        public DataTable getNhanVien()
        {
            return dt.Tables["nhanVien"];
        }
        public void loadTauThuyen()
        {
            string sql = "select * from tauthuyen";
            SqlDataAdapter adt = new SqlDataAdapter(sql, con);
            adt.Fill(dt, "tauThuyen");
            DataColumn[] key = new DataColumn[1];
            key[0] = dt.Tables["tauThuyen"].Columns["matau"];
            dt.Tables["tauThuyen"].PrimaryKey = key;
        }
        public DataTable getTauThuyen()
        {
            return dt.Tables["tauThuyen"];
        }
    }
}
