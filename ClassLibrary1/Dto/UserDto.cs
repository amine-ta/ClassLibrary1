using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Dto
{
    public class UserDto
    {
        public int id { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string email { get; set; }
        public string pays { get; set; }
        public string ville { get; set; }
        public string code_postal { get; set; }
    }
}
