using StudioEF.Validaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Windows;

namespace StudioEF.Models
{
    public class Articulos
    {
        [Key]
        [Required(ErrorMessage ="Este campo no puede estar vacio.")]
        [ValidacionId]
        public int ArticuloId { get; set; }

        [Range(minimum: 1, maximum: 200000000,ErrorMessage ="Este campo debe poseer un rango mayor a 0.")]
        [Required(ErrorMessage ="Este campo no puede estar vacio.")]
        public int UsuarioId { get; set; }

        [Required(ErrorMessage ="Este campo no puede estar vacio.")]
        [MinLength(5,ErrorMessage ="Este campo no puede contener menos de 5 caracteres.")]
        [MaxLength(40, ErrorMessage ="Ha alcanzado el maximo de caracteres.")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage ="Este campo no puede estar vacio.")]
        [Range(minimum: 1, maximum:200000000,ErrorMessage ="Este  campo debe poseer un rango mayor a 0.")]
        public int  CategoriaId { get; set; }

        [Required(ErrorMessage ="Este campo no puede estar vacio.")]
        public decimal Stock { get; set; }
        
        [DisplayFormat(DataFormatString = "{0:C}")]
        [ValidacionPrecio]
        public decimal Precio { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        [Required(ErrorMessage ="Este campo no puede estar vacio.")]
        public decimal Costo { get; set; }
       
        [ForeignKey("ArticulosId")]
        public List<ComprasDetalle> ComprasDetalle { get; set; }

        [ForeignKey("ArticulosId")]
        public List<VentasDetalle> VentasDetalle { get; set; }


        public Articulos()
        {
            ArticuloId = 0;
            UsuarioId = 0;
            Descripcion = string.Empty;
            Stock = 0;
            Precio = 0;
            Costo = 0;

            ComprasDetalle = new List<ComprasDetalle>();
            VentasDetalle = new List<VentasDetalle>();
        }
    }
}

