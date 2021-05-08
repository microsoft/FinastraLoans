using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SL.DisbursementService.Services;
using SL.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SL.DisbursementService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DisbursementApprovalController : ControllerBase
    {
        private readonly ILogger<DisbursementApprovalController> _logger;
        private readonly IDisbursementApprovalService _disbursementApprovalService;

        public DisbursementApprovalController(ILogger<DisbursementApprovalController> logger, 
            IDisbursementApprovalService disbursementApprovalService)
        {
            _logger = logger;
            _disbursementApprovalService = disbursementApprovalService;
        }

        [HttpGet]
        public Task<DisbursementBatchApprovalResult> Get(string batchName)
        {
            return _disbursementApprovalService.GetBatchApprovalStatus(batchName);
        }

        [HttpPut]
        public Task<DisbursementBatchApprovalResult> Put(string batchName)
        {
            return _disbursementApprovalService.ApproveBatch(batchName);
        }
    }
}
