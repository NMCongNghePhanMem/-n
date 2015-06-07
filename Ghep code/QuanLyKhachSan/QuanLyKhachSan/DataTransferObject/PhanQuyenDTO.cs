using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class PhanQuyenDTO
    {
        public string UserName { get; set; }

        public string Password { get; set; }

        public string Role { get; set; }

        public PhanQuyenDTO()
        { 
        }

        public PhanQuyenDTO(string _userName, string _password, string role)
        {
            UserName = _userName;
            Password = _password;
            Role = role;
        }
    }
}
