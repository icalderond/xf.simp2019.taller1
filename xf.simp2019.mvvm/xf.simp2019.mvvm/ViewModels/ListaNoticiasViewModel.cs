using System.Collections.Generic;
using xf.simp2019.mvvm.Models;

namespace xf.simp2019.mvvm.ViewModels
{
    public class ListaNoticiasViewModel : NotificationEnabledObject
    {
        public ListaNoticiasViewModel()
        {
            Inicializar();
        }

        private void Inicializar()
        {
            var noticias = new List<Noticia>
            {
                new Noticia
                {
                    Titulo="Comienza la clase de Xamarin hoy",
                    Descripcion="La clase se realizará en el Instituto Tecnologico de Nuevo Laredo",
                    Imagen="xamarin_image.jpg"
                },
                new Noticia
                {
                    Titulo="Torneo de futbol el fin de semana",
                    Descripcion="Este fin de semana se llevo a cabo el torneo en las canchas",
                    Imagen="xamarin_image.jpg"
                },
                new Noticia
                {
                    Titulo="Comienza la clase de Xamarin hoy",
                    Descripcion="La clase se realizará en el Instituto Tecnologico de Nuevo Laredo",
                    Imagen="xamarin_image.jpg"
                },
                new Noticia
                {
                    Titulo="Torneo de futbol el fin de semana",
                    Descripcion="Este fin de semana se llevo a cabo el torneo en las canchas",
                    Imagen="xamarin_image.jpg"
                },
                new Noticia
                {
                    Titulo="Comienza la clase de Xamarin hoy",
                    Descripcion="La clase se realizará en el Instituto Tecnologico de Nuevo Laredo",
                    Imagen="xamarin_image.jpg"
                },
                new Noticia
                {
                    Titulo="Torneo de futbol el fin de semana",
                    Descripcion="Este fin de semana se llevo a cabo el torneo en las canchas",
                    Imagen="xamarin_image.jpg"
                },
                new Noticia
                {
                    Titulo="Comienza la clase de Xamarin hoy",
                    Descripcion="La clase se realizará en el Instituto Tecnologico de Nuevo Laredo",
                    Imagen="xamarin_image.jpg"
                },
                new Noticia
                {
                    Titulo="Torneo de futbol el fin de semana",
                    Descripcion="Este fin de semana se llevo a cabo el torneo en las canchas",
                    Imagen="xamarin_image.jpg"
                },
                new Noticia
                {
                    Titulo="Comienza la clase de Xamarin hoy",
                    Descripcion="La clase se realizará en el Instituto Tecnologico de Nuevo Laredo",
                    Imagen="xamarin_image.jpg"
                },
                new Noticia
                {
                    Titulo="Torneo de futbol el fin de semana",
                    Descripcion="Este fin de semana se llevo a cabo el torneo en las canchas",
                    Imagen="xamarin_image.jpg"
                },
                new Noticia
                {
                    Titulo="Comienza la clase de Xamarin hoy",
                    Descripcion="La clase se realizará en el Instituto Tecnologico de Nuevo Laredo",
                    Imagen="xamarin_image.jpg"
                },
                new Noticia
                {
                    Titulo="Torneo de futbol el fin de semana",
                    Descripcion="Este fin de semana se llevo a cabo el torneo en las canchas",
                    Imagen="xamarin_image.jpg"
                },
                new Noticia
                {
                    Titulo="Comienza la clase de Xamarin hoy",
                    Descripcion="La clase se realizará en el Instituto Tecnologico de Nuevo Laredo",
                    Imagen="xamarin_image.jpg"
                },
                new Noticia
                {
                    Titulo="Torneo de futbol el fin de semana",
                    Descripcion="Este fin de semana se llevo a cabo el torneo en las canchas",
                    Imagen="xamarin_image.jpg"
                }
            };

            Noticias = noticias;
        }

        private List<Noticia> _Noticias;

        public List<Noticia> Noticias
        {
            get { return _Noticias; }
            set { _Noticias = value;
                OnPropertyChanged();
            }
        }
    }
}