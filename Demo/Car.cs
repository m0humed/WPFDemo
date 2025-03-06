using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
namespace Demo
{
    public class Car:INotifyPropertyChanged
    {
        private string _model;
        private string _color;
        private string _year;
        private string FullDetsils;

        public string Model
        {
            get { return _model; }
            set
            {
                if (value != null)
                {
                    if (_model != null)
                        OnPropertyChanged("Model");
                    _model = value;
                  
                }
            }
        }

        public string Color
        {
            get { return _color; }
            set
            {
                if (value != null)
                {
                    if (_color != null)
                        OnPropertyChanged("Color");
                    _color = value;
                   
                }
            }
        }

        public string Year
        {
            get { return _year; }
            set {
                if (value != null)
                {
                    if (_year != null)
                        OnPropertyChanged("Year");
                    _year = value;
                   
                }
            
            }
        }

        public string FullDetails
        {
            get { return FullDetsils = _model + " " + _color + " "+ _year; }
            set { FullDetsils = value; }
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
