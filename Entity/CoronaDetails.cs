using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class CoronaDetails
    {
        [Key]
        public int Id { get; set; }
        public DateTime PositiveResultDate { get; set; }
        public DateTime RecoveryDate { get; set; }
        [MaxLength(9)]
        public string MemberId { get; set; }
        [ForeignKey("MemberId")]

        public Members Member { get; set; } 

   
    }

}
