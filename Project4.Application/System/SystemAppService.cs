using static Project4.Application.SystemService;

namespace Project4.Application
{
    /// <summary>
    /// 系统服务接口
    /// </summary>
    public class SystemAppService : IDynamicApiController
    {
        private readonly ISystemService _systemService;

        public SystemAppService(ISystemService systemService)
        {
            _systemService = systemService;
        }

        /// <summary>
        /// 获取系统描述
        /// </summary>
        /// <returns></returns>
        public string GetDescription()
        {
            return _systemService.GetDescription();
        }

        /// <summary>
        /// test
        /// </summary>
        /// <returns></returns>
        public async Task<TestClass> Test(TestClass testClass)
        {
            return await _systemService.Test(testClass);
        }
    }
}