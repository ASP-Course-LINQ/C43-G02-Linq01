namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Part 01 Implicitly Typed Local Variable [var - dynamic]

            #region var

            ////Local Variable => Any Variable Declared Inside Parentheses [function - for Loop - switch - ....]
            ////To Declare Variable We must specify it's dataType
            ////But Now You Can Declare Variable Without specify it's dataType.
            ////it's happen with help of keywords [var - dynamic].

            //var data = "Ahmed";//Implicit Type Local Variable [Declare variable without specify the dataType]
            //                   //Compiler will detect th dataType of this variable at compilation time based on the initialization value type - so now the type of "data" is "string".                  

            ////var x = null;// Invalid => Because Compiler need to detect the type of the 'x' variable based on the initialization
            //// But you initialize with "null", so how compile will detect the type ?
            //// and know, compiler must detect the type in compilation time to know the reserved bytes so give error.

            //data = null;//Valid => Because compiler detect the type of variable "data" previous when declare and initialize it with "Ahmed", so now type of "data" is string, so it can hold "null".

            ////data = 5;//Invalid => because the type of "data" is specified as of type "string", so how hold "int" value into variable of type "string"?
            ////After Initialization with "var", you can't change the variable type.

            ////var y;//Invalid => You must initialize this variable with value, because compiler need to detect the variable type based on type of initialization value.



            /////  Summary 
            ///// 
            /////  - You can store values of any type inside variable of type "var"
            /////  - once initialize this variable with value, you can't hold inside it value of another type.
            /////  - can't initialize variable of type "var" with "null".
            ///// - can't declare variable of type "var" without initialization - must initialize with any value. 

            #endregion

            #region dynamic

            //dynamic data = "Ali";// data type her is "dynamic" not "string" like when using "var" - if this line is the last initialization of variable "data", the datatype of it will be "string".
            //// CLR will detect the dataType of this variable at RunTime
            //// Based on the last assigned value to this variable "data".

            //data = 5;// you can change the type of variable of type dynamic after initialization, unlike the "var".
            //data = true;

            //// "data" variable in this example will be of type "bool", because it's the type of last initialization value.

            //dynamic y;//Valid
            //// Can declare variable of type "dynamic" without initialization.
            //// Because CLR know that you will initialize it later, and CLR will detect the type later based on last initialization [بيديك مهله وبيستنى معاك للاخر لعل وعسى تعمل انيشياليز]

            //y = null;//Valid
            //// Can initialize variable of type "dynamic" with "null".
            //// Because CLR know that you will initialize it later with another value, and CLR will detect the type later based on last initialization [بيديك مهله وبيستنى معاك للاخر لعل وعسى تعمل انيشياليز بقيمه ليها تايب]

            //data = 'A';

            /////  Summary 
            ///// 
            /////  - You can store values of any type inside variable of type "dynamic"
            /////  - after initialize this variable with value, you can hold inside it value of another type.
            /////  - can initialize variable of type "dynamic" with "null".
            /////  - can declare variable of type "var" without initialization . 


            #endregion

            ///can't use "var" & "dynamic" as type of function parameter.
            ///can't use "var" & "dynamic" as type of function return.
            ///can't use "var" & "dynamic" as type of property inside class/struct.
            ///those only used as type of local variables.
            ///it's recommended to use "var", because if it's error, it will be in compilation time
            ///no in run time [Exception] if using "dynamic".

            //var x = null;// Error, in compilation time, you must solve it before RUN.
            //Console.WriteLine(x);//can't execute this line - must solve the error first.

            //dynamic y = null;
            //Console.WriteLine(y);//Exception => can't detect the type in run time [RuntimeBinderException]

            #endregion

            #region Part 02 Extension Method
            //Extension method -> is method that you need to add it to built in structs or classes but you can't
            //So you make extension method for this type plus it's built in method.

            //I need to make method that take int value and reverse it, but the type "int" which is struct
            //not has method with this signature, so i will make extension method.

            #region Before Make The Extension Method => ReverseInt(this ref int num)

            //int num = 54879;
            //num.Reverse();//Error, The type "int" not have this method.
            //Console.WriteLine(num); 

            #endregion

            #region After Make The Extension Method => ReverseInt(this ref int num) - Parameter is the caller of the method.

            //int num = 54879;

            ////IntExtension.ReverseInt(ref num);// Call it as class member method [throw class name].
            //num.ReverseInt();// Call it as Extension Method - [object[int num] member method] [throw object from class].

            //Console.WriteLine(num);// 97845

            #endregion

            #endregion

            #region Part 03 Anonymous Type

            //Employee employee = new Employee() { Id = 5, Name = "Eslam", Salary = 1000 };
            //Console.WriteLine(employee.GetType().Name);//Employee [Type of variable "employee"]

            ////But I Don't need this class anyMore, i just create it to make object from it
            ////and to can hold address of it inside reference of object type which is "Employee".

            //int x = 5;
            //Console.WriteLine(x.GetType().Name);//Int32 [Type of variable "x"]

            ////So you don't need to make class to just use it to take reference from it to hold object of class type
            ////You can make anonymous object with no type, and hold address of it inside variable of type "var".
            ////this variable will be of type "Anonymous Type".

            //var Emp = new { Id = 100, Name = "Eslam Elsaadany", Salary = 10000 };
            //Console.WriteLine(Emp.GetType().Name);//<>f__AnonymousType0`3 [Type of variable "Emp"]
            //                                      // 0 -> Refer to that this is the first anonymous type made.
            //                                      // 3 -> Refer to number of properties inside the anonymous object
            //                                      // that variable "Emp" from anonymous type refer to.

            ////This object Which is of type Anonymous Type is an Immutable object [Can't be changed].
            ////Emp.Salary = 2000;//Invalid [Can't modify the object]
            //Console.WriteLine(Emp.Salary);//10000 [Valid]

            ////But There is a way to modify state of the anonymous object =>
            ////01 - Create new object with same state of previous object [Till c# 9.0]
            //var Emp02 = new { Id = Emp.Id, Name = Emp.Name, Salary = 20000 };
            ////02 - Create new object with same state of previous object - After c# 9.0
            //var Emp03 = Emp with { Salary = 20000 };

            //Console.WriteLine($"Emp =   {Emp}");  // Emp   = { Id = 100, Name = Eslam Elsaadany, Salary = 10000 }
            //Console.WriteLine($"Emp02 = {Emp02}");// Emp02 = { Id = 100, Name = Eslam Elsaadany, Salary = 20000 }
            //Console.WriteLine($"Emp03 = {Emp03}");// Emp03 = { Id = 100, Name = Eslam Elsaadany, Salary = 20000 }

            //// What is the dataType of each variable (Emp - Emp02 - Emp03) ?
            //Console.WriteLine($"Emp = {Emp.GetType().Name}");    // Emp   = <>f__AnonymousType0`3
            //Console.WriteLine($"Emp02 = {Emp02.GetType().Name}");// Emp02 = <>f__AnonymousType0`3
            //Console.WriteLine($"Emp03 = {Emp03.GetType().Name}");// Emp03 = <>f__AnonymousType0`3
            //// same data type


            // ///* NOTE:
            // ///
            // ///  * You can Make Variables Contain Anonymous objects and those variables will be with same dataType as long as :
            // ///  * 1. Same properties name of objects [Case Sensitive].
            // ///  * 2. Same properties Order.


            ////Example01 - Different properties name of objects [Case Sensitive].
            //var Emp04 = new { id = 70, Name = "Khalid", Salary = 4000 };
            //Console.WriteLine($"Emp04 = {Emp04.GetType().Name}");// Emp04 = <>f__AnonymousType1`3
            //                                                          // Emp04 variable is of type "<>f__AnonymousType1`3" which is different from type of [Emp - Emp02 - Emp03]
            //                                                         // Because the object that this variable hold address of it has different "Id" name which is "id" not "Id"

            ////Example02 - Different properties Order
            //var Emp05 = new { Id = 70, Salary = 4000, Name = "Khalid" };
            //Console.WriteLine($"Emp05 = {Emp05.GetType().Name}");// Emp05 = <>f__AnonymousType2`3
            //                                                     // Emp05 variable is of type "<>f__AnonymousType2`3" which is different from type of [Emp - Emp02 - Emp03]
            //                                                     // Because the object that this variable hold address of it has different order of properties which is [Id - Salary - Name]
            //                                                     // not [Id - Name - Salary]


            ////Example02 - Different properties Order
            //var Emp06 = new { Id = 70, Name = "Ahmed" };
            //Console.WriteLine($"Emp06 = {Emp06.GetType().Name}");// Emp04 = <>f__AnonymousType3`2
            //                                                     // Emp06 variable is of type "<>f__AnonymousType3`2" which is different from type of [Emp - Emp02 - Emp03]
            //                                                     // Because the object that this variable hold address of it has different properties which is [Id - Name]
            //                                                     // not [Id - Name - Salary]


            //Use Anonymous Type , When You need to make anonymous object Which not has specific type in compile time
            //and need to hold address of it in anonymous type.

            #endregion

            #region Part 04 What Is LinQ - [Language Integrated Query]
            ///// Linq Represent The DQL Category[select - groupBy - where - join ] of Database 
            ///// Implement those operators of DQL as C# functions
            ///// LinQ is Represent +40 Extension Method [operator].( method == operator ) in LinQ
            ///// When i need to communicate with DB through application [in Visual Studio],
            ///// You will write LinQ operators [Syntax] or SQL Commands [Syntax] ?
            ///// If you write SQL commands syntax in you app, your app will can communicate only with SQL server Database
            ///// And can't communicate with another DataBase.
            ///// If you write LinQ operators syntax in you app, your app will can communicate any database provider, with help of entity framework
            ///// based on type of database connected with app.
            ///// You can use those Linq operators [Extension] methods with all collections that implement
            ///// the IEnumerable<T> interface.
            ///// Those Extension Methods [LINQ Operators] are inside the Enumerable Class.
            ///// Those +40 LINQ methods are categorized into 13 category.
            ///// You can use those LINQ operators with/against any collection/sequence that implement IEnumerable<T> interface
            ///// You can use those LINQ operators with/against any Data[Stored in sequence] Regardless this data came from [collection - SQLSERVER - Oracle - ....]
            ///// sequence -> any object from class implement IEnumerable<T> interface.
            /////     1- Local Sequence -> Contain Static data Like List<int> nums = [1,2,3,4,5,6,7,8,9,10].
            /////                          Contains data came from Xml File
            /////     2- Remote Sequence -> Data came from Database Remote.
            /////
            ///// Using LINQ operators with sequence/object contain static data called [LinQ with/against object] -> L2Object
            ///// Using LINQ operators with sequence/object XML data called [LinQ with/against XML] -> L2XML
            ///// Using LINQ operators with remote sequence like Database that contain data called [LinQ with/against entityFrameWork] -> L2EF

            //List<int> nums = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
            //var evenNumbers = nums.Where(num => num % 2 == 0);// Call it throw object [object member method]. 
            //// where() => Return IEnumerable<T> so you can receive the return into variable of type "IEnumerable<T>" or "var" or cast the return to type List<int> and receive it into variable of type List<int>
            //List<int> evenNumbers02 = Enumerable.Where(nums, num => num % 2 == 0).ToList();// call it throw class [class member method]

            //Console.WriteLine(string.Join(", ",evenNumbers));  // 2, 4, 6, 8, 10
            //Console.WriteLine(string.Join(", ",evenNumbers02));// 2, 4, 6, 8, 10



            #endregion

            #region Part 05 LINQ Syntax

            //List<int> nums = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

            #region 01 - Fluent Syntax - Recommended

            #region 01.1 - Call The LinQ operator "Where()" as Static method [Throw class name[Enumerable.Where()]] - Not Recommended
            ////Filter This List to return just odd numbers using one of the LinQ operator

            //var oddNums = Enumerable.Where(nums, num => num % 2 == 1);
            //Console.WriteLine(string.Join(", ", oddNums));// 1, 3, 5, 7, 9 

            #endregion

            #region 01.2 - Call the LinQ operator "Where()" as object member method [Extension Method] throw object from any sequence/class implement the IEnumerable<T> interface - Recommended
            ////Filter This List to return just odd numbers using one of the LinQ operator

            //var oddNums02 = nums.Where(num => num % 2 == 1);
            //Console.WriteLine(string.Join(", ", oddNums02));// 1, 3, 5, 7, 9 

            #endregion

            #endregion

            #region 02 - Query Syntax - Like SQL SERVER Queries style.
            /// Like Writing Query in Sql to get data or make any operation on database.
            /// But You Write The Query here with order of execution. 
            /// start with from - where - select
            /// Query must begin with "from" and end with "select" or "group by" 

            ////Filter This List to return just odd numbers using one of the LinQ operator

            //var oddNumbers = from Num in nums // Num Is Represent each number in sequence.
            //                 where Num % 2 == 1
            //                 select Num;

            //Console.WriteLine(string.Join(", ",oddNumbers));// 1, 3, 5, 7, 9

            #endregion

            ////If there are joins and group by to reach result, you will found that Query syntax more easy.

            #endregion

        }
    }
}
