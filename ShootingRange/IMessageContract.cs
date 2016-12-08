using System.ServiceModel;

namespace WpfApplication1
{
    [ServiceContract]
    interface IMessageContract
    {
        [OperationContract]
        string Say(string s);
    }
}
