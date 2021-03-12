using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PracticaASPCRUD1.Models.Entities
{
    public class Empleado
        //TABLA//
    {
        //prop//
        //Llave primaria//

       //Indicando que es una llave >>>>//
       [Key]
        public string EmpleadoId { get; set; }

        
        [Column ("Nombre Del Empleado", TypeName = "nvarchar (30)")]
        //Requerido>>//
        [Required(ErrorMessage ="Este campo se debe llenar obligatoriamente.")]
        public string Nombre { get; set; }



        public string Documento { get; set; }



        public int CargoId { get; set; }



        public int Telefono { get; set; }
    }

   
}

