using System;
using System.Collections.Generic;

namespace Ch3_OOP
{

    #region jaankari
    /*
Indexers are used to encapsulate the value of an array. It behaves and works like property.
It also uses access specifiers, which give better control to read, write, or manipulate an
array’s value. It creates a sandbox over an array, which protects it from:
1. saving false data in an array;
2. using the wrong index value in an array;
3. changing the reference of an array from the outer world.
     */
    #endregion


    public class Indexers
    {
        static void Main(string[] args)
        {
            Temprature temp = new Temprature();
            float todayTemp = temp[1]; //read
            temp[1] = -5.0F; //Write

            Temprature temp2 = new Temprature();
            float todayTemp2 = temp[1]; //read
            temp[1] = -5.0F; //Write
        }
    }




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

}
