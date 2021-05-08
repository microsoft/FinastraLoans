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
    public class DisbursementPaymentController : ControllerBase
    {
        private readonly ILogger<DisbursementPaymentController> _logger;
        private readonly IDisbursementPaymentRepository _disbursementPaymentRepository;

        public DisbursementPaymentController(ILogger<DisbursementPaymentController> logger,
            IDisbursementPaymentRepository disbursementPaymentRepository)
        {
            _logger = logger;
            _disbursementPaymentRepository = disbursementPaymentRepository;
        }

        [HttpGet]
        public Task<IEnumerable<DisbursementPayment>> Get(string batchName)
        {
            return _disbursementPaymentRepository.GetDisbursementPaymentByBatch(batchName);
        }
    }
}
