using Microsoft.EntityFrameworkCore;
using Users.Contexts;
using Users.Models;
using Users.Repositories.Interfaces;
using Users.ViewModels;

namespace Users.Repositories
{
    public class UserDetailsRepository : IUserDetailsRepository
    {
        private readonly DefaultContext _context;
        public UserDetailsRepository(DefaultContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<GetUserDetailsViewModel>> GetAllUsersDetailsAsync()
        {
            try
            {
                List<GetUserDetailsViewModel> getUserDetailslist = new();
                var users = await _context.UserDetails.ToListAsync();

                foreach (var user in users)
                {
                    GetUserDetailsViewModel getUserDetailsViewModel = new()
                    {
                        UserDetailsID = user.UserDetailsID,
                        FullName = user.FirstName + " " + user.LastName,
                        Email = user.Email,
                        Status = user.Active == true ? "Active" : "Disabled"
                    };
                    getUserDetailslist.Add(getUserDetailsViewModel);
                }

                return getUserDetailslist;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<UserDetail> UpdateUserActivestatus(Guid userDetailsId, bool userActiveStatus)
        {
            try
            {
                var userDetail = await _context.UserDetails.Where(x => x.UserDetailsID == userDetailsId).FirstOrDefaultAsync();
                if (userDetail != null)
                {
                    userDetail.Active = userActiveStatus;
                    _context.UserDetails.Attach(userDetail);
                    _context.Entry(userDetail).State = EntityState.Modified;
                    await _context.SaveChangesAsync();
                    return userDetail;

                }
                return new UserDetail();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
