using lr4.Models;

namespace lr4.Services
{
    public class UserService
    {
        private readonly IConfiguration _configuration;

        public UserService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public UserProfile GetUserProfile(int? id)
        {
            var profiles = _configuration.GetSection("UserProfiles").Get<List<UserProfile>>();

            if (id.HasValue)
            {
                var userProfile = profiles.FirstOrDefault(p => p.Id == id);
                return userProfile ?? new UserProfile { Id = -1, Name = "User Not Found" };
            }
            else
            {
                return new UserProfile { Id = 1111, Name = "Current User", Age = 25 };
            }
        }
    }
}
