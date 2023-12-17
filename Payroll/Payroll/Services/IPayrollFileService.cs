using Payroll.Domain;

namespace Payroll.Services
{
    public interface IPayrollFileService
    {
        IEnumerable<Payslip> GeneratePayslips(IFormFile file);
        void Create(string fileName, IEnumerable<Payslip> payslips);
        IEnumerable<Payslip> Read(string fileName);
        void Save(string fileName);
        void Delete(string fileName);
        void Run(string fileName);
    }
}
