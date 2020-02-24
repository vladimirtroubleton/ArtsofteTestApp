using ArtsofteTestApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtsofteTestApp.Repositories
{
    public class DepartamentRepository : IDepartamentRepository
    {
        public AppContext dbcontext;

        public DepartamentRepository(AppContext dbcontext)
        {
            this.dbcontext = dbcontext;
        }

        public void SaveNewDepartamentRecord(DepartmentModel model)
        {
            dbcontext.Departments.Add(model);
            dbcontext.SaveChanges();
        }

        public List<DepartmentModel> GetAllDepartamentRecord()
        {
            return dbcontext.Departments.ToList();
        }

        public void RemoveDepartamentRecord(DepartmentModel model)
        {
            dbcontext.Departments.Remove(model);
            dbcontext.SaveChanges();
        }

        public void EditDepartamentRecord(DepartmentModel model)
        {
            dbcontext.Entry(model).State = EntityState.Modified;
            dbcontext.SaveChanges();
        }

        public DepartmentModel FindDepartamentById(int id)
        {
            return dbcontext.Departments.Find(id);
        }

    }
}
