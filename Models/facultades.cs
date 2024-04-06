using System.ComponentModel.DataAnnotations;

namespace L01P022019AC603.Models
{
    public class facultades
    {

        [Key]
        public int id { get; set; }
        public string? facultad { get; set; }

    }
}
