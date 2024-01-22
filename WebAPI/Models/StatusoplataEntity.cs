using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class StatusoplataEntity
    {
        [Key]
        public int idStatus { get; set; }
        public string Name {  get; set; }
    }
}
