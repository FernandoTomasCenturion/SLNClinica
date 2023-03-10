using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLNClinica.Models
{
    [Table("Habitaciones")]
    public class Habitacion
    {
        public int Id { get; set; }
        
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Numero { get; set; }
       
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [Required]
        public string Estado { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(80)]
        public string Descripcion { get; set; }
    }
}
