﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SallesWebMVC.Models;

namespace SallesWebMVC.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> listDeparment = new List<Department>();
            listDeparment.Add(new Department { Id = 1, Name = "Eletronicos"});
            listDeparment.Add(new Department { Id = 2, Name = "Fashion" });

            return View(listDeparment);
        }
    }
}