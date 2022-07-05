
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace receitas.entidades
{
    public class RecipeIngredient
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Idingredientrecipe { get; set; }
       
        public int Quantityingredient { get; set; }

        [ForeignKey("Ingredient")]
        public int Idingredient { get; set; }
        //public virtual Ingredient Ingredient { get; set; }

        [ForeignKey("Unity")]
        public int Idunity { get; set; }
        //public virtual Unity Unity { get; set; }

        [ForeignKey("Recipe")]
        public int Idrecipe { get; set; }
        //public virtual Recipe Recipe { get; set; }
    }
}
