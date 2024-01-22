using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class OrganizaciaEntity
    {
        [Key]
        public int idOrganizacia { get; set; }
        public string Name {  get; set; }
    }
}
