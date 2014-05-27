using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace Trang.Class
{
    class ConnectSQL
    {
        private SqlConnection _con;     
        public ConnectSQL()
        {
            _con = new SqlConnection(@"Server=.\SQLEXPRESS;Database=DE;Integrated Security=SSPI");
           
        }
        public void Myconnect()
        {
            _con.Open();
        }
        public void Myclose()
        {
            _con.Close();
        }
        public DataTable bang(string lenh)
        {
            DataTable table = new DataTable();
            SqlDataAdapter adpat = new SqlDataAdapter(lenh, _con);
            adpat.Fill(table);
            return (table);
        }
    }
}
