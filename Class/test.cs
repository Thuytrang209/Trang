using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace Trang.Class
{
    class test
    {
        /**
         * Name
         * 
         * Full name student
         * 
         * @access public
         * @Name string
         **/
        private string _name;
        public string Name
        {
            get
            {return this._name;}
            set
            {this._name = value;}
        }

        /**
         * ID
         * 
         * MSSV Student
         * 
         * @access public
         * @ID int
        **/
        private int _Id;
        public int Id
        {
            get
            { return this._Id; }
            set
            { this._Id = value; }
        }

        /**
         * Birthday
         * 
         * Data time born
         * 
         * @access public
         * @Birthday datetime
         * **/

        private DateTime _Birthday;
        public DateTime Birthday
        { get; set; }

        /**
         * password
         * 
         * Password to login system
         * 
         * @access public
         * @Password string
         **/

        private string _Pass;
        public string pass
        {
            get
            { return this._Pass; }
            set
            {
                HashAlgorithm hassword = new MD5CryptoServiceProvider();
                byte[] hassbyte = hassword.ComputeHash(Encoding.UTF8.GetBytes(value));
                this._Pass = Convert.ToBase64String(hassbyte);
            }
        }

        /**
         * khởi tạo
         * */

        public test(string name, int Id, string pass)
        {
            this.Name = name;
            this.Id = Id;
           
            this.pass = pass;
        }
    }
}
