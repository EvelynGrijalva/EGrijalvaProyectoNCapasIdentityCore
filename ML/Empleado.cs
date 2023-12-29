using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ML
{
    public class Empleado
    {
        public string? NumeroEmpleado { get; set; } = null!;
        [Required]
        [StringLength(20, ErrorMessage = "Longitud No Aceptada")]
        [DisplayName("Rfc:")]
        [RegularExpression(@"^(?=.*[a-zA-Z])(?=.*[0-9])[a-zA-Z0-9]+$", ErrorMessage = "Usar Letras y Números SIN Espacios")]
        public string? Rfc { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Longitud No Aceptada")]
        [DisplayName("Nombre:")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Usar Sólo Letras")]
        public string? Nombre { get; set; } = null!;
        [Required]
        [StringLength(50, ErrorMessage = "Longitud No Aceptada")]
        [DisplayName("ApellidoPaterno:")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Usar Sólo Letras sin Espacios")]
        public string? ApellidoPaterno { get; set; } = null!;
        [Required]
        [StringLength(50, ErrorMessage = "Longitud No Aceptada")]
        [DisplayName("ApellidoMaterno:")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Usar Sólo Letras sin Espacios")]
        public string? ApellidoMaterno { get; set; } = null!;
        [Required]
        [StringLength(20, ErrorMessage = "Longitud No Aceptada")]
        [DisplayName("Email:")]
        [RegularExpression(@"\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,]\b", ErrorMessage = "Usar Sólo Letras sin Espacios")]
        public string? Email { get; set; } = null!;
        [Required]
        [StringLength(10, ErrorMessage = "Longitud No Aceptada")]
        [DisplayName("Telefono:")]
        [RegularExpression(@"^(55|56)\d{8}$", ErrorMessage = "Sólo Números de Teléfono de MX")]
        public string? Telefono { get; set; } = null!;
        [Required]
        [StringLength(10, ErrorMessage = "Longitud No Aceptada")]
        [DisplayName("FechaNacimiento:")]
        [RegularExpression("^(0[1-9]|[12][0-9]|3[01])/(0[1-9]|1[0-2])/(19\\d{2}|200[0-3])$", ErrorMessage = "Fecha Invalida (DD/MM/AAAA)")]
        public DateTime? FechaNacimiento { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "Longitud No Aceptada")]
        [DisplayName("Nss:")]
        [RegularExpression(@"^(?=.*[a-zA-Z])(?=.*[0-9])[a-zA-Z0-9]+$", ErrorMessage = "Usar Letras y Números SIN Espacios")]
        public string? Nss { get; set; }
        [Required]
        [StringLength(10, ErrorMessage = "Longitud No Aceptada")]
        [DisplayName("FechaNacimiento:")]
        [RegularExpression("^(0[1-9]|[12][0-9]|3[01])/(0[1-9]|1[0-2])/(19\\d{2}|200[0-3])$", ErrorMessage = "Fecha Invalida (DD/MM/AAAA)")]
        public DateTime? FechaIngreso { get; set; }

        public byte[]? Foto { get; set; }

        public string? IdEmpresa { get; set; }
        public List<object> Empleados { get; set; }
    }
}