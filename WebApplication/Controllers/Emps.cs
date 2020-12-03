using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class Emps : Controller
    {
        public IActionResult Index()
        {
            List<Emp> emplist = new List<Emp>
            {
                new Emp(){Id=1,Name="Pranjal",Desig="Developer",DOJ=DateTime.Parse("01/01/2015") },
                new Emp(){Id=2,Name="Aman",Desig="Manager",DOJ=DateTime.Parse("02/04/2016") },
                new Emp(){Id=3,Name="Alok",Desig="Tester",DOJ=DateTime.Parse("02/05/2017") },
                new Emp(){Id=4,Name="Ajay",Desig="Analyst",DOJ=DateTime.Parse("03/06/2018") }
            };

            return View(emplist);
        }
    }
}
