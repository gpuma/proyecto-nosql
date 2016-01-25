using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using MongoDB;
using MongoDB.Linq;

namespace MongoDBBlog.Prueba
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creamos el objecto mongo por defecto que se encarga de nuestras conexiones a la BD
            //por defecto, se conecta a localhost en el puerto 27017, en el que debería estar escuchando el servidor
            var mongo = new Mongo();
            mongo.Connect();

            //obtenemos la BD blog. si no existe mongoDB la creará la primera vez que la usemos
            var db = mongo.GetDatabase("blog");

            //Obtenemos la colección Post. Por defecto, utilizaremos el nombre de la clase como el nombre de la
            //colección. Igualmente que arriba, si no existe será creada en su primer uso.
            var collection = db.GetCollection<Post>();

            //esto borra todo de la colección cada vez que corremos el programa
            collection.Remove(p => true);

            //creamos los posts para ingresar a la BD
            CrearPosts(collection);

            //contamos todos los posts
            var nroTotalPosts = collection.Count();

            //contamos posts con solo un comentario
            var nroPostsCon1Comentario = collection.Count(p => p.Comentarios.Count == 2);

            //contamos posts en los que comentó tupapa
            var postsDeTupapa = from p in collection.Linq()
                                           where p.Comentarios.Any(c => c.Email.StartsWith("tupapa"))
                                           select p.Titulo;

            //obtenemos los títulos y comentarios de los posts que tenga comentarios después del primero de enero
            var postsDespuésDel1ero = from p in collection.Linq()
                                      where p.Comentarios.Any(c => c.FechaPosteo > new DateTime(2014, 1, 1))
                                      select new { Title = p.Titulo, Comments = p.Comentarios };

            //encontramos posts con menos de 40 caracteres
            var postsConMenosDe40Chars = from p in collection.Linq()
                                           where p.Longitud < 40
                                           select p;


            //obtenemos el número de caracteres en total de todos los posts
            
            //manual map-reduce (para efectos de comparación)
            var sum = Convert.ToInt32(collection.MapReduce()
                .Map(new Code(@"
                    function() {
                        emit(1, this.CharCount);
                    }"))
                .Reduce(new Code(@"
                    function(key, values) {
                        var sum = 0;
                        values.forEach(function(prev) {
                            sum += prev;
                        });
                        return sum;
                    }"))
                .Documents.Single()["value"]);

            //usamos linq para construir automáticamente la consulta de arriba
            //como vemos es muchísimo más simple
            var linqSum = (int)collection.Linq().Sum(p => p.Longitud);

            //crear manualmente la sgte consulta sería tediosísimo
            var stats = from p in collection.Linq()
                        where p.Comentarios.Any(c => c.Email.StartsWith("troll"))
                        group p by p.Longitud < 40 into g
                        select new
                        {
                            LessThan40 = g.Key,
                            Sum = g.Sum(x => x.Longitud),
                            Count = g.Count(),
                            Average = g.Average(x => x.Longitud),
                            Min = g.Min(x => x.Longitud),
                            Max = g.Max(x => x.Longitud)
                        };

            //corremos nuestro form
            Application.Run(new BlogFrm(collection));
        }

        //poblamos la BD con unos cuantos posts y comentarios
        private static void CrearPosts(IMongoCollection<Post> collection)
        {
            var post = new Post()
            {
                Titulo = "mi primer post",
                Contenido = "hola amigos soy nuevo en esto",
                Longitud = 27,
                Comentarios = new List<Comentario>
                {
                    { new Comentario() { 
                        FechaPosteo = new DateTime(2014,1,1),
                        Email = "anonimo@gmail.com",
                        Contenido = "es un post demasiado corto" } },
                    { new Comentario() {
                        FechaPosteo = new DateTime(2014,1,2),
                        Email = "troll@gmail.com",
                        Contenido = "estoy de acuerdo con anónimo" } }
                }
            };

            //guardamos el post. esto realiza un upsert, es decir, si no existe se inserta, caso contrario, se actualiza.
            collection.Save(post);

            //obtenemos el primer post que no corresponda
            post = collection.Linq().First(x => x.Longitud != x.Contenido.Length);

            post.Longitud = post.Contenido.Length;

            //esto resulta en un update ya que ya insertamos el registro
            collection.Save(post);

            post = new Post()
            {
                Titulo = "Mi Segundo Post",
                Contenido = "Este post no es largo",
                Longitud = 34,
                Comentarios = new List<Comentario>
                {
                    { new Comentario() { FechaPosteo = new DateTime(2014,1,1), Email = "tupapa@gmail.com", Contenido = "Parece que no has mejorad." } },
                }
            };

            //guardamos el post. esto realiza un upsert, es decir, si no existe se inserta, caso contrario, se actualiza.
            collection.Save(post);

            post = new Post()
            {
                Titulo = "Mi tercer post",
                Contenido = "Bueno este post si es mucho más grande así que espero que esten contentos",
                Longitud = 69,
                Comentarios = new List<Comentario>
                {
                    { new Comentario() { FechaPosteo = new DateTime(2014,1,1), Email = "tupapa@gmail.com", Contenido = "No calificaría a esto como un post." } },
                }
            };

            //guardamos el post. esto realiza un upsert, es decir, si no existe se inserta, caso contrario, se actualiza.
            collection.Save(post);
        }
    }
}