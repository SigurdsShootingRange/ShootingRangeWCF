using System.ServiceModel;

namespace ShootingRange
{
    [ServiceContract]
    interface IMessageContract
    {
        [OperationContract]
        string Say(string s);
    }
}
