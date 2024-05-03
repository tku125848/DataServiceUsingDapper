using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class ISO3166
    {
        public string FdOpnLstId { get; set; }
        [Key]
        public string Value { get; set; }
        public string Text { get; set; }
        public string OrdBy { get; set; }
        public string EnText { get; set; }
    }
}
