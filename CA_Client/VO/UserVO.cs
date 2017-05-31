using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CA_Client.VO
{
    class UserVO
    {
        private int UserId;
        private string UserName;
        private string PassWord;
        private string Email;
        private string Phone;

        /// <constructor>
        /// Constructor UserVO
        /// </constructor>
        public UserVO(string username, string pass, string email, string phone)
        {
            //
            // TODO: Add constructor logic here
            //
            this.UserName1 = username;
            this.PassWord1 = pass;
            this.Email1 = email;
            this.Phone1 = phone;
        }
        public UserVO()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public int UserId1 { get => UserId; set => UserId = value; }
        public string UserName1 { get => UserName; set => UserName = value; }
        public string PassWord1
        {
            get
            {
                return PassWord;
            }

            set
            {
                byte[] hashPass;
                HashAlgorithm algorithm = MD5.Create();
                hashPass = algorithm.ComputeHash(Encoding.UTF8.GetBytes(value));
                PassWord = BitConverter.ToString(hashPass).Replace("-", "").ToLower();
            }
        }
        public string Email1 { get => Email; set => Email = value; }
        public string Phone1 { get => Phone; set => Phone = value; }
    }
}

