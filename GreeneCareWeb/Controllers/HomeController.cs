using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GreeneCareWeb.Models;

namespace GreeneCareWeb.Controllers;

public class HomeController : Controller
{
    private static List<SupportTicketModel> tickets = new List<SupportTicketModel>();

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
        return View(tickets);
    }
}

