using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class ClientEntity
    {
        [Key]
        public int idClient { get; set; }
        public string Familia { get; set; }
        public string Name {  get; set; }
        public string Otchestvo {  get; set; }
        public int idOrganizacia { get; set;}
        public int idPredprinimatel { get; set; }
        public string Phone {  get; set; }
        public string Passport { get; set; }
    }
}
