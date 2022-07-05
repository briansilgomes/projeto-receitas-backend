using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace receitas.entidades
{
    public class Permission
    {
        [Key]
        public int Idpermission { get; set; }
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Namepermission { get; set; }
    }
}
