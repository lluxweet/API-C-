using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class ProductEntity
    {
        [Key]
        public int idProduct { get; set; }
        public int Partia {  get; set; }
        public string Name {  get; set; }
        public int idСategory {  get; set; }
        public int idRazreshenie { get; set; }       
        public int Price { get; set; }
        public DateTime? Date_delete {  get; set; }
    }
}
