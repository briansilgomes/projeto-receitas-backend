using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace receitas.entidades
{
    public class Highlight
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Idhighlight { get; set; }
        
        [ForeignKey("Recipe")]
        public int Idrecipe { get; set; }
        //public virtual Recipe Recipe { get; set; }

    }
}
