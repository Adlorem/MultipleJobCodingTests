using BIRBlazorTest.DBContext;
using BIRBlazorTest.Models;
using BIRService.Models;
using Microsoft.EntityFrameworkCore;

namespace BIRBlazorTest.Services
{
    public interface ICompanyServices
    {
        /// <summary>
        /// Adds company do DB
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task AddCompanyAsync(CompanyModel model);
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<CompanyModel>> GetCompaniesAsync();
    }

    public class CompanyServices : ICompanyServices
    {

        private readonly CompanyDBContext _dbContext;

        public CompanyServices(CompanyDBContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task<IEnumerable<CompanyModel>> GetCompaniesAsync()
        {
            return await _dbContext.Company.ToListAsync();
        }

        public async Task AddCompanyAsync(CompanyModel model)
        {
            _dbContext.Company.Add(model);
            await _dbContext.SaveChangesAsync();
        }
    }
}
