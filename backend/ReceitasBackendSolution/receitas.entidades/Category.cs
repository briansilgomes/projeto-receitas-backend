
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace receitas.entidades
{
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Idcategory { get; set; }
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Namecategory { get; set; }
    }
}
