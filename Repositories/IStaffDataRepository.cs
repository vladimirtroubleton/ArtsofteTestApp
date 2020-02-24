using System.Collections.Generic;
using ArtsofteTestApp.Models;

namespace ArtsofteTestApp.Repositories
{
    public interface IStaffDataRepository
    {
        void EditStaffRecord(StaffModel model);
        List<StaffModel> GetAllStaffRecord();
        void RemoveStaffRecord(StaffModel model);
        void SaveNewStaffRecord(StaffModel model);
        StaffModel FindRecordById(int? id);
    }
}