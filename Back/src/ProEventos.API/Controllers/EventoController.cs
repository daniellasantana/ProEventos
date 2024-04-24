using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using ProEventos.API.Models;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ProEventos.API.Controllers
    {
    [ApiController]
    [Route("api/[controller]")]
public class EventoController : ControllerBase
{
        public IEnumerable<Evento>  _evento = new Evento[] {
             new Evento() {
                EventoId = 1,
                Tema = "Angular 11 e .NET 5",
                Local = "Belo Horizonte",
                Lote = "1º Lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                ImageUrl = "foto.png"
                },
            new Evento() {
                EventoId = 2,
                Tema = "Angular e suas novidades",
                Local = "São Paulo",
                Lote = "2º Lote",
                QtdPessoas = 350,
                DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
                ImageUrl = "foto1.png"
                }
            };  

            [HttpGet]

            public IEnumerable<Evento> Get()
            {
                return (IEnumerable<Evento>)_evento;
            }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(evento => evento.EventoId == id);
        }


        [HttpPost]
        public string Post()
        {
            return "Exemplo de Post";
        }
}
}

   