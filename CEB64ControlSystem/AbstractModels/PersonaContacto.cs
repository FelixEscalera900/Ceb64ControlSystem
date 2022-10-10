using System.ComponentModel.DataAnnotations;

namespace CEB64ControlSystem.AbstractModels
{
    public class PersonaContacto
    {
        [Display(Name = "Nombre")]
        public string Name { get; set; }
        [Display(Name = "Apellido Paterno")]
        public string ApellidoPaterno { get; set; }
        [Display(Name = "Apellido Materno")]
        public string ApellidoMaterno { get; set; }
        [Display(Name = "Dirección")]
        public string Direccion { get; set; }
        [Display(Name = "Número Telefónico")]
        public string NumeroTelefonico { get; set; }
        [Display(Name = "Correo")]
        public string Mail;

    }
}
