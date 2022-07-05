using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace receitas.entidades
{
  
    public class State
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Idstate { get; set; }
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string NameState { get; set; }
    }
}
