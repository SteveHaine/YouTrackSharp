using System;
using YouTrackSharp.AgileBoards;
using YouTrackSharp.Issues;
using YouTrackSharp.Management;
using YouTrackSharp.Projects;
using YouTrackSharp.TimeTracking;
using YouTrackSharp.Users;

namespace YouTrackSharp
{
    /// <summary>
    /// Extension methods for <see cref="Connection" />, providing easy access to all services.
    /// </summary>
    public static class ConnectionExtensions
    {
        /// <summary>
        /// Creates a <see cref="ProjectsService" />.
        /// </summary>
        /// <param name="connection">The <see cref="Connection" /> to create a service with.</param>
        /// <returns><see cref="ProjectsService" /> for working with YouTrack projects.</returns>
        public static IProjectsService CreateProjectsService(this Connection connection)
        {
            return new ProjectsService(connection);
        }

        /// <summary>
        /// Creates a <see cref="IssuesService" />.
        /// </summary>
        /// <param name="connection">The <see cref="Connection" /> to create a service with.</param>
        /// <returns><see cref="IssuesService" /> for working with YouTrack issues.</returns>
        public static IIssuesService CreateIssuesService(this Connection connection)
        {
            return new IssuesService(connection);
        }

        /// <summary>
        /// Creates a <see cref="TimeTrackingService" />.
        /// </summary>
        /// <param name="connection">The <see cref="Connection" /> to create a service with.</param>
        /// <returns><see cref="TimeTrackingService" /> for working with YouTrack time tracking.</returns>
        public static ITimeTrackingService CreateTimeTrackingService(this Connection connection)
        {
            return new TimeTrackingService(connection);
        }

        /// <summary>
        /// Creates a <see cref="UserManagementService" />.
        /// </summary>
        /// <param name="connection">The <see cref="Connection" /> to create a service with.</param>
        /// <returns><see cref="UserManagementService" /> for managing YouTrack users.</returns>
        public static IUserService CreateUserService(this Connection connection)
        {
           return new UserService(connection);
        }

      /// <summary>
      /// Creates a <see cref="UserManagementService" />.
      /// </summary>
      /// <param name="connection">The <see cref="Connection" /> to create a service with.</param>
      /// <returns><see cref="UserManagementService" /> for managing YouTrack users.</returns>
      public static IUserManagementService CreateUserManagementService(this Connection connection)
        {
            return new UserManagementService(connection);
        }

        /// <summary>
        /// Creates a <see cref="TimeTrackingManagementService" />.
        /// </summary>
        /// <param name="connection">The <see cref="Connection" /> to create a service with.</param>
        /// <returns><see cref="TimeTrackingManagementService" /> for managing YouTrack time tracking settings.</returns>
        public static ITimeTrackingManagementService CreateTimeTrackingManagementService(this Connection connection)
        {
            return new TimeTrackingManagementService(connection);
        }

        /// <summary>
        /// Creates a <see cref="ProjectCustomFieldsService" />.
        /// </summary>
        /// <param name="connection">The <see cref="Connection" /> to create a service with.</param>
        /// <returns><see cref="ProjectCustomFieldsService" /> for accessing custom project fields.</returns>
        public static IProjectCustomFieldsService ProjectCustomFieldsService(this Connection connection)
        {
            return new ProjectCustomFieldsService(connection);
        }

        /// <summary>
        /// Creates a <see cref="AgileBoardService" />.
        /// </summary>
        /// <remarks>
        /// YouTrack 2018.2 and higher no longer support the agile board API. Please check <a href="https://github.com/JetBrains/YouTrackSharp/issues/81">https://github.com/JetBrains/YouTrackSharp/issues/81</a> for more information.
        /// </remarks>
        /// <param name="connection">The <see cref="Connection" /> to create a service with.</param>
        /// <returns><see cref="AgileBoardService" /> for working with YouTrack agile boards.</returns>
        [Obsolete("YouTrack 2018.2 and higher no longer support the agile board API. Please check https://github.com/JetBrains/YouTrackSharp/issues/81 for more information.")]
        public static IAgileBoardService CreateAgileBoardService(this Connection connection)
        {
            return new AgileBoardService(connection);
        }
    }
}