using System;
namespace Ch3_OOP
{

    #region jaankari
    //pgNo-67 kudvenkat too
    /*
1. Public  --- any one can access from any assembly
2. Private --- sirf apni class ke andar
3. Protected -- apni class ke andar + derived class k andar
4. Internal --- assemnly me koi bhi access kr skta hai(by default classes are internal)
5. Protected Internal ---union of Protected & Internal,
    Members defined with internal protected access
    specifiers are accessible within as well as outside the class and also to its child
    classes. But they aren’t accessible to any class which is defined outside the project’s
    assembly scope.

//TODO
    5. ?
6. private protected?



   
     */
    #endregion
    public class AccessSpecifiers
    {
        static void Main(string[] args)
        {
            Access access = new Access();
            access.Method();

            int age=access.GetAge();

            Parent parent = new Parent();
            //parent.age             age is protected
            int dob=parent.dob;   // dob is protected internal
            int yearborn = parent.yearborn; //yearborn is internal

           //parent cannot access protected bcz only its derived class would be able to access
           //parent but can access dob bcz its protected internal

            Child child = new Child();
            child.Display();

            //can access internal field
           int yearborn1= access.yearborn;

        }
    }

  
    class Access
    {
        private int age = 10;
        internal int yearborn = 1996;

        public void Method()
        {
            Console.WriteLine("Public Method");
        }

        public int GetAge()
        {
            return age;
        }
        public void SetAge(int a)
        {
            age = a;
        }

    }

    class Parent
    {
        internal int yearborn;
        protected int age;
        protected internal int dob;
        
    }
    class Child : Parent
    {
        public void Display()
        {
            Console.WriteLine("Age is = {0}", age);
            Console.WriteLine("Age is = {0}", base.age);

            Console.WriteLine("Age is = {0}", dob);
            Console.WriteLine("Age is = {0}", base.dob);

            Console.WriteLine("Age is = {0}", yearborn);
            Console.WriteLine("Age is = {0}", base.yearborn);
        }
    }

    public class TestAccessSpecifiersInOtherAssembly
    {
        public int a_public;
        internal int yearborn_internal;
        protected int age_protected;
        protected internal int dob_protectedInternal;
    }

   
}
