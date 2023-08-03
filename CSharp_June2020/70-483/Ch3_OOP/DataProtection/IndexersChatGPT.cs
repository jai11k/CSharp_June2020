using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_June2020._70_483.Ch3_OOP.DataProtection
{
    #region jaankari
    /*
    //indexer is a special property that allows you to access elements of a class or struct using array-like syntax.
    It provides a way to retrieve or set values in an object as if it were an array, making the object behave like a collection. 
     */
    #endregion

   

    public class IndexersChatGPT
    {
        private string[] data;

        public IndexersChatGPT()
        {
            data = new string[5];
        }

        // Indexer definition
        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < data.Length)
                    return data[index];
                else
                    throw new IndexOutOfRangeException("Index out of range");
            }
            set
            {
                if (index >= 0 && index < data.Length)
                    data[index] = value;
                else
                    throw new IndexOutOfRangeException("Index out of range");
            }
        }
    }

}
