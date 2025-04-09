using CRMApplicationWeb.Services;
using Microsoft.AspNetCore.Mvc;

namespace CRMApplicationWeb.Controllers
{
    public class ClientController : Controller
    {
        private readonly ClientService _clientService;

        public ClientController(ClientService clientService)
        {
            _clientService = clientService;
        }

        public async Task<IActionResult> Index()
        {
            var clients = await _clientService.GetClient();
            return View(clients);
        }
    }
}