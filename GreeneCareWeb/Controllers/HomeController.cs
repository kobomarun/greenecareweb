using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GreeneCareWeb.Models;

namespace GreeneCareWeb.Controllers;

public class HomeController : Controller
{
    private static List<SupportTicketModel> ticket = new List<SupportTicketModel>();

    public IActionResult Index()
    {
       
        return View(ticket);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Support()
    {
        var tickets = new SupportTicketModel();
        return View(tickets);
    }

    public IActionResult CreateSupportTicket(SupportTicketModel supportTicketModel)
    {
        return RedirectToAction(nameof(Index));
    }
}

