using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace receitas.entidades
{
    
    public class Ingredient
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Idingredient { get; set; }
     
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Nameingredient { get; set; }
    }
}
