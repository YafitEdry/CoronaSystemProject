using BLL;
using BLL.CoronaInformation;
using Entity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CoronaSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoronaDetailsController : ControllerBase
    {
        ICoronaDetailsBLL icoronaDetailsBLL;
        public CoronaDetailsController(ICoronaDetailsBLL icoronaDetailsBLL)
        {
            this.icoronaDetailsBLL = icoronaDetailsBLL;
        }
        // GET
        [HttpGet]

        public List<CoronaDetails> Get()
        { 
        
            return icoronaDetailsBLL.GetAllCoronaDetails();
           

        }

        // GETById: 
        [HttpGet("{id}")]
        public getCoronaDetailsResponse GetById(int id)
        {
            getCoronaDetailsResponse getCoronaDetailsResponse = new getCoronaDetailsResponse();
            CoronaDetails coronaDetails= icoronaDetailsBLL.GetCoronaDetailsById(id);
            if (coronaDetails != null)
            { getCoronaDetailsResponse.Id = coronaDetails.Id;
                getCoronaDetailsResponse.MemberId = coronaDetails.MemberId;
                getCoronaDetailsResponse.PositiveResultDate = coronaDetails.PositiveResultDate;
                getCoronaDetailsResponse.RecoveryDate = coronaDetails.RecoveryDate;
                getCoronaDetailsResponse.message = "sucsses";
               
            }
            getCoronaDetailsResponse.message = "the id not found!";
            return getCoronaDetailsResponse;



        }



        // POST: 
        [HttpPost]
        public string Post(DateTime PositiveResultDate, DateTime RecoveryDate, string MemberId)
        {
          
            try
            {
                if (PositiveResultDate != DateTime.MinValue&& RecoveryDate != DateTime.MinValue)
                {
                    if (PositiveResultDate>= RecoveryDate)
                    {
                        return "PositiveResultDate can't be greater than RecoveryDate! ";
                    }

                }
                if(PositiveResultDate>DateTime.Now)
                { 
                    return $"Invalid  PositiveResultDate!";
                }
                if(RecoveryDate > DateTime.Now)
                {
                    return $"the date can {RecoveryDate}  be in the future!";
                }
                if (MemberId.Length!=9) { return "Invalid id length"; };
                icoronaDetailsBLL.AddCoronaDetails(PositiveResultDate,RecoveryDate,MemberId);
                return "Succeeded";
            }
            catch
            {
                return "Fails";
            }



        }

        // PUT
        [HttpPut("{id}")]
        public bool Put(int id, CoronaDetails coronaDetails)
        {
            try
            {
                icoronaDetailsBLL.UpdateCoronaDetails(id, coronaDetails);
                return true;
            }
            catch
            {
                return false;
            }
        }



        // DELETE 
        [HttpDelete("{id}")]

        public bool Delete(int id)
        {
            try
            {
                icoronaDetailsBLL.DeleteCoronaDetails(id);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
