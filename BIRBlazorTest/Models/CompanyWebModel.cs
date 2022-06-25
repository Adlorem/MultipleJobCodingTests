

using BIRService.Models;

namespace BIRBlazorTest.Models
{
    public class CompanyWebModel : CompanyModel
    {
        public List<ErrorModel> Errors { get; set; } = new List<ErrorModel>();
    }
}
