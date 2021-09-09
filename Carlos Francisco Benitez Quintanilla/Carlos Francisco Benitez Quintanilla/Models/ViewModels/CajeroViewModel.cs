using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Carlos_Francisco_Benitez_Quintanilla.Models.ViewModels
{
    public class CajeroViewModel
    {
        [Display(Name = "Monto")]
        [Required(ErrorMessage = "Este campo es requerido")]
        public String Monto { get; set; }
    }
}