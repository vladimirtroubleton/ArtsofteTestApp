using ArtsofteTestApp.ModelBuilders;
using ArtsofteTestApp.Models;
using ArtsofteTestApp.Repositories;
using ArtsofteTestApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;

namespace ArtsofteTestApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDepartamentRepository departamentRepository;
        private readonly IProgrammingLanguageDataRepository programmingLanguageDataRepository;
        private readonly IStaffDataRepository staffDataRepository;
        private readonly IStaffModelBuilder staffModelBuilder;

        public HomeController(IDepartamentRepository departamentRepository, IProgrammingLanguageDataRepository programmingLanguageDataRepository, IStaffDataRepository staffDataRepository, IStaffModelBuilder staffModelBuilder)
        {
            this.departamentRepository = departamentRepository;
            this.programmingLanguageDataRepository = programmingLanguageDataRepository;
            this.staffDataRepository = staffDataRepository;
            this.staffModelBuilder = staffModelBuilder;
        }

        public IActionResult Index()
        {
            return View(staffModelBuilder.GetStaffInfo());
        }

        public IActionResult LookProgLanguages()
        {

            return View(programmingLanguageDataRepository.GetAllProgLanguageRecord());
        } 

        public IActionResult LookDepartamentsData()
        {
            return View(departamentRepository.GetAllDepartamentRecord());
        }

       [HttpGet]
       public IActionResult AddStaffRecord()
       {
            ViewBag.Departaments = new SelectList(departamentRepository.GetAllDepartamentRecord(), "DepartamentId", "DepartamentName");
            ViewBag.ProgLanguages = new SelectList(programmingLanguageDataRepository.GetAllProgLanguageRecord(), "LanguageId", "LanguageName");

            return View();
       }

        [HttpPost]
        public IActionResult AddStaffRecord(StaffModel model)
        {
            staffDataRepository.SaveNewStaffRecord(model);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult AddLanguageRecord()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddLanguageRecord(ProgrammingLanguageModel model)
        {
            programmingLanguageDataRepository.SaveNewProgLanguageRecord(model);
            return RedirectToAction("LookProgLanguages");
        }

        [HttpGet]
        public IActionResult AddDepartamentRecord()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddDepartamentRecord(DepartmentModel model)
        {
            departamentRepository.SaveNewDepartamentRecord(model);
            return RedirectToAction("LookDepartamentsData");
        }

        [HttpGet]
        public IActionResult StaffRecordEdit(int id)
        {
            ViewBag.Departaments = new SelectList(departamentRepository.GetAllDepartamentRecord(), "DepartamentId", "DepartamentName");
            ViewBag.ProgLanguages = new SelectList(programmingLanguageDataRepository.GetAllProgLanguageRecord(), "LanguageId", "LanguageName");

            return View(staffDataRepository.FindRecordById(id));
        }

        [HttpPost]

        public IActionResult StaffRecordEdit(StaffModel model)
        {
            staffDataRepository.EditStaffRecord(model);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult StaffRecordRemove(int id)
        {
            return View(staffModelBuilder.GetStaffInfoById(id));
        }

        [HttpPost]
        public IActionResult StaffRecordRemove(StaffViewModel model)
        {
            var removableModel = staffDataRepository.FindRecordById(model.Id);

            staffDataRepository.RemoveStaffRecord(removableModel);

            return RedirectToAction("Index");
        }

        public string[] AutocompleteSearch(string term)
        {
            var models = staffDataRepository.GetAllStaffRecord().Where(a => a.Name.Contains(term))
                            .Select(a => a.Name)
                            .ToArray();

            return models;
        }
    }
}
