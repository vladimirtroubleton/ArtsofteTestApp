using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArtsofteTestApp.Models
{
    public class DepartmentModel
    {
        [Key]
        public int DepartamentId { get; set; }

        public string DepartamentName { get; set; }

        public int DepartamentFloor { get; set; }
    }
}
