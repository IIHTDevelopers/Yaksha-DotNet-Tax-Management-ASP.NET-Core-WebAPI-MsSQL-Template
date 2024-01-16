using TaxManagement.BusinessLayer.ViewModels;
using TaxManagement.DataLayer;
using TaxManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxManagement.BusinessLayer.Services.Repository
{
    public class TaxRepository : ITaxRepository
    {
        private readonly TaxDbContext _dbContext;
        public TaxRepository(TaxDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Tax> CreateTax(Tax tax)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteTaxById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public List<Tax> GetAllTaxes()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public async Task<Tax> GetTaxById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }
        public async Task<Tax> UpdateTax(TaxViewModel model)
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}