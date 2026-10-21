using System;
using System.Diagnostics;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EstaWeb.Models;
using EstaWebSeAutodestruira;
using Newtonsoft.Json;

namespace EstaWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MessageService _service;

        public HomeController(ILogger<HomeController> logger, MessageService service)
        {
            _logger = logger;
            _service = service;
        }

        public IActionResult Index()
        {
            ViewBag.Segundos = _service.GetTtl();
            return View();
        }

        public IActionResult IndexById(string id)
        {
            ViewBag.Segundos = _service.GetTtl();
            ViewBag.MessageId = id;
            return View("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult Mensaje([FromBody]string text)
        {
            if (!string.IsNullOrEmpty(text))
            {
                String result = Regex.Replace(text, @"<[^>]*>", String.Empty);
                _service.Add(result);
            }
            return Ok("{}");
        }

        [HttpGet]
        public string Mensaje()
        {
            var result = _service.GetRandomDto();

            return JsonConvert.SerializeObject(result);
        }

        [HttpGet]
        public string MensajeById(string id)
        {
            var result = _service.GetMessage(id);

            return JsonConvert.SerializeObject(result);
        }

        [HttpPost]
        public IActionResult DeleteMensaje(string id, string key)
        {
            if (key == "supersecretkey321")
            {
                _service.Delete(new Guid(id));
            }
            return Ok("{}");
        }

        [HttpPost]
        public IActionResult Like(string id)
        {
             _service.Like(id);
            return Ok();
        }

        [HttpGet]
        public long Ttl()
        {
            var result = _service.GetTtl();
            return result;
        }

        [HttpGet]
        public string Undostrespericoingles()
        {
            var result = _service.GetAll();

            return JsonConvert.SerializeObject(result);
        }

        public IActionResult VerTodosLosMensajesAdmin()
        {
            var result = _service.GetAllMessages();
            ViewBag.Messages = result;
            return View(result);
        }
    }
}
