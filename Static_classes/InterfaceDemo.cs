using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Assignments
{
    interface VehicleBase
    {
       void showDetail();
    }

    class car1 : VehicleBase
    {
        string modelType;
        public string vehicleType;
        public string name;

        public car1(string _name, string _vehicleTye, string _model)
        {
            this.vehicleType = _vehicleTye;
            this.name = _name;
            this.modelType = _model;

        }

        public void showDetail()
        {

            Console.Write("\n NAME :" + name + "\tTYPE :" + vehicleType + "\tMODEL :" + modelType);
        }
    }

    class twoWheeler1 : VehicleBase
    {
        string modelType;
        public string vehicleType;
        public string name;

        public twoWheeler1(string _name, string _vehicleTye, string _model)
        {
            this.vehicleType = _vehicleTye;
            this.name = _name;
            this.modelType = _model;
        }

        public void showDetail()
        {

            Console.Write("\n NAME :" + name + "\tTYPE :" + vehicleType + "\tMODEL :" + modelType);
        }
    }
}
