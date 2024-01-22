using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class TypeoplataEntity
    {
        [Key]

        public int idTypeOplata {  get; set; }
        public string Name {  get; set; }
    }
}
