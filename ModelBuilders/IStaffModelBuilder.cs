using System.Collections.Generic;
using ArtsofteTestApp.ViewModels;

namespace ArtsofteTestApp.ModelBuilders
{
    public interface IStaffModelBuilder
    {
        List<StaffViewModel> GetStaffInfo();
        StaffViewModel GetStaffInfoById(int id);
    }
}