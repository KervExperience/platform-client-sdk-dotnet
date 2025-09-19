using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace LoggerTester
{
    /// <summary>
    /// Minimal Genesys API manager wrapper to centralize SDK usage and future cross-cutting concerns.
    /// Demonstrates how to route calls through a manager instead of invoking ApiClient directly.
    /// </summary>
    public sealed class GenesysApiManager(Configuration configuration)
    {
        private readonly UsersApi _usersApi = new(configuration);

        /// <summary>
        /// Simple example call to fetch the current (authorized) user.
        /// Logging is already handled by the configured Logger on Configuration.
        /// </summary>
        public async Task<UserMe> GetCurrentUserAsync()
        {
            return await _usersApi.GetUsersMeAsync();
        }

        /// <summary>
        /// Synchronous variant (not generally recommended for new code, but included for parity with earlier direct calls).
        /// </summary>
        public UserMe GetCurrentUser()
        {
            return _usersApi.GetUsersMe();
        }
    }
}