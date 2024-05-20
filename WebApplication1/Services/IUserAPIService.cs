using DemoWebApiApps.ViewModels;

namespace DemoWebApiApps.Services
{
    public interface IUserAPIService
    {
        Task<IEnumerable<UserRequestModel>> GetAllUserList();
    }
}
