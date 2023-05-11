using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public interface IMembersBLL
    {

        List<Members> GetAllMember();
        Members GetMemberById(string Id);

        void AddMember(Members member);
        void UpdateMember(string Id, Members member);
        void DeleteMember(string Id);
    }
}
