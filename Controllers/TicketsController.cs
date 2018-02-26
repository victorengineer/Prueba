using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Prueba.Models.TicketsViewsModels;

namespace Prueba.Controllers
{
    public class TicketsController : Controller
    {
        public IActionResult Index(){
            var model = new List<VerTicketModel>();
            model.Add(new VerTicketModel(){
                Descripcion = "No tengo internet",
                Numero =  1,
                Estado = "Abierto",
                Categoria = "Internet",
                UltimaRespuesta = "reiniciaste el modem?"

            });
            

            model.Add(new VerTicketModel(){
                Descripcion = "No tengo internet",
                Numero =  2,
                Estado = "Abierto",
                Categoria = "Internet",
                UltimaRespuesta = "reiniciaste el modem?"

            });
            
        

        model.Add(new VerTicketModel(){
                Descripcion = "No tengo internet",
                Numero =  3,
                Estado = "Abierto",
                Categoria = "Internet",
                UltimaRespuesta = "reiniciaste el modem?"

            });
            return View(model);
        }
        
    }
}