using Users.Models;
using Users.ViewModels;

namespace Users.Services.Interfaces
{
    public interface IUserDetailsService
    {
        Task<IEnumerable<GetUserDetailsViewModel>> GetAllUsersDetailsAsync();
        Task<UserDetail> UpdateUserActivestatus(Guid userDetailsId, bool userActiveStatus);
    }
}
