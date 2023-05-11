using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class VaccineDetailsBLL:IVaccineDetailsBLL
    {
        private readonly IVaccineDetailsDal vaccineDetailsDal;

        public VaccineDetailsBLL(IVaccineDetailsDal vaccineDetailsDal)
        {
            this.vaccineDetailsDal = vaccineDetailsDal;
        }
   

        public void AddVaccineDetails(DateTime ReceivedDate, string Manufacturer, string MemberId)
        {
            vaccineDetailsDal.AddVaccineDetails(ReceivedDate,Manufacturer,MemberId);
        }

        public void DeleteVaccineDetails(int id)
        {
            vaccineDetailsDal.DeleteVaccineDetails(id);
        }

        public List<VaccineDetails> GetAllVaccineDetails()
        {
            return vaccineDetailsDal.GetAllVaccineDetails();
        }

        public VaccineDetails GetVaccineDetailsById(int id)
        {
            return vaccineDetailsDal.GetVaccineDetailsById(id);
        }

        public void UpdateVaccineDetails(int id, VaccineDetails vaccineDetails)
        {
            vaccineDetailsDal.UpdateVaccineDetails(id, vaccineDetails);
        }
    }

}
