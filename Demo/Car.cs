using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class Car
    {
        private string _model;
        private string _color;
        private string _year;
        private string FullDetsils;

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public string Year
        {
            get { return _year; }
            set { _year = value; }
        }

        public string FullDetails
        {
            get { return FullDetsils = _model + " " + _color + " "+ _year; }
            set { FullDetsils = value; }
        }


    }
}
