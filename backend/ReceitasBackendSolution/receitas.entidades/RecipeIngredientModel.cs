using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace receitas.entidades
{
    public class RecipeIngredientModel
    {
        public int Idingredientrecipe { get; set; }
        public int Quantityingredient { get; set; }

        public string Nameingredient { get; set; }
        public string Nameunity { get; set; }
        public string Siglaunity { get; set; }

    }
}
