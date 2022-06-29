
using System.ComponentModel.DataAnnotations;

namespace BIRBlazorTest.Models
{
    public class CompanyModel
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Display(Name = "Nazwa firmy")]
        public string Name { get; set; }

        [Display(Name = "Adres firmy")]
        public string Address { get; set; }

        [Display(Name = "Nr Nip")]
        public string Vat { get; set; }

        [Display(Name = "Nr Regon")]
        public string Regon { get; set; }
    }
}
