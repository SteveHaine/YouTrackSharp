using System;
using Newtonsoft.Json;

namespace YouTrackSharp.TimeTracking
{
    /// <summary>
    /// A class that represents YouTrack issue work item author information.
    /// </summary>
    public class Author
    {
        /// <summary>
        /// Login.
        /// </summary>
        [JsonProperty("login")]
        public string Login { get; set; }

        /// <summary>
        /// Full name of the user.
        /// </summary>
        [JsonProperty("fullName")]
        public string FullName { get; set; }

        public override string ToString()
        {
           return FullName;
        }
    }
}