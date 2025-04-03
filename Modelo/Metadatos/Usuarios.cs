﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Modelos
{
    [MetadataType(typeof(UsuariosMetadato))]
    public partial class Usuarios
    {
    }

    public class UsuariosMetadato
    {
        [Required]
        [StringLength(20)]
        public string Cedula { get; set; }
        [Required]
        [StringLength(50)]
        public string PrimerNombre { get; set; }
        [StringLength(50)]
        public string SegundoNombre { get; set; }
        [Required]
        [StringLength(50)]
        public string PrimerApellido { get; set; }
        [StringLength(50)]
        public string SegundoApellido { get; set; }
        [Required]
        public System.DateTime FechaNacimiento { get; set; }
        [Required]
        public long IdRol { get; set; }
        [Required]
        public long IdTipoDocumento { get; set; }
        [Required]
        [StringLength(20)]
        public string NombreUsuario { get; set; }
        [Required]
        [StringLength(50)]
        public string Contrasenia { get; set; }
    }

}
