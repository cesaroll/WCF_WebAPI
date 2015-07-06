using System.ServiceModel;

namespace TestService
{
    [ServiceContract]
    public interface IMyService
    {
        [OperationContract]
        string GetData();

        [OperationContract]
        string GetMessage(string Name);

        [OperationContract]
        string GetResult(int sid, string sName, int M1, int M2, int M3);

        [OperationContract]
        int GetMax(int[] ar);

        [OperationContract]
        int[] GetSorted(int[] ar);
    }
}