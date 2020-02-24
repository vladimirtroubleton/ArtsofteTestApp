using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArtsofteTestApp.Models
{
    public class ProgrammingLanguageModel
    {
        [Key]
        public int LanguageId { get; set; }

        [Display(Name ="Название языка")]
        public string LanguageName { get; set; }
    }
}
