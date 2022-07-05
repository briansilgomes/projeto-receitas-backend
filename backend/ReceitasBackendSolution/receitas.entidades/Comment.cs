
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace receitas.entidades
{
    public class Comment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Idcomment { get; set; }

        public string Commentrecipe { get; set; }

        public int Classificationrecipe { get; set; }

        public DateTime DateComment { get; set; }

        [ForeignKey("User")]
        public int Iduser { get; set; }
        //public virtual User User { get; set; }

        [ForeignKey("Recipe")]
        public int Idrecipe { get; set; }
        //public virtual Recipe Recipe { get; set; }

    }
}
