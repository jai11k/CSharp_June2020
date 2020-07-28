using System;
namespace CSharp_June2020.Ch3_OOP.DataProtection
{

    class Temprature
    {
        //declare private array of float type.
        private float[] weekTemp =
            { 47.5F, 40.0F, 52.5F, 45.5F, 48.0F, 38.0F, 35.7F };

        //use float indexer, to encapsulate weekTemp
        public float this[int index]
        {
            get
            {
                return weekTemp[index];
            }
            set
            {
                weekTemp[index] = value;
            }
        }
    }
    public class Indexers
    {
        static void Main(string[] args)
        {
            Temprature temp = new Temprature();
            float todayTemp = temp[1]; //read
            temp[1] = -5.0F; //Write
        }
    }
}
