using Calculadora_IMC_CAAR.ViewModels;

namespace Calculadora_IMC_CAAR.Views;

public partial class IMCCalculadoraPage : ContentPage
{
	public IMCCalculadoraPage()
	{
		InitializeComponent();
		this.BindingContext = new IMCCalculadoraPageViewModel();
    }
}