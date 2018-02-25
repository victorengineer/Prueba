### Modulos - Estudiante

* El estudiante podra pedir un ticket de una categoria predefinida.
* El estudiante podra escribir una descripcion de su problema.
* Tendra un acceso a su tickets abiertos.
* Tendra un acceso a sus tickets ya resueltos.
* Podra dar seguimiento a un ticket en particular:
    * Actualizar la descripcion.
    * Cancelar ticket.
    * Subir una imagen. 

### Modelos:
* VerTicketModel
    * Estado
    * LaUltimaRespuesta
    * Categoria
    * Descripcion
    * NumeroTicket
* AbrirTicket
    * Imagen
    * Detalle
    * Categoria
* AgregarComentario
    * Mensaje
    * NumeroTicket
* ActualizarDescripcion
    * NuevaDescripcion
    * NumeroTicket
* CancelarTicket
    * NumeroTicket
* AdjuntarArchivo
    * Archivo
    * NumeroTicket