using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StudioEF.Models
{
   public class Eventos
    {
        [Key]
        [Required(ErrorMessage ="Este campo no puede estar vacio.")]
        public int EventoId { get; set; }

        [Required(ErrorMessage = "Este campo no puede estar vacio.")]
        public int UsuarioId { get; set; }

        [Required(ErrorMessage = "Este campo no puede estar vacio.")]
        public int FotografoId { get; set; }

        [Required(ErrorMessage = "Este campo no puede estar vacio.")]
        [MinLength(4,ErrorMessage ="Este campo no puede tener menos de 3 caracteres.")]
        [MaxLength(30,ErrorMessage ="Ha alcanzado el maximo de caracteres.")]
        [DisplayFormat(ConvertEmptyStringToNull = true, NullDisplayText = "Ingrese una descripcion.")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "Este campo no puede estar vacio.")]
        public string Lugar { get; set; }

        [Required(ErrorMessage = "Este campo no puede estar vacio.")]
        public DateTime FechaInicio { get; set; }

        [Required(ErrorMessage = "Este campo no puede estar vacio.")]
        public DateTime FechaFin { get; set; }

        [Required(ErrorMessage = "Este campo no puede estar vacio.")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal Precio { get; set; }

        [Required(ErrorMessage = "Este campo no puede estar vacio.")]
        public string Disponible { get; set; }

        [ForeignKey("EventoId")]
        public List<VentasDetalle> VentasDetalle { get; set; }

        public Eventos()
        {
            EventoId = 0;
            UsuarioId = 0;
            Descripcion = string.Empty;
            Lugar = string.Empty;
            FechaInicio = DateTime.Now;
            FechaFin = DateTime.Now;
            Precio = 0;
            Disponible = string.Empty;

            VentasDetalle = new List<VentasDetalle>();
        }
    }
}
