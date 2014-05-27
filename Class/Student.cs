using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace Trang.Class
{
    class Student
    {
        /**
         * Name student
         * full name student
         * student public
         * Name string
         **/
        private string _name;
        public string Name
            {
            get
            {
                return this._name;
            }
        set 
            {
                this._name = value;
            }
        }

        /**
         * ID
         * 
         * ID student
         * @acess public
         * @ID int
        **/
        private int _ID;
        public int ID { get; set; }
        
        /**
         * Password
         * 
         * password to login in system
         * @acees public
         * @Password string
         **/

        private string _password;
        public string Password
        {
            get
            {
                return this._password;
            }
            set
            {
                HashAlgorithm hassword = new MD5CryptoServiceProvider();
                byte[] hassbyte = hassword.ComputeHash(Encoding.UTF8.GetBytes(value));
                this._password = Convert.ToBase64String(hassbyte);
            }
        }
        /**
         * khởi tạo
         * 
         **/

        public Student(string Name, int ID, string password)
        {
            this.Name = Name;
            this.ID = ID;
            this.Password = password;

        }

    }
}
