using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace receitas.entidades
{
    public class Unity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Idunity { get; set; }
        [Column(TypeName ="varchar")]
        [MaxLength(50)]
        public string Nameunity { get; set; }
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Siglaunity { get; set; }
    }
}
