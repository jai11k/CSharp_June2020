using System;
namespace Ch3_OOP
{
   
    class Parent2
    {
        public string SurName { get; set; }
    }
    class Child2 : Parent2
    {
        private string _name;
        public string Name
        {
            get
            {
                return (_name + " " + base.SurName);
            }
            set
            {
                Name = value;
            }
        }
    }




}
