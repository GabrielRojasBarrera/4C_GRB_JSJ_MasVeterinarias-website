﻿using Microsoft.AspNetCore.Http;

namespace MasVeterinarias.Models
{
    public class Servicio
    {
        public int Id { get; set; }
        public int CategoriaId { get; set; }
        public int VeterinariaId { get; set; }
        public string Disponibilidad { get; set; }
        public string Imagen { get; set; }
        public string Detalles { get; set; }
        public double? Precio { get; set; }
        public string Especie { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Raza { get; set; }
        public IFormFile ImageService { get; set; }
    }
}
