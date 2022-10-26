using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsProject
{
    public class AccountModel
    {

        public string  Name { get; set; }
        public string  Email { get; set; }

		public string Street { get; set; }
		public int PostalCode { get; set; }
		public string City { get; set; }
		public string Country { get; set; }
	}
}
