using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GreeneCareWeb.Models;

namespace GreeneCareWeb.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Support()
    {
        return View();
    }
}

