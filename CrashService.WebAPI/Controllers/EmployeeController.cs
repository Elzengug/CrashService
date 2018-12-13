using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrashService.BLL.Contracts;
using CrashService.DAL.Models.DomainModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CrashService.WebAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/Employee")]
    public class EmployeeController : Controller
    {
        private readonly IClientService _clientService;
        private readonly IDetectorService _detectorService;

        public EmployeeController(IDetectorService detectorService, IClientService clientService)
        {
            _clientService = clientService;
            _detectorService = detectorService;
        }


        [HttpGet]
        public async Task<IActionResult> GetClients()
        {
            var clients = await _clientService.GetAllClientsAsync();
            return Ok(clients);
        }

        [HttpPost]
        [Route("AddClient")]
        public async Task<IActionResult> AddClient(Client client)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _clientService.CreateClientAsync(client);
            return Ok();
        }
    }

}