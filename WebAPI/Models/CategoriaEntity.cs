using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class CategoriaEntity
    {
        [Key]
         public int idCategoria { get; set; }
         public string Name { get; set; }

    }
}
