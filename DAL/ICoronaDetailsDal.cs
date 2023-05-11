using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface ICoronaDetailsDal
    {

        List<CoronaDetails> GetAllCoronaDetails();
        CoronaDetails GetCoronaDetailsById(int Id);
        void AddCoronaDetails(DateTime PositiveResultDate, DateTime RecoveryDate, string MemberId);
        void UpdateCoronaDetails(int Id, CoronaDetails coronaDetails);
        void DeleteCoronaDetails(int Id);
    }
}
