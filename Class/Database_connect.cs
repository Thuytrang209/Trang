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
        private string _user;
        private string _password;
        private string _servel;
        private string _database;
        private string _conncectionString;
        public string statusConnect
        {
            get;
            //khai báo 1 biến, chỉ có bên class mới có thể thiết lập được biến này, 
            private set;
        }
        public string Error
        {
            get;
            private set;
        }
        public DatabaseConnect()
        {
            try
            {
                /**
                 * lấy chức năng bên app qua
                 **/
                this._user = ConfigurationManager.AppSettings.Get("user");
                this._password = ConfigurationManager.AppSettings.Get("password");
                this._servel = ConfigurationManager.AppSettings.Get("serverurl");
                this._database = ConfigurationManager.AppSettings.Get("DE");
                this._conncectionString = "user id=" + this._user + ";" +
                                          "password =" + this._password + ";" +
                                          "server=" + this._servel + ";" +
                                          "Trusted_Connection=no;" +
                                          "database=" + this._database + ";" +
                                          "connection timeout = 30";
                SqlConnection conn_ = new SqlConnection(this._conncectionString);
                conn_.Open();
                this.statusConnect = conn_.State.ToString();
            }
            catch (Exception e)
            {
                // lỗi đưa vào biến error
                this.Error = e.ToString();
            }

    }
}
}

