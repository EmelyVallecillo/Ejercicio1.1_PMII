using Microsoft.Maui.Controls;
namespace Tarea1._1_Ejercicio;

public partial class Resultado : ContentPage
{
	public  Resultado(double resultado)
	{
		InitializeComponent();
        ResultadoLabel.Text = $"Resultado:  {resultado}";
    }

private async void OnVolverClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }


}