using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class VaccineDetails
    {
        [Key]
        public int Id { get; set; }
        public DateTime ReceivedDate { get; set; }
        public string Manufacturer { get; set; }
        public string MemberId { get; set; }

        [ForeignKey("MemberId")]
        public Members Member { get; set; }
    }
    
   


}
