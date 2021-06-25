using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public class Car
    {


        // private string _CarName = "Honda City";
        private string _CarColur = "Black";

        private string _CarName = "Honda City";

        public string CarColur
        {
            get { return _CarColur; }
            set { _CarColur = value; }
        }
        public string CarName
        {
            get { return _CarName; }
            set { _CarName = value; }
        }


        public void Gear()
        {
            Console.WriteLine("Appling break on car");

        }

        private void engineofthecar()
        {
            Console.WriteLine("Engine is ruuing");

        }

       
    }

    public class OutSideWorld
    {
        static void Main(string[] args)
        {

            Car car = new Car();
            car.Gear();

            Console.ReadKey();

        }
    }



}
