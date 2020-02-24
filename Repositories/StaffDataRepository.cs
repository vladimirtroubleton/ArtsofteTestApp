using ArtsofteTestApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtsofteTestApp.Repositories
{
    public class StaffDataRepository : IStaffDataRepository
    {
        public AppContext dbcontext;

        public StaffDataRepository(AppContext dbcontext)
        {
            this.dbcontext = dbcontext;
        }

        public void SaveNewStaffRecord(StaffModel model)
        {
            dbcontext.Staffs.Add(model);
            dbcontext.SaveChanges();
        }

        public List<StaffModel> GetAllStaffRecord()
        {
            return dbcontext.Staffs.ToList();
        }

        public void RemoveStaffRecord(StaffModel model)
        {
            dbcontext.Staffs.Remove(model);
            dbcontext.SaveChanges();
        }

        public void EditStaffRecord(StaffModel model)
        {
            dbcontext.Entry(model).State = EntityState.Modified;
            dbcontext.SaveChanges();
        }

        public StaffModel FindRecordById(int? id)
        {
            return dbcontext.Staffs.Find(id);
        }
    }


}
