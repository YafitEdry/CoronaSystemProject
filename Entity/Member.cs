using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Members
    {
        [Key]
        public string Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
       
        public string City { get; set; }
        public string Street { get; set; }
        public int StreetNum { get; set; }
        public DateTime BornDate { get; set; }
        public string Phone { get; set; }
        public string CellPhone { get; set; }
        public Guid ImageFileName { get; set; }
    }

}
