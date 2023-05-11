using Entity;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BLL;
namespace BLL.CoronaInformation
{
    public class ActivePatientsLastMonth
    {
        //public void GetActivePatientsLastMonth(list<CoronaDetails> lst)
        //{   CoronaSystemDbContext db = new CoronaSystemDbContext();
        //DateTime startDate = DateTime.Now.Date.AddMonths(-1);
        //DateTime endDate = DateTime.Now.Date;
        //CoronaSystemDbContext coronaSystemDbContext = new CoronaSystemDbContext();
        //var result = db.

        //    .Where(cd => cd.PositiveResultDate >= startDate && cd.PositiveResultDate <= endDate)
        //    .GroupBy(cd => cd.PositiveResultDate.Date)
        //    .Select(group => new
        //    {
        //        Date = group.Key,
        //        ActivePatients = group.Count()
        //    })
        //    .ToList();

        //Console.WriteLine();
    }
    }
 
