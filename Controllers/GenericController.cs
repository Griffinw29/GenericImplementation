using FacilitiesTicketingAPI.Interfaces;
using FacilitiesTicketingAPI.Models.ViewModels;
using FacilitiesTicketingAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FacilitiesTicketingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]    
    public class GenericController<T> : BaseController
    {
        private readonly IGenericService<T> service;
        public GenericController(IGenericService<T> _service)
        {
            service = _service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<T>>> GetAsync()
        { 
            return Ok(await service.GetList());
        }

    }
}
