using System.ServiceModel;

namespace WCFServices.ServiceContracts
{
    [ServiceContract]
    public interface IEmployeeService
    {
        [OperationContract]
        int GetEmployeeCount();
    }
}