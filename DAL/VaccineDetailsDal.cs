using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{


    public class VaccineDetailsDal : IVaccineDetailsDal
    {
        private readonly CoronaSystemDbContext db = new CoronaSystemDbContext();

        public List<VaccineDetails> GetAllVaccineDetails()
        {
            return db.VaccineDetails.ToList();
        }

        public VaccineDetails GetVaccineDetailsById(int Id)
        {
            return db.VaccineDetails.FirstOrDefault(x => x.Id == Id);
        }

        public void AddVaccineDetails(DateTime ReceivedDate, string Manufacturer, string MemberId)
        {
            VaccineDetails vaccineDetails = new VaccineDetails();
            vaccineDetails.Manufacturer = Manufacturer;
            vaccineDetails.MemberId = MemberId;
            vaccineDetails.ReceivedDate = ReceivedDate;
            db.VaccineDetails.Add(vaccineDetails);
            db.SaveChanges();

        }

        public void UpdateVaccineDetails(int Id, VaccineDetails vaccineDetails)
        {
            var existingVaccineDetails = db.VaccineDetails.FirstOrDefault(x => x.Id == Id);
            if (existingVaccineDetails != null)
            {
                existingVaccineDetails.ReceivedDate = vaccineDetails.ReceivedDate;
                existingVaccineDetails.Manufacturer = vaccineDetails.Manufacturer;
                existingVaccineDetails.MemberId = vaccineDetails.MemberId;

                db.SaveChanges();
            }
        }

        public void DeleteVaccineDetails(int Id)
        {
            var vaccineDetails = db.VaccineDetails.FirstOrDefault(x => x.Id == Id);
            if (vaccineDetails != null)
            {
                db.VaccineDetails.Remove(vaccineDetails);
                db.SaveChanges();
            }
        }
    }


}
