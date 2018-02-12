using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DataAccessLayer.Repository;
using DataAccessLayer.RepositoryBase;
using RepositoryPattern_ASPNetCore.Models;


public class HomeController : Controller
    {

    private IEmployeeRepository _repository;
    
    public HomeController(IEmployeeRepository repository)
    {
        _repository = repository;
    }

    public IActionResult Index()
        {
        var emp = _repository.FindAll();
            return View(emp);
        }
    }
