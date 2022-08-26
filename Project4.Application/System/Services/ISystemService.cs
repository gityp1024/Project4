using static Project4.Application.SystemService;

namespace Project4.Application
{
    public interface ISystemService
    {
        string GetDescription();

        Task<TestClass> Test(TestClass dd);
    }
}