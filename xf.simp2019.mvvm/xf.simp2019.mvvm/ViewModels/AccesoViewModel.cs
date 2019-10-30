namespace xf.simp2019.mvvm.ViewModels
{
    public class AccesoViewModel : NotificationEnabledObject
    {
        private string _usuario;
        public string Usuario
        {
            get => _usuario;
            set
            {
                _usuario = value;
                OnPropertyChanged();
            }
        }

        private string _Clave;
        public string Clave
        {
            get => _Clave;
            set
            {
                _Clave = value;
                OnPropertyChanged();
            }
        }

        private ActionCommand<string> _AccederCommand;

        public ActionCommand<string> AccederCommand
        {
            get
            {
                if (_AccederCommand == null)
                {
                    _AccederCommand = new ActionCommand<string>(async (param) =>
                    {
                        bool aceptaNavegar = await App.Current.MainPage.DisplayAlert("Cuadro de mensaje", $"Hola {param} ¿deseas ir a la siguiente pagina?", "No", "Si");

                        if (aceptaNavegar)
                        {
                            await App.Current.MainPage.Navigation.PushAsync(new Views.ListaNoticias());
                            //await App.Current.MainPage.DisplayAlert("Cuadro de mensaje", $"Si funcionó {_usuario}", "Ok");
                        }
                    });
                }
                return _AccederCommand;
            }
            set
            {
                _AccederCommand = value;
                OnPropertyChanged();
            }
        }

    }
}