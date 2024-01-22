using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class StatusEntity
    {
        [Key]
        public int idstatus { get; set; }
        public string Name { get; set; }
    }
}
