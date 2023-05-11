using BLL;
using Entity;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CoronaSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VaccineDetailsController : ControllerBase
    {

        IVaccineDetailsBLL ivaccineDetailsBLL;
        public VaccineDetailsController(IVaccineDetailsBLL ivaccineDetailsBLL)
        {
            this.ivaccineDetailsBLL = ivaccineDetailsBLL;
        }
        // GET
        [HttpGet]

        public List<VaccineDetails> Get()
        {
            return ivaccineDetailsBLL.GetAllVaccineDetails();
        }

        // GETById: 
        [HttpGet("{id}")]
        public VaccineDetails GetById(int id)
        {
            return ivaccineDetailsBLL.GetVaccineDetailsById(id);
        }



        // POST: 
        [HttpPost]
        public string Post(DateTime ReceivedDate, string Manufacturer, string MemberId)
        {  
            try
            {  
                if(ReceivedDate > DateTime.Now)
                {
                    return "Inavlid ReceivedDate!";

                }
                ivaccineDetailsBLL.AddVaccineDetails(ReceivedDate, Manufacturer,MemberId);
                return "succeed to add vaccine";
            }
            catch
            {
                return "faild  to add vaccine";
            }



        }

        // PUT
        [HttpPut("{id}")]
        public bool Put(int id, VaccineDetails vaccineDetails)
        {
            try
            {
                ivaccineDetailsBLL.UpdateVaccineDetails(id, vaccineDetails);
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
                ivaccineDetailsBLL.DeleteVaccineDetails(id);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
