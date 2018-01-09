using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace HousesForSale2.Models
{


    public static class GetConString
    {
        /// <summary>
        /// DB Connection the string.
        /// </summary>
        /// <returns>Connection String</returns>
        public static string ConString()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            var config = builder.Build();
            string constring = config.GetConnectionString("AgentProfile");
            return constring;
        }
    }

    /// <summary>
    /// model for enquiry data
    /// </summary>
    public class AgentData
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Comment { get; set; }
    }
}
