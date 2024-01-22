using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class RazreshenieEntity
    {
        [Key]
        public int idRazreshenie {  get; set; }
        public string Name {  get; set; }
    }
}
