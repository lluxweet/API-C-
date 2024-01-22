using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class RoleEntity
    {
        [Key]
        public int idRole { get; set; }
        public string NameRole { get; set; }
    }
}
