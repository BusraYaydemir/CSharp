using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace D24_InterviewQuestions
{
    internal class Program
    {
        #region ValueAndReeranceTypes
        enum EnumLevel
        {
            Low,
            Mid,
            High
        }

        struct StructLevel
        {
            public string name;
            public int levelNumber;
        }
        #endregion

        static void Main(string[] args)
        {
            //ValueAndReferanceTypes();

            //Interfaces();


            Console.ReadLine();
        }

        private static void ValueAndReferanceTypes()
        {
            /*

                         From : https://learn.microsoft.com/en-us/dotnet/visual-basic/programming-guide/language-features/data-types/value-types-and-reference-types

                        */
            /**
                          
             There are two kinds of types in Visual Basic: reference types and value types. Variables of reference types store references to their data (objects), while variables of value types directly contain their data. With reference types, two variables can reference the same object; therefore, operations on one variable can affect the object referenced by the other variable. With value types, each variable has its own copy of the data, and it is not possible for operations on one variable to affect the other (except in the case of the ByRef modifier on parameters).
             
             */

            /**
             
             VALUE TYPES
             
                A data type is a value type if it holds the data within its own memory allocation. Value types include the following:

                * All numeric data types

                * Boolean, Char, and Date

                * All structures, even if their members are reference types

                * Enumerations, since their underlying type is always SByte, Short, Integer, Long, Byte, UShort, UInteger, or ULong

                Every structure is a value type, even if it contains reference type members. For this reason, value types such as Char and Integer are implemented by .NET Framework structures.

                You can declare a value type by using the reserved keyword, for example, Decimal. You can also use the New keyword to initialize a value type. This is especially useful if the type has a constructor that takes parameters. An example of this is the Decimal(Int32, Int32, Int32, Boolean, Byte) constructor, which builds a new Decimal value from the supplied parts.

             */

            decimal decimalNumber = 1234;
            Console.WriteLine(decimalNumber.GetType() + " : " + decimalNumber);
            Console.WriteLine("Is it a value type : " + decimalNumber.GetType().IsValueType + "\nIs it a referance type : " + !decimalNumber.GetType().IsValueType);


            Decimal decimalNumber2 = new Decimal(32, 21, 34, true, 3);
            Console.WriteLine(decimalNumber2.GetType() + " : " + decimalNumber2);
            Console.WriteLine("Is it a value type : " + decimalNumber2.GetType().IsValueType + "\nIs it a referance type : " + !decimalNumber2.GetType().IsValueType);


            EnumLevel enumVariable = EnumLevel.High;
            Console.WriteLine(enumVariable.GetType() + " : " + enumVariable);
            Console.WriteLine("Is it a value type : " + enumVariable.GetType().IsValueType + "\nIs it a referance type : " + !enumVariable.GetType().IsValueType);

            StructLevel structVariable;
            structVariable.name = "Low";
            structVariable.levelNumber = 1;
            Console.WriteLine(structVariable.GetType() + " : " + structVariable);
            Console.WriteLine("Is it a value type : " + structVariable.GetType().IsValueType + "\nIs it a referance type : " + !structVariable.GetType().IsValueType);

            /**
             
             REFERANCE TYPE

            A reference type stores a reference to its data. Reference types include the following:

            * String

            * All arrays, even if their elements are value types

            * Class types, such as Form

            * Delegates

            A class is a reference type. Note that every array is a reference type, even if its members are value types.

            Since every reference type represents an underlying .NET Framework class, you must use the New Operator keyword when you initialize it. The following statement initializes an array.

             */

            string stringValue = "it is a string value 1";
            string controlString;
            controlString = stringValue;
            stringValue = "stringValue is changed!";
            Console.WriteLine("stringValue : " + stringValue);
            Console.WriteLine("controlString : " + controlString);
            Console.WriteLine("Is it a value type : " + controlString.GetType().IsValueType + "\nIs it a referance type : " + !controlString.GetType().IsValueType);
        }

        private static void Interfaces()
        {
            /*
             * Interface'ler yazılımsal olarak classlar için bir arayüz görevi görür ve classların o operasyonları imzalamasını zorunlu hale getirir.
             * 
             * Sürdürülebilir yazılımın en önemli öğesidir.
             */

            CustomerManager customerManager = new CustomerManager(new MySqlLog());
            customerManager.Add();
            
        }
    }

    #region Interfaces
    public interface ILog
    {
        void Add();
    }

    class MsSqlServerLog : ILog
    {
        public void Add() {
            Console.WriteLine("Info is Logged to MS SQL SERVER!");
        }
    }

    class MySqlLog : ILog
    {
        public void Add()
        {
            Console.WriteLine("Info is Logged to MY SQL!");
        }
    }

    class CustomerManager
    {
        private ILog _log;

        public CustomerManager (ILog log)
        {
            _log = log;
        }

        public void Add()
        {
            _log.Add();
        }
        
    }
    #endregion


}
