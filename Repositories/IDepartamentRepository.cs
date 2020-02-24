using System.Collections.Generic;
using ArtsofteTestApp.Models;

namespace ArtsofteTestApp.Repositories
{
    public interface IDepartamentRepository
    {
        void EditDepartamentRecord(DepartmentModel model);
        DepartmentModel FindDepartamentById(int id);
        List<DepartmentModel> GetAllDepartamentRecord();
        void RemoveDepartamentRecord(DepartmentModel model);
        void SaveNewDepartamentRecord(DepartmentModel model);
    }
}