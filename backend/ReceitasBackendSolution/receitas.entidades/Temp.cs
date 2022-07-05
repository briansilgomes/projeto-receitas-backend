using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace receitas.entidades
{
    public class Temp
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Idtemp { get; set; }

        [ForeignKey("User")]
        public int Iduser { get; set; }
        //public virtual User User { get; set; }

        [ForeignKey("Ingredient")]
        public int Idingredient { get; set; }
        //public virtual Ingredient Ingredient { get; set; }

        [ForeignKey("Unity")]
        public int Idunity { get; set; }
        //public virtual Unity Unity { get; set; }

        [Column("quantidade")]
        public int quantity { get; set; }

    }
}
