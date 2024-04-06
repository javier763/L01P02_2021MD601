using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace L01P022019AC603.Models
{
    public class departamentos
    {

        [Key]
        public int id { get; set; }
        public string? departamento { get; set; }

    }
}
