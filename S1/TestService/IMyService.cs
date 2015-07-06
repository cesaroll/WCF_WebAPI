using System.Collections.Generic;
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
        string GetResult(Student student);

        [OperationContract]
        int GetMax(int[] ar);

        [OperationContract]
        int[] GetSorted(int[] ar);

        [OperationContract]
        Student GetTopper(ICollection<Student> Students );

        [OperationContract]
        List<Country> GetAllCountries();
    }
}