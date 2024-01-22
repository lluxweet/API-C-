using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class ProdajaEntity
    {
        [Key]
        public int id { get; set; }
        public int idProduct { get; set; }
        public int idClient { get; set; }
        public int Colichestvo { get; set; }
        public int idStatus { get; set; }
        public int idStatusOplata { get; set; }
        public int idTipOplata { get; set; }

    }
}
