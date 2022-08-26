namespace Project4.Application
{
    public class SystemService : ISystemService, ITransient
    {
        public string GetDescription()
        {
            return "让 .NET 开发更简单，更通用，更流行。";
        }

        public async Task<TestClass> Test(TestClass dd)
        {
            await Task.CompletedTask;
            return dd;
        }

        public class TestClass
        {
            public int dd { get; set; }
        }
    }
}