using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class PredprinimatelEntity
    {
        [Key]
        public int idPredprinimatel { get; set; }
        public string Name {  get; set; }
    }
}
