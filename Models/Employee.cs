using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.Models {
	public class Employee {
		public int ID { get; set; }
		[Required]
		public string Lastname { get; set; }
		[Required]
		public string Firstname { get; set; }
		[Required]
		public string Middlename { get; set; }
		[Required]
		public string Gender { get; set; }
		[Required]
		public string Department { get; set; }
		[Required]
		public string City { get; set; }
		[Required]
		public string Username { get; set; }
		[Required]
		public string Password { get; set; }
	}
}