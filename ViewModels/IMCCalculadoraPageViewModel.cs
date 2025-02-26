using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_IMC_CAAR.ViewModels
{
    public partial class IMCCalculadoraPageViewModel : ObservableObject
    {
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IMCPuntuacion))]
        [NotifyPropertyChangedFor(nameof(IMCResultado))]
        private double peso;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IMCPuntuacion))]
        [NotifyPropertyChangedFor(nameof(IMCResultado))]
        private double altura;

        public double IMCPuntuacion
        {
            get
            {
                if (Altura <= 0)
                    return 0; // Evita la división por cero
                return Math.Round(Peso / Math.Pow(Altura / 100, 2), 2);
            }
        }

        public string IMCResultado
        {
            get
            {
                double imc = IMCPuntuacion;
                if (imc == 0)
                    return "Altura no válida";

                if (imc < 18.5)
                    return "Tienes bajo peso";
                else if (imc < 25)
                    return "Tu peso es normal";
                else if (imc < 30)
                    return "Tienes sobrepeso";
                else
                    return "Tienes obesidad, cuídate";
            }
        }
    }
}
