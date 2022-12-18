using Microsoft.AspNetCore.Mvc;
using Users.Services.Interfaces;

namespace Users.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserDetailsController : Controller
    {
        private readonly IUserDetailsService _userDetailsService;
        public UserDetailsController(IUserDetailsService userDetailsService)
        {
            _userDetailsService = userDetailsService;
        }

        [HttpGet]
        [Route("GetAllUserDetailsAsync")]
        public async Task<IActionResult> GetAllUserDetailsAsync()
        {
            var result = await _userDetailsService.GetAllUsersDetailsAsync();
            return Ok(result);
        }

        [HttpGet]
        [Route("UpdateUserActivestatus")]
        public async Task<IActionResult> UpdateUserActivestatus(Guid userDetailsId, bool userActiveStatus)
        {
            try
            {
                var result = await _userDetailsService.UpdateUserActivestatus(userDetailsId, userActiveStatus);
                if (result.UserDetailsID == new Guid("00000000-0000-0000-0000-000000000000"))
                {
                    return BadRequest(result);
                }
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
