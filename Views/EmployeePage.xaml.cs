using Calculadora_IMC_CAAR.ViewModels;

namespace Calculadora_IMC_CAAR.Views;

public partial class EmployeePage : ContentPage
{
	public EmployeePage()
	{
		InitializeComponent();
		this.BindingContext = new EmployeePageViewModel();
    }
}