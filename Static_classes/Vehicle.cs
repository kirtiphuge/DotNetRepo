using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Assignments
{
    class Vehicle
    {
        public string vehicleType;
        public string name;

        public Vehicle()
        {
            this.vehicleType = null;
            this.name = null;

        }

        public virtual void showDetail()
        {
            Console.Write("Heloo");
        }
    }

    class car : Vehicle
    {
        String modelType;

         public car(string _name, string _vehicleTye,string _model)  
        {
            this.vehicleType = _vehicleTye;
            this.name = _name;
            this.modelType = _model;

        }

        public override void showDetail()
        {
            
            Console.Write("\n NAME :"+name + "\tTYPE :"+vehicleType + "\tMODEL :"+modelType );
        }
    }

    class twoWheeler : Vehicle
    {
        String modelType;

        public twoWheeler(string _name, string _vehicleTye, string _model)
        {
            this.vehicleType = _vehicleTye;
            this.name = _name;
            this.modelType = _model;
        }

        public override void showDetail()
        {

            Console.Write("\n NAME :" + name + "\tTYPE :" + vehicleType + "\tMODEL :" + modelType);
        }
    }
}
