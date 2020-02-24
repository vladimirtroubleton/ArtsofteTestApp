using ArtsofteTestApp.Models;
using ArtsofteTestApp.Repositories;
using ArtsofteTestApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtsofteTestApp.ModelBuilders
{
    public class StaffModelBuilder : IStaffModelBuilder
    {
        private readonly IStaffDataRepository staffDataRepository;
        private readonly IDepartamentRepository departamentRepository;
        private readonly IProgrammingLanguageDataRepository programmingLanguageDataRepository;

        public StaffModelBuilder(IStaffDataRepository staffDataRepository, IDepartamentRepository departamentRepository, IProgrammingLanguageDataRepository programmingLanguageDataRepository)
        {
            this.staffDataRepository = staffDataRepository;
            this.departamentRepository = departamentRepository;
            this.programmingLanguageDataRepository = programmingLanguageDataRepository;
        }

        public List<StaffViewModel> GetStaffInfo()
        {
            var modelList = staffDataRepository.GetAllStaffRecord();

            List<StaffViewModel> staffViews = new List<StaffViewModel>();

            foreach (var item in modelList)
            {
                staffViews.Add(new StaffViewModel
                {
                    Id = item.StaffId,
                    Name = item.Name,
                    Surname = item.Surname,
                    Age = item.Age,
                    Gender = item.Gender,
                    DepartamentName = departamentRepository.FindDepartamentById(item.DepartamentId).DepartamentName,
                    ProgrammingLanguage = programmingLanguageDataRepository.FindProgLanguageById(item.LanguageId).LanguageName
                }
                ) ;
            }

            return staffViews;
        }

        public StaffViewModel GetStaffInfoById(int id)
        {
           StaffModel model =  staffDataRepository.FindRecordById(id);

            return new StaffViewModel
            {
                Id = model.StaffId,
                Name = model.Name,
                Surname = model.Surname,
                Age = model.Age,
                Gender = model.Gender,
                DepartamentName = departamentRepository.FindDepartamentById(model.DepartamentId).DepartamentName,
                ProgrammingLanguage = programmingLanguageDataRepository.FindProgLanguageById(model.LanguageId).LanguageName
            };
        }
    }
}
