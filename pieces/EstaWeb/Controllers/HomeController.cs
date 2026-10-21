using System;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EstaWeb.Models;
using EstaWebSeAutodestruira;
using FcLibrary;
using Newtonsoft.Json;

namespace EstaWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MessageService _messageService;
        private readonly FcHttpService _fcHttpServiceService;

        public HomeController(ILogger<HomeController> logger, MessageService messageService, FcHttpService fcHttpServiceService)
        {
            _logger = logger;
            _messageService = messageService;
            _fcHttpServiceService = fcHttpServiceService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult IndexById(string id)
        {
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
        public async Task<IActionResult> Mensaje([FromBody]string text)
        {
            if (!string.IsNullOrEmpty(text))
            {
                var message = _messageService.GetRandomDto();
                //await _fcService.SendMessage(message.Text, 7924569, text);
                await _fcHttpServiceService.SendMessage(message.Text, 7927033, text);

            }
            return Ok("{}");
        }

        [HttpGet]
        public string Mensaje()
        {
            var result = _messageService.GetRandomDto();

            return JsonConvert.SerializeObject(result);
        }

        [HttpPost]
        public IActionResult DeleteMensaje(string id, string key)
        {
            if (key == "supersecretkey321")
            {
                _messageService.Delete(new Guid(id));
            }
            return Ok("{}");
        }

        [HttpPost]
        public IActionResult Like(string id)
        {
             _messageService.Like(id);
            return Ok();
        }

        [HttpGet]
        public string Undostrespericoingles()
        {
            var result = _messageService.GetAll();

            return JsonConvert.SerializeObject(result);
        }

        public IActionResult VerTodosLosMensajesAdmin()
        {
            var result = _messageService.GetAllMessages();
            ViewBag.Messages = result;
            return View(result);
        }
    }
}
