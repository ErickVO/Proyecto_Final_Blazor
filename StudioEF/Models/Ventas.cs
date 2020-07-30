using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StudioEF.Models
{
    public class Ventas
    {
        [Key]
        [Required(ErrorMessage = "Este campo no puede estar vacio.")]
        public int VentaId { get; set; }

        [Required(ErrorMessage = "Este campo no puede estar vacio.")]
        public int ClienteId { get; set; }

        [Required(ErrorMessage = "Este campo no puede estar vacio.")]
        [MinLength(3, ErrorMessage = "Este campo no puede tener menos de 3 caracteres.")]
        [MaxLength(30, ErrorMessage = "Ha alcanzado el maximo de caracteres.")]
        public string Nombres { get; set; }

        [Required(ErrorMessage = "Este campo no puede estar vacio.")]
        [MinLength(3, ErrorMessage = "Este campo no puede tener menos de 3 caracteres.")]
        [MaxLength(30, ErrorMessage = "Ha alcanzado el maximo de caracteres.")]
        public string Apellidos { get; set; }

        [Required(ErrorMessage = "Este campo no puede estar vacio.")]
        public DateTime Fecha { get; set; }

        [Required(ErrorMessage = "Este campo no puede estar vacio.")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal Total { get; set; }

        [ForeignKey("VentaId")]
        public List<VentasDetalle> VentasDetalle { get; set; }

        public Ventas()
        {
            VentaId = 0;
            ClienteId = 0;
            Nombres = string.Empty;
            Apellidos = string.Empty;
            Fecha = DateTime.Now;
            Total = 0.0m;
            VentasDetalle = new List<VentasDetalle>();
        }

        public Ventas(int ventaId, int clienteId, string nombre, string apellido, DateTime fecha, decimal total, List<VentasDetalle> ventasDetalle)
        {
            VentaId = ventaId;
            ClienteId = clienteId;
            Nombres = nombre;
            Apellidos = apellido;
            Fecha = fecha;
            Total = total;
            VentasDetalle = ventasDetalle;
        }
    }
}
