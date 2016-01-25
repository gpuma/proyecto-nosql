using System.Collections.Generic;
using MongoDB;

namespace MongoDBBlog.Prueba
{
    public class Post 
    {
        public Oid Id { get; private set; }
        public string Titulo { get; set; }
        public string Contenido { get; set; }
        public int Longitud { get; set; }
        public IList<Comentario> Comentarios { get; set; }
    }
}