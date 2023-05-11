using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.ViewModel
{
    internal partial class MainWindowViewModel : ObservableObject
    {
        [ObservableProperty] private Car selectedCar;

        [RelayCommand]
        private void GenerateRandomCar()
        {
            string[] marks = { "Toyota", "Honda", "BMW", "Ford", "Chevrolet" };
            string[] colors = { "Red", "Yellow", "White" };
            Car car = new Car()
            {
                Color = colors[new Random().Next(0, colors.Length)],
                Marka = marks[new Random().Next(0, marks.Length)]
            };

            SelectedCar = car;

        }

    }
}
