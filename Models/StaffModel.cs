using System.ComponentModel.DataAnnotations;

namespace ArtsofteTestApp.Models
{
    public class StaffModel
    {
        [Key]
        [Display(Name = "Порядковый номер сотрудника")]
        public int StaffId { get; set; }

        [Display(Name ="Имя")]
        public string Name { get; set; }

        [Display(Name = "Фамилия")]
        public string Surname { get; set; }

        [Display(Name = "Возраст")]
        public int Age { get; set; }

        [Display(Name = "Пол")]
        public string Gender { get; set; }

        [Display(Name = "Название отдела")]
        public int DepartamentId { get; set; }

        [Display(Name = "Язык программирования")]
        public int LanguageId { get; set; }

    }
}
