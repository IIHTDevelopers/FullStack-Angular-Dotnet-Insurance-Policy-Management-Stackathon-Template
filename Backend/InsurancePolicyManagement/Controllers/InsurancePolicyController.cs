using InsurancePolicyManagement.BusinessLayer.Interfaces;
using InsurancePolicyManagement.BusinessLayer.ViewModels;
using InsurancePolicyManagement.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace InsurancePolicyManagement.Controllers
{
    [ApiController]
    public class InsurancePolicyController : ControllerBase
    {
        private readonly IInsurancePolicyService _insurancePolicyService;
        public InsurancePolicyController(IInsurancePolicyService insurancePolicyService)
        {
            _insurancePolicyService = insurancePolicyService;
        }

        [HttpPost]
        [Route("create-policy")]
        [AllowAnonymous]
        public async Task<IActionResult> CreateInsurancePolicy([FromBody] InsurancePolicy model)
        {
            //write your code here
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("get-all-policies")]
        public async Task<IEnumerable<InsurancePolicy>> GetAllPolicies()
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}
