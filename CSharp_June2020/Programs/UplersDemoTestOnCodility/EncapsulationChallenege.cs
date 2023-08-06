using System;
using System.Collections;
using System.Collections.Generic;

namespace Interview.Programs.UplersDemoTestEncapsulation
{
    public class EncapsulationChallenege
    {

        static void Main()
        {

            // A sample showing how CustomStringEnumerator & EnumeratorConfig will be used
            var collection = new string[] { "Jai","Simran","Neha", "a", "", null, "testt", "Test", "Something", "SomethingSomething" };
            var config = new EnumeratorConfig
            {
                MinLength = 3,
                MaxLength = 10,
                StartWithCapitalLetter = true
            };

            // The custom enumerator will return strings that are longer or equal to 3 charaters
            // and shorter or equal 10 characters and start with a capital letter.
            var enumerator = new CustomStringEnumerator(collection, config);
            foreach (var s in enumerator)
            {
                Console.WriteLine(s);
            }
        }

    }

    // Do not change the name of this class
    // Do not change the name of this class
    // Do not change the name of this class
    public class CustomStringEnumerator : IEnumerable<string>
    {

        private readonly IEnumerable<string> collection;
        private readonly EnumeratorConfig config;

        /// <summary> Constructor </summary>
        /// <exception cref="System.ArgumentNullException">If a collection is null</exception>
        /// <exception cref="System.ArgumentNullException">If an config is null</exception>
        public CustomStringEnumerator(IEnumerable<string> collection, EnumeratorConfig config)
        {
            // Console.WriteLine("Sample debug output");
            this.collection = collection;
            this.config = config;
        }

        public IEnumerator<string> GetEnumerator()
        {
            if (collection == null)
            {
                yield break;
            }
            foreach (var item in collection)
            {
                if (CheckStringIsValid(item))
                {
                    yield return item;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        private bool CheckStringIsValid(string item)
        {
            if (string.IsNullOrEmpty(item))
                item=string.Empty;

            int length = item.Length;
            if (length >= config.MinLength &&
           length <= config.MaxLength &&
           (item.Length == 0 || !config.StartWithCapitalLetter || char.IsUpper(item[0])))
            {
                return true;
            }

            return false;
        }
    }





    // Your implementation of CustomStringEnumerator should take into account all the properties of EnumeratorConfig
    public class EnumeratorConfig
    {
        // Specifies the minimal length of strings that should be returned by a custom enumerator.
        // If it is set to negative value then this option is ignored.
        public int MinLength { get; set; } = -1;

        // Specifies the maximum length of strings that should be returned by a custom enumerator.
        // If it is set to negative value then this option is ignored.
        public int MaxLength { get; set; } = -1;

        // Specifies that only strings that start with a capital letter should be returned by a custom enumerator.
        // Please note that empty or null strings do not meet this condition.
        public bool StartWithCapitalLetter { get; set; }

        // Specifies that only strings that start with a digit should be returned by a custom enumerator.
        // Please note that empty or null strings do not meet this condition.
        public bool StartWithDigit { get; set; }
    }

}


