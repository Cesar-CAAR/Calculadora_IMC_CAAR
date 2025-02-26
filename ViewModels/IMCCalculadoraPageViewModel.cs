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
        public double peso;

        [ObservableProperty]
        public double altura;

        public double IMCPuntuacion => Math.Round(Peso / Math.Pow(Altura / 100, 2), 2);


        public string IMCDescripcion
        {
            get
            {
                if (IMCPuntuacion < 18.5)
                {
                    return "Tienes bajo peso";
                }
                else if (IMCPuntuacion >= 18.5 && IMCPuntuacion <= 24.9)
                {
                    return "Tu peso es normal";
                }
                else if (IMCPuntuacion >= 25 && IMCPuntuacion <= 29.9)
                {
                    return "Tienes sobre peso";
                }
                else
                {
                    return "Tienes Obesidad, cuidate";
                }
            }
        }
    }
}
