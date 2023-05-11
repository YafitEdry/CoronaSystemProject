using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class getCoronaDetailsResponse
    {
        public int Id { get; set; }
        public DateTime PositiveResultDate { get; set; }
        public DateTime RecoveryDate { get; set; }
        [MaxLength(9)]
        public string MemberId { get; set; }
      
       public string message { get; set; }
    }
}
