using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ExParcial.Models
{
    public class Jugador
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Nombres son obligatorios.")]
        public string? nombre { get; set; }
        
        public string? edad { get; set;}
        
        public string? Correo { get; set;}
        
        public string? nacionalidad { get; set;}

        public string? dni { get; set; }
    }
}