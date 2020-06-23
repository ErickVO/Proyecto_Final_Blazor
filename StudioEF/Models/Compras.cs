using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StudioEF.Models
{
    public class Compras
    {
        [Key]
        [Required(ErrorMessage = "Este campo no puede estar vacio.")]
        public int CompraId { get; set; }

        [Required(ErrorMessage = "Este campo no puede estar vacio.")]
        [Range(minimum: 1, maximum: 200000000, ErrorMessage = "Este campo debe poseer un rango mayor a 0.")]
        public int UsuarioId { get; set; }

        [Required(ErrorMessage = "Este campo no puede estar vacio.")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal Monto { get; set; }

        [Required(ErrorMessage = "Este campo no puede estar vacio.")]
        [DataType(DataType.DateTime)]
        public DateTime Fecha { get; set; }

        [ForeignKey("ComprasId")]
        public List<ComprasDetalle> ComprasDetalle { get; set; }

        public Compras()
        {
            CompraId = 0;
            UsuarioId = 0;
            Monto = 0;
            Fecha = DateTime.Now;

            ComprasDetalle = new List<ComprasDetalle>();
        }
    }
}
