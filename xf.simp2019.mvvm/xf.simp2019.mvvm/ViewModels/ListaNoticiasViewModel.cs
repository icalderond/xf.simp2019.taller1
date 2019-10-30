using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
                }
            };

            Noticias = new ObservableCollection<Noticia>(noticias);
        }

        private ObservableCollection<Noticia> _Noticias;

        public ObservableCollection<Noticia> Noticias
        {
            get { return _Noticias; }
            set
            {
                _Noticias = value;
                OnPropertyChanged();
            }
        }

        private ActionCommand<string> _CrearNoticiaCommand;

        public ActionCommand<string> CrearNoticiaCommand
        {
            get
            {
                if (_CrearNoticiaCommand == null)
                {
                    _CrearNoticiaCommand = new ActionCommand<string>((obj) =>
                       {
                           Noticias.Add(new Noticia
                           {
                               Titulo = Guid.NewGuid().ToString(),
                               Descripcion = "Esta mañana se registraron temperaturas de hasta 9 grados",
                               Imagen = "xamarin_image.jpg"
                           });
                       } );
                }
                return _CrearNoticiaCommand;
            }
            set
            {
                _CrearNoticiaCommand = value;
                OnPropertyChanged();
            }
        }
    }
}