using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace receitas.entidades
{
    public class RecipeModel
    {
        public int Idrecipe { get; set; }
        public string Namerecipe { get; set; }
        public string Preparationrecipe { get; set; }
        public string Durationrecipe { get; set; }
        public string Imagerecipe { get; set; }

        public string Categoryname { get; set; }
        public string Nameuser { get; set; }
        public string Namestate { get; set; }
        public string Namedifficulty { get; set; }

        public int favorite { get; set; }
        public DateTime Daterecipe { get; set; }
        public int Highlight { get; set; }

    }
}
