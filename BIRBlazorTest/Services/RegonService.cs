using BIRBlazorTest.Models;
using BIRService;

namespace BIRBlazorTest.Services
{
    public class RegonService
    {
        IBIRSearchService _birSearchService;

        public RegonService(IBIRSearchService birSearchService)
        {
            _birSearchService = birSearchService;
        }

        public async Task<CompanyWebModel> GetCompanyDataByNipAsync(string vatId)
        {
            var search = await _birSearchService.GetCompanyDataByNipIdAsync(vatId);

            var separator = string.IsNullOrEmpty(search.NrLokalu) ? string.Empty : "/";

            CompanyWebModel model = new CompanyWebModel
            {
                Name = search.Nazwa,
                Vat = search.Nip,
                Address = $"{search.Ulica} {search.NrNieruchomosci}{separator}{search.NrLokalu} {search.KodPocztowy} {search.Miejscowosc}",
                Regon = search.Regon,
                Errors = search.Errors,
            };
            return model;
        }

        public async Task<CompanyWebModel> GetCompanyDataByRegonAsync(string regonId)
        {
            var search = await _birSearchService.GetCompanyDataByRegonAsync(regonId);

            var separator = string.IsNullOrEmpty(search.NrLokalu) ? string.Empty : "/";

            CompanyWebModel model = new CompanyWebModel
            {
                Name = search.Nazwa,
                Vat = search.Nip,
                Address = $"{search.Ulica} {search.NrNieruchomosci}{separator}{search.NrLokalu} {search.KodPocztowy} {search.Miejscowosc}",
                Regon = search.Regon,
                Errors = search.Errors,
            };
            return model;
        }
    }
}
