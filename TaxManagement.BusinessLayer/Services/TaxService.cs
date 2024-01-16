using TaxManagement.BusinessLayer.Interfaces;
using TaxManagement.BusinessLayer.Services.Repository;
using TaxManagement.BusinessLayer.ViewModels;
using TaxManagement.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TaxManagement.BusinessLayer.Services
{
    public class TaxService : ITaxService
    {
        private readonly ITaxRepository _taxRepository;

        public TaxService(ITaxRepository taxRepository)
        {
            _taxRepository = taxRepository;
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