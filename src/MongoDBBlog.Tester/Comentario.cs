using System;

namespace MongoDBBlog.Prueba
{
    public class Comentario
    {
        public DateTime FechaPosteo { get; set; }
        public string Email { get; set; }
        public string Contenido { get; set; }
    }
}
