using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace receitas.entidades
{
    public class CommentModel
    {
        public int Idcomment { get; set; }
        public string Commentrecipe { get; set; }
        public int Classificationrecipe { get; set; }
        public string Username { get; set; }
        public DateTime Datecomment { get; set; }
        public string Userimage { get; set; }
  
    }
}
