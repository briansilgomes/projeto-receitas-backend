
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace receitas.entidades
{
    public class Difficulty
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Iddifficulty { get; set; }
        
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Namedifficulty { get; set; }
    }
}
