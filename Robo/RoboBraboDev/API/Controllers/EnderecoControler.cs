using Domain.Entidades;
using Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EnderecoControler : ControllerBase
    {
        private readonly IEnderecoService _service;
        public async Task<IActionResult> Add(List<EnderecoModel> model)
        {

        }
    }
}
