namespace oop4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Static Binding:(Compile Time)يتم التحديد وقت 
            //ex:Method Overloading

            //Dynamic Binding:(Run Time)يتم التحديد وقت 
            //ex:Method Overriding باستخدام virtual وoverride
            #endregion

            #region Q2
            /*
            Method Overloading: Defining multiple methods with the same name but
            different parameter lists in the same class.

             Method Overriding: Redefining an inherited virtual or abstract method in a derived class using 
             the same method signature to provide a different implementation
            */
            #endregion

            #region Q3
            /*
            virtual: Allows a method in the base class to be overridden in a derived class.
            override: Provides a new implementation of an inherited virtual or abstract method.

            abstract: Declares a method without an implementation, requiring a non-abstract derived class to implement it.
            sealed: Prevents a method that overrides a base method from being overridden further when used with override.
            */
            #endregion
        }
    }
}
