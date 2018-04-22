using FortniteStats.Tracker.Api.Objects;
using System.Threading.Tasks;

namespace FortniteStats.Tracker.Api
{
    public interface IFortniteTrackerApi
    {
        /// <summary>
        /// Gets the profile details.
        /// </summary>
        /// <param name="platform">The platform.</param>
        /// <param name="epicUserName">Name of the epic user.</param>
        /// <returns></returns>
        ProfileDetails GetProfileDetails(string platform, string epicUserName);

        /// <summary>
        /// Gets the profile details async.
        /// </summary>
        /// <param name="platform">The platform.</param>
        /// <param name="epicUserName">Name of the epic user.</param>
        /// <returns></returns>
        Task<ProfileDetails> GetProfileDetailsAsync(string platform, string epicUserName);
    }
}
