using LinqToDB.Mapping;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class UserEntity
    {
        [Key]
        public int idUser { get; set; }
        public int idRole { get; set; }
        public string Familia { get; set; }
        public string Name { get; set; }
        public string Otchestvo { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
