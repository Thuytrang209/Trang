using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace Trang.Class
{
    class DatabaseConnect
    {
        private string _User;
        private string _Password;
        private string _Server;
        private string _Database;
        private string _ConnectSqL;
        public string _statusConnect
        {
            get;
            private set;
        }
        public string Erorr
        {
            get;
            private set;
        }



        public DatabaseConnect()
        {
            try
            {
                {
                    this._User = ConfigurationManager.AppSettings.Get("user");
                    this._Password = ConfigurationManager.AppSettings.Get("password");
                    this._Server = ConfigurationManager.AppSettings.Get("serverurl");
                    this._Database = ConfigurationManager.AppSettings.Get("DE");
                    this._ConnectSqL = "user id= " + this._User + ";" +
                                        "password=" + this._Password + ";" +
                                        "server=" + this._Server + ";" +
                                        "Trusted_Connection=yes;" +
                                        "database=" + this._Database + ";" +
                                        "connection timeout = 15";
                    SqlConnection conn = new SqlConnection(this._ConnectSqL);
                    conn.Open();
                }
            }
            catch (Exception e)
            {
                this.Erorr = e.ToString();
            }
        }

    }
}

