using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

public class AccountController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Success()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Register(Account account)
    {
        return View(ModelState.IsValid ? "Success" : "Index");
    }
}
