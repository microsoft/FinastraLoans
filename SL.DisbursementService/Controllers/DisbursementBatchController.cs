using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SL.DisbursementService.Services;
using SL.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SL.DisbursementService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DisbursementBatchController : ControllerBase
    {
        private readonly ILogger<DisbursementBatchController> _logger;
        private readonly IDisbursementBatchRepository _disbursementBatchRepository;

        public DisbursementBatchController(ILogger<DisbursementBatchController> logger, 
            IDisbursementBatchRepository disbursementBatchRepository)
        {
            _logger = logger;
            _disbursementBatchRepository = disbursementBatchRepository;
        }

        [HttpGet]
        public Task<DisbursementBatch> Get()
        {
            return _disbursementBatchRepository.GetDisbursementBatch();
        }
    }
}
