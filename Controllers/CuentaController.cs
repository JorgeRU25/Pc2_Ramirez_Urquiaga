using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PracticaCalificada2.Data;
using PracticaCalificada2.Models;

namespace PracticaCalificada2.Controllers
{
    public class CuentaController : Controller
    {
        private readonly ILogger<CuentaController> _logger;

        private readonly ApplicationDbContext _context;

        public CuentaController(ILogger<CuentaController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Listar()
        {
            var listarCuentas = _context.Cuentas.ToList();
            return View(listarCuentas);
        }

        [HttpPost]
        public IActionResult Registrar(CuentaBancaria cuentaBancaria)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cuentaBancaria);
                _context.SaveChanges();
                ViewBag.Message = "Cuenta bancaria creada con éxito.";
            }
            return View("Index", cuentaBancaria);
        }

    }
}