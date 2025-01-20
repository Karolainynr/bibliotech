using Bibliotech.Api.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Bibliotech.Api.Controllers;

[ApiController]
[Route("api/aussuntos")]
public class AssuntoController : ControllerBase
{
    [HttpGet("buscar")]

    public IActionResult Buscar(string nomeAutor)
    {
        //TODO: acessar o banco de dados e pesquisar.


        return Ok();
    }
}


//niveis de acesso
//protected = amigo do peito
//public = todo mundo sabe de tudo
//private = nunguem tem acesso, somente eu
//internal = só a galera do grupo

//namespace