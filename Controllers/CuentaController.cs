using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PracticaCalificada2.Models;

namespace PracticaCalificada2.Controllers
{
    public class CuentaController : Controller
    {
        private readonly ILogger<CuentaController> _logger;

        public CuentaController(ILogger<CuentaController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registrar(CuentaBancaria cuentaBancaria)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Message = "Cuenta bancaria creada con éxito.";
            }
            return View("Index", cuentaBancaria);
        }

    }
}