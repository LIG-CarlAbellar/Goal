using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.Models {
	public class LoginDataAccessLayer {
		string connectionString = "Server=LAPTOP-103H1OGA;Database=ProjectManagement;User ID=sa;Password=carl123;";

		//Get the login details of a particular employee
		public bool GetEmployeeLoginData(string username, string password) {
			int? empID;
			using (SqlConnection con = new SqlConnection(connectionString)) {
				string sqlQuery = "SELECT * FROM tblEmployee WHERE Uname='" + username +"' AND Pass='" + password + "'";
				SqlCommand cmd = new SqlCommand(sqlQuery, con);
				
				con.Open();
				SqlDataReader rdr = cmd.ExecuteReader();
				// SqlCommand cmd = new SqlCommand("spGetAllEmployees", con);
				// cmd.CommandType = CommandType.StoredProcedure;
				// cmd.Parameters.AddWithValue("@Uname", username);
				// cmd.Parameters.AddWithValue("@Pass", password);
				// con.Open();
				// SqlDataReader rdr = cmd.ExecuteReader();

				if (rdr.Read()) {
					empID = Convert.ToInt32(rdr["EmployeeID"]);

					if (empID != null) {
					return true;
					}
				}
			}
			return false;
		}

	}

}