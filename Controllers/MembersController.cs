using Microsoft.AspNetCore.Mvc;
using Entity;
using BLL;
using DAL;

namespace CoronaSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MembersController : ControllerBase
    {
        IMembersBLL imembersBLL;
        public MembersController(IMembersBLL imembersBLL)
        {
            this.imembersBLL = imembersBLL;
        }
        // GET: 
        [HttpGet]

        public List<Members> Get()
        {
            return imembersBLL.GetAllMember();
        }

        // GETById: 
        [HttpGet("{id}")]
        public Members GetById(string id)
        {    
            return imembersBLL.GetMemberById(id);
        }

        // POST: 
        [HttpPost]
        public string Post(Members member)
        {
            string message="";
            try
            { 
               if( member.Id.Length!=9 ) {
                    message += "Invalid Id length!";
               }
                
                if (member.Phone.Length != 9)
                {
                    message +=  "\nInvalid Phone length!";
                }
                if (member.CellPhone.Length != 10)
                {
                    message+= "\nInvalid Cellphone length!";
                }
                imembersBLL.AddMember(member);
                message+= "\nsucceed to add the member";
            }
            catch
            {
                message += "failed to add the member!";
            }
            return message;


        }

        // PUT 
        [HttpPut("{id}")]
        public bool Put(string id, Members member)
        {
            try
            {
                imembersBLL.UpdateMember(id, member);
                return true;
            }
            catch
            {
                return false;
            }
        }



        // DELETE 
        [HttpDelete("{id}")]

        public bool Delete(string id)
        {
            try
            {
                imembersBLL.DeleteMember(id);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
