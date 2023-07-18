using Eventos.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Eventos.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventoController : ControllerBase
{


    

    public EventoController()
    {
    }

    [HttpGet]
    public Evento Get()
    {
        return new Evento(){
            Id = 1,
            Tema = "Angular 11 e .NET 5",
            Local = "Belo Horizonte",
            Lote = "Primerio Lote",
            QtdPessoas = 250,
            DataEvento = DateTime.Now.AddDays(2).ToString()
        };
    }
}
