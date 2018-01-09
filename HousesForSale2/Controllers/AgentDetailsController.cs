using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HousesForSale2.Models;
using Microsoft.IdentityModel.Protocols;
using System.Data;

namespace HousesForSale2.Controllers
{
    [Produces("application/json")]
   
    public class AgentDetailsController : Controller
    {

        /// <summary>
        /// Adds the contact.
        /// </summary>
        /// <param name="agent">The agent.</param>
        /// <returns>JSON</returns>
        [Route("api/AgentDetails/AddContact")]
        [HttpPost]
        public JsonResult AddContact(AgentData agent)
        {
            
           
            SqlConnection con = new SqlConnection(GetConString.ConString());
            SqlCommand cmd = new SqlCommand();
            cmd = new SqlCommand("InsertData", con); // Stored Procedure to add data
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FName", agent.FName);
            cmd.Parameters.AddWithValue("@Lname", agent.LName);
            cmd.Parameters.AddWithValue("@Email", agent.Email);
            cmd.Parameters.AddWithValue("@Phone", agent.Phone);
            cmd.Parameters.AddWithValue("@Comment", agent.Comment);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            string data = "Enquiry Send Successfully,Melissa will get back to you very soon.";
            return Json(data); // return json string to ajax cal
        }
    }
}