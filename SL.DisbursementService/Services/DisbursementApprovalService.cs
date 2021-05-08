using SL.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SL.DisbursementService.Services
{
    public interface IDisbursementApprovalService
    {
        Task<DisbursementBatchApprovalResult> ApproveBatch(string batchName);
        Task<DisbursementBatchApprovalResult> GetBatchApprovalStatus(string batchName);
    }
    public class DisbursementApprovalService : IDisbursementApprovalService
    {
        public Task<DisbursementBatchApprovalResult> ApproveBatch(string batchName)
        {
            return Task.FromResult(new DisbursementBatchApprovalResult());
        }

        public Task<DisbursementBatchApprovalResult> GetBatchApprovalStatus(string batchName)
        {
            return Task.FromResult(new DisbursementBatchApprovalResult());
        }
    }
}
