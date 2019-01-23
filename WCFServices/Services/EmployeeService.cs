using WCFServices.ServiceContracts;

namespace WCFServices.Services
{
    public class EmployeeService : IEmployeeService
    {
        public int GetEmployeeCount()
        {
            return 10;
        }
    }
}