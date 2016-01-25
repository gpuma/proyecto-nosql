using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using MongoDB.Linq;

namespace MongoDBBlog.Prueba
{
    public partial class BlogFrm : Form
    {
        internal MongoDB.IMongoCollection<Post> coleccion;
        private bool inicializado = false;
        private List<Post> posts;

        public BlogFrm(MongoDB.IMongoCollection<Post> coleccion)
        {
            InitializeComponent();
            this.coleccion = coleccion;
            gridComentarios.AutoGenerateColumns = false;
            gridPosts.AutoGenerateColumns = false;
            posts = coleccion.Linq().ToList();
        }

        //carga los datagridviews con los datos extraidos de la base de datos enviados
        //por nuestro programa principal
        private void PoblarInterfaz()
        {
            gridPosts.DataSource = posts;
            //si no hay celda seleccionada el índice es 0 (primer elemento)
            var indicePost = gridPosts.CurrentCell == null ? 0 : gridPosts.CurrentCell.RowIndex;
            var comentarios = indicePost < 0 ? null : posts[indicePost].Comentarios;
            gridComentarios.DataSource = comentarios;
        }

        private void gridPosts_SelectionChanged(object sender, EventArgs e)
        {
            //para evitar que se poble cuando el formulario recién se está construyendo
            if(inicializado)
                PoblarInterfaz();
        }

        private void BlogFrm_Load(object sender, EventArgs e)
        {
            PoblarInterfaz();
            inicializado = true;
        }

        //usamos un mismo formulario para agregar posts o comentarios
        private void NuevaEntrada(object sender, EventArgs e)
        {
            var modo = sender == btnNuevoPost ? "POST": "COMENTARIO";
            var nuevo = new NuevoFrm(modo, this);
            nuevo.ShowDialog();
            //actualizamos nuestra lista
            posts = coleccion.Linq().ToList();
            PoblarInterfaz();
        }

        public Post ObtenerPostActual()
        {
            //igual que arriba
            return posts[gridPosts.CurrentCell == null ? 0 : gridPosts.CurrentCell.RowIndex];
        }
    }
}
