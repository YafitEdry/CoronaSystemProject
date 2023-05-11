using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{

   
    
    public class MemberDal : IMembersDal
    {
            private readonly CoronaSystemDbContext db = new CoronaSystemDbContext();

            public List<Members> GetAllMember()
            {
                return db.Member.ToList();
            }

            public Members GetMemberById(string Id)
            {
                return db.Member.FirstOrDefault(x => x.Id == Id);
            }

            public void AddMember(Members member)
            {
                db.Member.Add(member);
                db.SaveChanges();
            }

            public void UpdateMember(string Id, Members member)
            {
            var Member = db.Member.FirstOrDefault(x => x.Id.Equals(Id));
                if (Member != null)
                {
                  
                    Member.FirstName = member.FirstName;
                    Member.LastName = member.LastName;
                    Member.City = member.City;
                    Member.Street = member.Street;
                    Member.StreetNum = member.StreetNum;
                    Member.BornDate = member.BornDate;
                    Member.Phone = member.Phone;
                    Member.CellPhone = member.CellPhone;
                    Member.ImageFileName = member.ImageFileName;

                    db.SaveChanges();
                }
            }

            public void DeleteMember(string Id)
            {
                var member = db.Member.FirstOrDefault(x => x.Id == Id);
                if (member != null)
                {
                    db.Member.Remove(member);
                    db.SaveChanges();
                }
            }
        }

    
}
