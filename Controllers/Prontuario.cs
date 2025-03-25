using Microsoft.AspNetCore.Mvc;
using MeritoHealth.Models;
using System.Collections.Generic;

namespace MeritoHealth.Controllers
{
    public class ProntuariosController : Controller
    {
        public IActionResult index()
        {
            return View();
        }


    }

}