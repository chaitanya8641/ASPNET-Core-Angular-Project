using Users.Models;
using Users.ViewModels;

namespace Users.Repositories.Interfaces
{
    public interface IUserDetailsRepository
    {
        Task<IEnumerable<GetUserDetailsViewModel>> GetAllUsersDetailsAsync();
        Task<UserDetail> UpdateUserActivestatus(Guid userDetailsId, bool userActiveStatus);
    }
}
