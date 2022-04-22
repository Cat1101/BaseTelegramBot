using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BaseTelegramBot.Models;

namespace BaseTelegramBot.Controllers;

public class HomeController : Controller
{
    public string Index()
    {
        return "It's my telegram bot";
    }
}