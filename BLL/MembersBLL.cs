using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
 

    public class MemberBLL:IMembersBLL
    {
        private readonly IMembersDal membersDal;

        public MemberBLL(IMembersDal membersDal)
        {
            this.membersDal = membersDal;
        }

        public void AddMember(Members member)
        {
            membersDal.AddMember(member);
        }

        public void DeleteMember(string id)
        {
            membersDal.DeleteMember(id);
        }

        public List<Members> GetAllMember()
        {
            return membersDal.GetAllMember();
        }

        public Members GetMemberById(string id)
        {
            return membersDal.GetMemberById(id);
        }

        public void UpdateMember(string id, Members member)
        {
            membersDal.UpdateMember(id, member);
        }
    }

}
