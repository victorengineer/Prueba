using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;

namespace Prueba.Models.TicketsViewsModels
{
    public class VerTicketModel{
        public int Numero{ get; set;}

        public string Estado{get; set;}
        
        public string UltimaRespuesta{get; set;}

        public string Categoria{get; set;}
        
        public string Descripcion { get; set; }
    }

    public class DetallesTicketModel{
        public int Numero{get;set;}

        public int Estado { get; set; }

        public int Descripcion { get; set; }

        public int Categoria { get; set; }
    }

    public class AbrirTicketModel{
        public string Categoria { get; set; }

        public string Imagen{ get; set; }

        public string Detalles { get; set; }
    }

    public class AgregarComentariosModel{
        public string Mensaje { get; set; }

        public string Numero{ get; set; }

    }

    public class ActualizarDescripcionModel{
        public string Numero { get; set; }

        public string NuevaDescripcion { get; set; }
    }

    public class CancelarTicketModel{
        public string NumeroTicket { get; set; }
    }

    public class AdjuntarArchivoModel{
        public string NumeroTicket { get; set; }

        public string Archivo { get; set; }
    }

}