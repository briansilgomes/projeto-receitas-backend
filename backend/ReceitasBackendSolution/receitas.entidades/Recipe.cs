using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace receitas.entidades
{
    public class Recipe
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Idrecipe { get; set; }
        
        public string Namerecipe { get; set; }

        public string Preparationrecipe { get; set; }

        public string Durationrecipe { get; set; }

        public string Imagerecipe { get; set; }
      
        public DateTime Daterecipe { get; set; }


       
        [ForeignKey("Category")]
        public int Idcategory { get; set; }
        //public virtual Category Category { get; set; }

        [ForeignKey("User")]
        public int Iduser { get; set; }
        //public virtual User User { get; set; }

        [ForeignKey("State")]
        public int Idstate { get; set; }
        //public virtual State State { get; set; }

        [ForeignKey("Difficulty")]
        public int Iddifficulty { get; set; }
        //public virtual Difficulty Difficulty { get; set; }


    }
}
