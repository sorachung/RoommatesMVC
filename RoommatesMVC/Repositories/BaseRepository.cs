using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace RoommatesMVC.Repositories
{
    /// <summary>
    ///  A base class for every other Repository class to inherit from.
    ///  This class is responsible for providing a database connection to each of the repository subclasses
    /// </summary>
    public class BaseRepository
    {
        /// <summary>
        ///  A "connection string" is the address of the database.
        /// </summary>
        private readonly IConfiguration _config;

        /// <summary>
        ///  This constructor will be invoked by subclasses.
        ///  It will save the connection string for later use.
        /// </summary>
        public BaseRepository(IConfiguration config)
        {
            _config = config;
        }


        /// <summary>
        ///  Represents a connection to the database.
        ///   This is a "tunnel" to connect the application to the database.
        ///   All communication between the application and database passes through this connection.
        /// </summary>
        protected SqlConnection Connection => new SqlConnection(_config.GetConnectionString("DefaultConnection"));
    }
}
