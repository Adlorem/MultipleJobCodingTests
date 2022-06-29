using BIRBlazorTest.Models;
using MFApiService.Api;
using System.Net;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace BIRBlazorTest.Services
{
    public class RegonService
    {
        IDefaultApi _birSearchService;

        public RegonService(IDefaultApi birSearchService)
        {
            _birSearchService = birSearchService;
        }

        public async Task<CompanyModel> GetCompanyDataByNipAsync(string vatId)
        {
            var search = await _birSearchService.NipdateAsync(vatId, DateTime.Now);
            CompanyModel model = new CompanyModel();

            if (search != null && search.Result.Subject != null)
{
                var item = search.Result.Subject;

                model.Name = item.Name;
                model.Vat = item.Nip;
                model.Address = item.WorkingAddress != null ? item.WorkingAddress : item.ResidenceAddress;
                model.Regon = item.Regon;
            }
            return model;
        }

        public async Task<CompanyModel> GetCompanyDataByRegonAsync(string regonId)
        {
            var search = await _birSearchService.RegondateAsync(regonId, DateTime.Now);
            CompanyModel model = new CompanyModel();

            if (search != null && search.Result.Subject != null)
            {
                var item = search.Result.Subject;

                model.Name = item.Name;
                model.Vat = item.Nip;
                model.Address = item.WorkingAddress != null ? item.WorkingAddress : item.ResidenceAddress;
                model.Regon = item.Regon;
            }
            return model;
        }


    }
}
