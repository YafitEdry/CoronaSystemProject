using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IVaccineDetailsDal
    {
        List<VaccineDetails> GetAllVaccineDetails();
        VaccineDetails GetVaccineDetailsById(int Id);

        void AddVaccineDetails( DateTime ReceivedDate,string Manufacturer, string MemberId);

        void UpdateVaccineDetails(int Id, VaccineDetails vaccineDetails);
        void DeleteVaccineDetails(int Id);
    }
}
