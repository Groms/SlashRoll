using System.ServiceModel;

namespace SlashRoll.Services.Contracts
{
    [ServiceContract]
    public interface IRoll
    {
        [OperationContract]
        int SlashRoll(string username);

    }
}
