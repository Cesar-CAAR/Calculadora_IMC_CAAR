﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Calculadora_IMC_CAAR.ViewModels
{
    public partial class EmployeePageViewModel : ObservableObject
    {
        [ObservableProperty]
        public string empName;


        [RelayCommand]
        public void Guardar()
        {
        
        }
    }
}
