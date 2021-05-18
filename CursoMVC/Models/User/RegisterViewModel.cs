using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CursoMVC.Models.User
{
    public class RegisterViewModel
    {
        [Required]
        [RegularExpression(@"^[a-zA-Z\s]+$",ErrorMessage ="El nombre solo debe contener letras")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El Nombre debe ser igresado en esta aplicacion")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "El apellido solo debe contener letras")]
        public string Apellido { get; set; }

        [Required]
        [RegularExpression("^[0-9]*$", ErrorMessage = "La cedula solo debe contener numeros")]
        public string Cedula { get; set; }

        [Required]
        [EmailAddress(ErrorMessage ="Formato de correo invalido")]
        public string Email { get; set; }

        [Required]
        [Display(Name ="Contraseña")]
        [DataType(DataType.Password)]
        [MinLength(5,ErrorMessage ="Minimo 5 caracteres")]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Confirmar Contraseña")]
        [DataType(DataType.Password)]
        [MinLength(5, ErrorMessage = "Minimo 5 caracteres")]
        [Compare("Password",ErrorMessage ="Las contraseñas deben ser iguales")]
        public string PasswordConfirm { get; set; }
    }
}