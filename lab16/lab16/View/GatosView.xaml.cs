using lab16.ViewModels;
using System;
using Xamarin.Forms;

namespace lab16.View
{
    public partial class GatosView : ContentPage
    {
        private ApiManager _apiManager;

        public GatosView()
        {
            InitializeComponent();
            _apiManager = new ApiManager();
            LoadData();
        }

        private async void LoadData()
        {
            try
            {
                Console.WriteLine("Iniciando carga de datos...");

                var cats = await _apiManager.GetGatosAsync();

                // Imprimir datos en la consola
                foreach (var cat in cats)
                {
                    Console.WriteLine($"Nombre: {cat.nombre}, Características: {cat.caracteristicas}, Tamaño: {cat.tamano}");
                }

                // Asignar la lista de gatos al origen de datos del ListView
                gatosListView.ItemsSource = cats;

                // Notificar a la interfaz de usuario que los datos han cambiado
                OnPropertyChanged(nameof(cats));

                Console.WriteLine("Datos cargados correctamente.");
            }
            catch (Exception ex)
            {
                // Imprimir detalles del error en la consola
                Console.WriteLine($"Error: {ex.Message}");
                // Manejar errores aquí
            }
        }
    }
}
