using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CoronaDetailsBLL:ICoronaDetailsBLL
    {
        
        
            private readonly ICoronaDetailsDal coronaDetailsDal;

            public CoronaDetailsBLL(ICoronaDetailsDal coronaDetailsDal)
            {
                this.coronaDetailsDal = coronaDetailsDal;
            }
        
            public void AddCoronaDetails(DateTime PositiveResultDate, DateTime RecoveryDate, string MemberId)
        {
                coronaDetailsDal.AddCoronaDetails( PositiveResultDate,  RecoveryDate, MemberId);
            }

            public void DeleteCoronaDetails(int id)
            {
                coronaDetailsDal.DeleteCoronaDetails(id);
            }

            public List<CoronaDetails> GetAllCoronaDetails()
            {
                return coronaDetailsDal.GetAllCoronaDetails();
            }

            public CoronaDetails GetCoronaDetailsById(int id)
            {
                return coronaDetailsDal.GetCoronaDetailsById(id);
            }

            public void UpdateCoronaDetails(int id, CoronaDetails coronaDetails)
            {
                coronaDetailsDal.UpdateCoronaDetails(id, coronaDetails);
            }
        }


    
}
