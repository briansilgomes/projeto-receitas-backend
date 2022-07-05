using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace receitas.entidades
{
    public class UserModel
    {
        public int Iduser { get; set; }
        public string Nameuser { get; set; }
        public string Emailuser { get; set; }
        public string Imageuser { get; set; }
        public string State { get; set; }
        public string Permission { get; set; }
    }
}
