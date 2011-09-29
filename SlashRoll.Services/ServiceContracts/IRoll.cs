using System.ServiceModel;

namespace SlashRoll.Services.ServiceContracts
{
    [ServiceContract]
    public interface IRoll
    {
        [OperationContract]
        int SlashRoll(string username);
    }

}
