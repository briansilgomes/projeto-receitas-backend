using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace receitas.entidades
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Iduser { get; set; }

        [Column(TypeName = "varchar")]
        [MaxLength(100)]
        public string Nameuser { get; set; }

        [Column(TypeName = "varchar")]
        [MaxLength(100)]
        public string Emailuser { get; set; }

        [Column(TypeName = "varchar")]
        [MaxLength(100)]
        public string Passworduser { get; set; }

        [Column(TypeName = "varchar")]
        [MaxLength(100)]
        public string Userimage { get; set; }

        [ForeignKey("State")]
        public int Idstate { get; set; }
        public virtual State State { get; set; }

        [ForeignKey("Permission")]
        public int Idpermission { get; set; }
        public virtual Permission Permission { get; set; }
    }
}