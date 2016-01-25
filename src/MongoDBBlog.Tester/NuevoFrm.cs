using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MongoDBBlog.Prueba
{
    public partial class NuevoFrm : Form
    {
        string modo;
        BlogFrm padre;
        public NuevoFrm(string modo, BlogFrm padre)
        {
            InitializeComponent();
            this.padre = padre;
            this.modo = modo;
            //mostramos ciertos controles dependiendo del tipo de objeto a ingresar
            switch (this.modo)
            {
                case "POST":
                    this.Text = "Nuevo post";
                    txtEmail.Visible = false;
                    lblEmail.Visible = false;
                    break;
                case "COMENTARIO":
                    this.Text = "Nuevo comentario";
                    txtTitulo.Visible = false;
                    lblTitulo.Visible = false;
                    break;
            }
        }

        //upsert a la base de datos
        private void btnOK_Click(object sender, EventArgs e)
        {
            Post post = null;
            switch (this.modo)
            {
                case "POST":
                    post = new Post()
                    {
                        Titulo = txtTitulo.Text,
                        Contenido = txtContenido.Text,
                        Longitud = txtContenido.Text.Length,
                        //no podemos enviarla nula
                        Comentarios = new List<Comentario> { }
                    };
                    break;
                case "COMENTARIO":
                    var comentario = new Comentario()
                    {
                        Contenido = txtContenido.Text,
                        Email = txtEmail.Text,
                        FechaPosteo = DateTime.Now
                    };
                    post = padre.ObtenerPostActual();
                    post.Comentarios.Add(comentario);
                    break;
            }
            padre.coleccion.Save(post);
            this.Dispose();
        }
    }
}
