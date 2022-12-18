using Users.Models;
using Users.Repositories.Interfaces;
using Users.Services.Interfaces;
using Users.ViewModels;

namespace Users.Services
{
    public class UserDetailsService : IUserDetailsService
    {

        private readonly IUserDetailsRepository _userDetailsRepository;

        public UserDetailsService(IUserDetailsRepository userDetailsRepository)
        {
            _userDetailsRepository = userDetailsRepository;
        }

        public async Task<IEnumerable<GetUserDetailsViewModel>> GetAllUsersDetailsAsync()
        {
            return await _userDetailsRepository.GetAllUsersDetailsAsync();
        }

        public async Task<UserDetail> UpdateUserActivestatus(Guid userDetailsId, bool userActiveStatus)
        {
            return await _userDetailsRepository.UpdateUserActivestatus(userDetailsId, userActiveStatus);
        }
    }
}
