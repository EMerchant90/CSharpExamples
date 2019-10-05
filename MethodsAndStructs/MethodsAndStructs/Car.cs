using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndStructs
{
    struct Car
    {
        public double Speed
        {
            get
            {
                return _speed;
            }

            set
            {
                if (_speed != value)
                {
                    _speed = value;
                }
            }

        }

        private double _speed;
        //car struct
        //speed property of type double
        //print out speed each time getter is called
        //print out new speed each time setter is called
    }
}
