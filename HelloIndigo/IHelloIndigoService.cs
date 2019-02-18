using System.ServiceModel;

namespace HelloIndigo
{
    [ServiceContract(Namespace ="http://www.thatindigogirl.com/amples.2006/06")]
    public interface IHelloIndigoService
    {
        [OperationContract]
        string HelloIndigo();
    }
}
