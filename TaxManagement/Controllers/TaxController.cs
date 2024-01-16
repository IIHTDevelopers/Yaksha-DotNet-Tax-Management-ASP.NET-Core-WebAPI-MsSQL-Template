using TaxManagement.BusinessLayer.Interfaces;
using TaxManagement.BusinessLayer.ViewModels;
using TaxManagement.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace TaxManagement.Controllers
{
    [ApiController]
    public class TaxController : ControllerBase
    {
        private readonly ITaxService _taxService;
        public TaxController(ITaxService taxService)
        {
            _taxService = taxService;
        }

        [HttpPost]
        [Route("create-tax")]
        [AllowAnonymous]
        public async Task<IActionResult> CreateTax([FromBody] Tax model)
        {
            //write your code here
            throw new NotImplementedException();
        }


        [HttpPut]
        [Route("update-tax")]
        public async Task<IActionResult> UpdateTax([FromBody] TaxViewModel model)
        {
            //write your code here
            throw new NotImplementedException();
        }

        [HttpDelete]
        [Route("delete-Tax")]
        public async Task<IActionResult> DeleteTax(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }


        [HttpGet]
        [Route("get-Tax-by-id")]
        public async Task<IActionResult> GetTaxById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("get-all-taxes")]
        public async Task<IEnumerable<Tax>> GetAllTaxes()
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}