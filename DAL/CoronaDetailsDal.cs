using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace DAL
{
    public class CoronaDetailsDal : ICoronaDetailsDal
    {
        public CoronaSystemDbContext db = new CoronaSystemDbContext();

        public List<CoronaDetails> GetAllCoronaDetails()
        {
            return db.CoronaDetails.ToList();
        }
        public CoronaDetails GetCoronaDetailsById(int Id)
        {
           
            return db.CoronaDetails.FirstOrDefault(x => x.Id == Id);
        }

        public void AddCoronaDetails(DateTime PositiveResultDate ,DateTime RecoveryDate, string MemberId )

        {   CoronaDetails coronaDetails = new CoronaDetails();
            coronaDetails.PositiveResultDate = PositiveResultDate;
            coronaDetails.RecoveryDate = RecoveryDate;
            coronaDetails.MemberId = MemberId;
            db.CoronaDetails.Add(coronaDetails);
            db.SaveChanges();
        }
        public void UpdateCoronaDetails(int Id, CoronaDetails c)
        {
            var CoronaDetails = db.CoronaDetails.FirstOrDefault(x => x.Id == Id);
            if (c != null)
            {
                //CoronaDetails.Id = c.Id;
                CoronaDetails.MemberId = c.MemberId;
                CoronaDetails.PositiveResultDate= c.PositiveResultDate;
                CoronaDetails.RecoveryDate= c.RecoveryDate; 
                db.SaveChanges();
            }
        }
        public void DeleteCoronaDetails(int Id)
        {
            db.CoronaDetails.Remove(db.CoronaDetails.FirstOrDefault(x => x.Id == Id));
            db.SaveChanges();
        }
    }
}