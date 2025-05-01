using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.VisualBasic.FileIO;
using WpfCarApp.Model.Classes;
using WpfCarApp.Model.RP;
using WpfCarApp.Model.RP.Interfaces;

namespace WpfCarApp.ViewModel
{
    internal class MainWindowViewModel: ViewModelBase
    {
        private readonly FileCarRepo _carRepo;
        

        public ObservableCollection<Car> Cars { get; set; } // From car.cs
                                                                // wanna use repo:
       

        public RelayCommand AddCommand => new RelayCommand(execute => AddCar());
            public RelayCommand DeleteCommand => new RelayCommand(execute => DeleteCar(), canExecute => SelectedCar != null);
            public RelayCommand SaveCommand => new RelayCommand(execute => Save(), canExecute => CanSave());

            public MainWindowViewModel()
            {
                Cars = new ObservableCollection<Car>();
            _carRepo = new FileCarRepo("Car.txt");//Enable it to save files.
            LoadCars(); // Load cars on startup
            }


            private Car _selectedCar;



            public Car SelectedCar
            {
                get { return _selectedCar; }
                set
                {
                    _selectedCar = value;
                    OnPropertyChanged();
                }
            }

            private void AddCar()
            {
                Cars.Add(new Car
                {
                    Brand = "brand",
                    Model = "model",
                    LicensePlate = "EX00000"

                });
            }
           

            private void DeleteCar()
            {
                Cars.Remove(SelectedCar);
            }

            private void Save()
            {
            _carRepo.UpdateAllCars(Cars);
            System.Windows.MessageBox.Show("Data has been saved successfully!", "Save Confirmation", MessageBoxButton.OK, MessageBoxImage.Information);
        }
            private bool CanSave()
            {
                return true;
            }
        private void LoadCars()
        {
            var carsFromFile = _carRepo.GetAllCars();
            Cars.Clear(); // In case Cars already has items
            foreach (var car in carsFromFile)
            {
                Cars.Add(car);
            }
        }

    }
}
