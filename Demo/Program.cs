using System.IO;
using static Demo.ListGenerator;
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

            #region Part 06 LINQ Execution Ways

            #region 01 - Deferred Execution - LinQ operator Work on The Latest Version Of Data.
            //List<int> nums = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
            ////Filter This List To Return only odd numbers

            //var oddNumbers = nums.Where(num => num % 2 == 1);// Now oddNumbers is of type IEnumerable<int>?
            //nums.AddRange(new int[] { 11, 12, 13, 14, 15 });

            //Console.WriteLine(string.Join(", ", oddNumbers));// 1, 3, 5, 7, 9, 11, 13, 15
            ///it's expected to found on console screen => 1, 3, 5, 7, 9
            ///Because the line of executed where() is came before add new range values to the list
            ///But we found that the list oddNumbers refer to object contain => 1, 3, 5, 7, 9, 11, 13, 15
            ///So it's "Deferred Execution" => Where() method is executed with Deferred Execution (تنفيذ مؤجل)
            ///This Command "var oddNumbers = nums.Where(num => num % 2 == 1);" not executed the line "280" so "Where()" method not executed in this line.
            ///This Command "var oddNumbers = nums.Where(num => num % 2 == 1);" executed in the line "283" when i use the object from sequence "List<int> nums" to enumeration on it
            ///so "Where()" method is Executed on this line and work on the latest version of object that reference "oddNumbers" refer to which contain values [1,2,3,4,5,6,7,8,9,10,11,12,13,14,15].
            ///So after it filter it found that odd numbers are "1, 3, 5, 7, 9, 11, 13, 15"

            #endregion

            #region 02 - Immediate Execution [ (Elements - Casting - Aggregate LinQ) operators ]
            //List<int> nums = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
            ////Filter This List To Return only odd numbers

            ////var oddNumbers = nums.Where(num => num % 2 == 1);// Now oddNumbers is of type "IEnumerable<int>? oddNumbers"
            //var oddNumbers = nums.Where(num => num % 2 == 1).ToList();// Now oddNumbers is of type "List<int>? oddNumbers" because You use Casting LinQ operator ToList()
            //                                                          // To convert result from type IEnumerable<int> to type List<int>.
            //                                                          // So Now Where() method/operator is Executed in the line which i defined it in [Immediate Execution]
            //                                                          // not Deferred Execution because i use the LinQ casting Operator "ToList()" with it.
            //nums.AddRange(new int[] { 11, 12, 13, 14, 15 });

            //Console.WriteLine(string.Join(", ", oddNumbers));// 1, 3, 5, 7, 9

            ///When You use "Elements LinQ Operators" or "Casting LinQ Operators" or "Aggregate LinQ operators"
            ///with Where() - the execution will be immediate Execution When Defining not Deferred execution with latest usage. 

            #endregion

            #endregion

            #region Part 07 Data Setup

            ////Done
            //Console.WriteLine(ListGenerator.CustomersList[0]);// 212, Ahmed Ali, Obere Str. 57, Berlin, , 12209, Germany, 030-0074321, 030-0076545
            //Console.WriteLine(ListGenerator.ProductsList[0]); // ProductID:1,ProductName:Chai,CategoryBeverages,UnitPrice:18.00,UnitsInStock:100

            #endregion

            #region Part 08 Filteration[Restriction] Operator - Where()

            #region Example 01- Get Elements Out Of Stock

            #region 01- Fluent Syntax - Call LinQ operator "Where()" As Extesnsion Method Throw object from Sequence List<product> productList

            //var ProductsOutOfStock = ListGenerator.ProductsList.Where(product => product.UnitsInStock == 0);
            //foreach (var product in ProductsOutOfStock)
            //{
            //    Console.WriteLine(product);
            //}
            //Console.WriteLine();

            #endregion

            #region 02- Query Syntax - Query Expression

            //var ProductsOutOfStock = from product in ProductsList
            //                         where product.UnitsInStock == 0
            //                         select product;

            //foreach (var item in ProductsOutOfStock)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();

            #endregion

            #endregion

            #region Example 02 - Get Elements In Stock And In Category Of Meat/Poultry

            #region 01- Fluent Syntax - Call LinQ operator "Where()" As Extesnsion Method Throw object from Sequence List<product> productList

            //var result = ListGenerator.ProductsList.Where(product => product.UnitsInStock != 0 && product.Category == "Meat/Poultry");
            //foreach (var product in result)
            //{
            //    Console.WriteLine(product);
            //}
            //Console.WriteLine();

            #endregion

            #region 02- Query Syntax - Query Expression

            //var result = from product in ProductsList
            //             where product.UnitsInStock != 0 && product.Category == "Meat/Poultry"
            //             select product;

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();

            #endregion

            #endregion

            #region Example 03 - Get Elements Out Of Stock In First 10 Elements/products
            //Using second overload of Where(Func<Product,int,bool> predicate) [Indexed Where()] that take parameter of type delegate(Func)/function that take 2 parameters (Product,int) and return bool
            //This int parameter Represent index of every product in the productList. 

            #region 01- Fluent Syntax - Call LinQ operator "Where()" As Extesnsion Method Throw object from Sequence List<product> productList

            ////var result = ProductsList.Where(delegate (Product p, int i) { return p.UnitsInStock == 0 && i <= 9; });
            //var result = ProductsList.Where((p, i) => p.UnitsInStock == 0 && i <= 9);
            ////Return The products that index of them is less than or equal 9, filter on first 10 products.
            ////i represent index of each product in productList [Zero based index] 
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();

            #endregion

            #region 02- Query Syntax - Query Expression

            //Query Syntax Not Supported/Valid with Indexed Where(Func<Product,int,bool> predicate) 

            #endregion

            #endregion

            #endregion

            #region Part 09 Transformation[Projection العرض] Operators - [Select() , Select Many()]

            #region Example 01 - Select Product Name

            #region 01 - Fluent Syntax

            //var ProductsName = ProductsList.Select(product => product.ProductName);

            //foreach (var item in ProductsName)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();

            #endregion

            #region 02 - Query Syntax

            //var result = from product in ProductsList
            //             select product.ProductName;

            //foreach (var productName in result)
            //{
            //    Console.WriteLine(productName);
            //}
            //Console.WriteLine();

            #endregion

            #endregion

            #region Example 02 - Select Customer Name

            #region 01 - Fluent Syntax

            //var CustomersName = CustomersList.Select(customer => customer.CustomerName);

            //foreach (var name in CustomersName)
            //{
            //    Console.WriteLine(name);
            //}
            //Console.WriteLine();

            #endregion

            #region 02 - Query Syntax

            //var result = from Customer in CustomersList
            //             select Customer.CustomerName;

            //foreach (var customerName in result)
            //{
            //    Console.WriteLine(customerName);
            //}
            //Console.WriteLine();

            #endregion

            #endregion

            #region Example 03 - Select Customer Orders
            //Use SelectMany() Here Because you need to select data in collection "Order[] Orders" throw another collection "List<customer> customersList"

            #region 01 - Fluent Syntax

            //var result = CustomersList.SelectMany(customer => customer.Orders);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();

            #endregion

            #region 02 - Query Syntax

            //var result = from customer in CustomersList
            //             from order in customer.Orders
            //             select order;

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine( );

            #endregion

            #endregion

            #region Example 04 - Select Product Id and Product Name

            #region 01 - Fluent Syntax

            //var result = ProductsList.Select(product => new { product.ProductID, product.ProductName });
            //                                            return object of type Anonymous Type
            //                                            CLR Will make Class for this Type and override ToString() method 
            //                                            To print object(of type Anonymous) properties values.              
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(); 

            #endregion

            #region 02 - Query Syntax

            //var result = from product in ProductsList
            //             select new { product.ProductID, product.ProductName };

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();

            #endregion

            #endregion

            #region Example 05 - Select Product in stock and apply discount 10% on it's price

            #region 01 - Fluent Syntax

            //var result = ProductsList.Where(p => p.UnitsInStock != 0)
            //                           .Select(p => new
            //                           {
            //                               ID = p.ProductID,
            //                               Name = p.ProductName,
            //                               OldPrice = $"{p.UnitPrice:c}",
            //                               Discount = "10%",
            //                               NewPrice = $"{p.UnitPrice - (p.UnitPrice * .10m):c}",
            //                               Saved = $"{p.UnitPrice - (p.UnitPrice - (p.UnitPrice * .10m)):c}"
            //                           });

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();

            #endregion

            #region 02 - Query Syntax

            //var result = from p in ProductsList
            //             where p.UnitsInStock != 0
            //             select new
            //             {
            //                 ID = p.ProductID,
            //                 Name = p.ProductName,
            //                 OldPrice = $"{p.UnitPrice:c}",
            //                 Discount = "10%",
            //                 NewPrice = $"{p.UnitPrice - (p.UnitPrice * .10m):c}",
            //                 Saved = $"{p.UnitPrice - (p.UnitPrice - (p.UnitPrice * .10m)):c}"
            //             };

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();

            #endregion

            #endregion

            #region Example 06 - Return index and name All products in stock.
            //Use Indexed Select(Func<Product,int,Tout> selector).

            #region 01 - Fluent Syntax

            //var result = ProductsList.Where(p => p.UnitsInStock != 0)//result is of type "IEnumerable<string>" as the return is of type "string"
            //                         .Select((product, i) => $"{i}-{product.ProductName}");

            //var result02 = ProductsList.Where(p => p.UnitsInStock != 0)//result02 is of type "IEnumerable<`a>" as the return is of type "Anonymous Type"
            //                         .Select((product, i) => new { Id = i, Name = product.ProductName });

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine();

            //foreach (var item in result02)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 02 - Query Syntax

            //Can't use Query Syntax with indexed Select().

            #endregion

            #endregion

            #endregion

            #region Part 10 Ordering Operators [OrderBy() - OrderByDesc() - ThenBy() - ThenByDescending() - Reverse()].

            #region Example 01 - Get Products Ordered By Price Asc

            #region 01 - Fluent Syntax

            //var result = ProductsList.OrderBy(product => product.UnitPrice);//order based on unitPrice ASC - return IOrderedEnumerable<product>

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 02 - Query Syntax

            //var result = from product in ProductsList
            //             orderby product.UnitPrice ascending
            //             select product;

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(); 

            #endregion

            #endregion

            #region Example 02 - Get Products Ordered By Price Desc

            #region 01 - Fluent Syntax

            //var result = ProductsList.OrderByDescending(p => p.UnitPrice);////order based on unitPrice DESC - return IOrderedEnumerable<product>

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();

            #endregion

            #region 02 - Query Syntax

            //var result = from product in ProductsList
            //             orderby product.UnitPrice descending
            //             select product;

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(); 

            #endregion

            #endregion

            #region Example 03 - Get Products Ordered By Price Asc and Number of items in stock.

            #region 01 - Fluent Syntax

            //var result = ProductsList.OrderBy(p => p.UnitPrice).ThenBy(p => p.UnitsInStock);//if two products hve the same UnitPrice, order base on UnitsInStock.

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();

            #endregion


            #region 02 - Query Syntax

            //var result = from product in ProductsList
            //             orderby product.UnitPrice ascending, product.UnitsInStock ascending
            //             select product;

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(); 

            #endregion

            #endregion

            #region Example 04 - Get Products Ordered By Price Asc and Number of items in stock Desc

            #region 01 - Fluent Syntax

            //var result = ProductsList.OrderBy(p => p.UnitPrice).ThenByDescending(p => p.UnitsInStock);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();

            #endregion

            #region 02 - Query Syntax

            //var result = from product in ProductsList
            //             orderby product.UnitPrice ascending, product.UnitsInStock descending
            //             select product;

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();

            #endregion

            #endregion

            #region Exmaple 05 - Get Products out of stock and reverse them.

            #region 01 - Fluent Syntax

            //var result = ProductsList.Where(p => p.UnitsInStock == 0).Reverse();//Invert/reverse the order of the elements in the sequence and return "IEnumerable<product>"

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();

            #endregion

            #endregion

            #endregion

            #region Part 11 Element Operators - Immediate Execution [First() - Last() - LastOrDefault() - ElementAt() - Single() - SingleOrDefault()]
            //Valid Only With Fluent Syntax
            //You can use Hybrid Syntax (Query Expression).(Fluent Syntax).

            #region 01 - First

            #region 01.1 First() 

            ////return object of type nullable, so you need to check first if the returned is null or not before print the result
            ////Return The First Element/object inside the sequence [Return Only one element of type same as sequence type].
            ////Throw Exception if the sequence is empty [refer to empty object] or if the sequence refer to null.

            #region 01 - In Case the sequence is not empty.

            //var result = ProductsList.First();
            //    Console.WriteLine(result);//ProductID:1, ProductName:Chai, Category:Beverages, UnitPrice:$18.00, UnitsInStock:100

            #endregion

            #region 02 - In case the sequence is empty [Contain No Elements].

            //List<Product> list = new List<Product>();
            //var result = list.First();// System.InvalidOperationException: Sequence contains no elements

            //Console.WriteLine(result);

            #endregion

            #endregion

            #region 01.2 First(Func<Product,bool> predicate)
            //Returns The First Element in a sequence that satisfied/match the specified condition passed. 
            //If there is no elements match the condition or sequence is empty => throw Exception (System.InvalidOperationException: Sequence contains no matching element)

            //Example -> Returns The first product out of stock.

            #region 01 - If there are elements matches the condition - returned the first element match.

            //var result = ProductsList.First(p => p.UnitsInStock == 0);

            //Console.WriteLine(result);//ProductID:5, ProductName:Chef Anton's Gumbo Mix, Category:Condiments, UnitPrice:$21.35, UnitsInStock:0

            #endregion

            #region 02 - If no elements in the sequence match the condition - Throw Exception.

            //var result = ProductsList.First(p => p.UnitsInStock == 14569);

            //Console.WriteLine(result);//System.InvalidOperationException: Sequence contains no matching element

            #endregion

            #region 03 - If Sequence is empty - throw Exception.

            //List<Product> products = new List<Product>();

            //var result = products.First(p => p.UnitsInStock == 0);

            //Console.WriteLine(result);//System.InvalidOperationException: Sequence contains no matching element

            #endregion

            #endregion

            #endregion

            #region 02 - Last

            #region 02.1 Last()

            ////Return The Last Element/object inside the sequence [Return Only one element of type same as sequence type].
            ////Throw Exception if the sequence is empty [refer to empty object] or if the sequence refer to "null".

            #region 01 - In case the sequence is not empty [Contain Elements]

            //var result = ProductsList.Last();

            //Console.WriteLine(result);//ProductID:77, ProductName:Original Frankfurter grüne Soße, Category:Condiments, UnitPrice:$13.00, UnitsInStock:32

            #endregion

            #region 02 - In case the sequence is empty [Contain No Elements].

            //List<Product> list = new List<Product>();
            //var result = list.Last();// System.InvalidOperationException: Sequence contains no elements

            //Console.WriteLine(result);

            #endregion

            ///First() - Last() =>
            ///Return the first or last item in the sequence if the sequence is not empty
            ///Throw Exception if the sequence is empty [contain no elements] or if it refer to "null".
            /// 

            #endregion

            #region 01.2 Last(Func<Product,bool> predicate)
            //Returns The Last Element in a sequence that satisfied/match the specified condition passed. 
            //If there is no elements match the condition or sequence is empty => throw Exception (System.InvalidOperationException: Sequence contains no matching element)

            //Example -> Returns The Last product out of stock.

            #region 01 - If there are elements matches the condition - returned the Last element match.

            //var result = ProductsList.Last(p => p.UnitsInStock == 0);

            //Console.WriteLine(result);//ProductID:5, ProductName:Chef Anton's Gumbo Mix, Category:Condiments, UnitPrice:$21.35, UnitsInStock:0

            #endregion

            #region 02 - If no elements in the sequence match the condition - Throw Exception.

            //var result = ProductsList.Last(p => p.UnitsInStock == 14569);

            //Console.WriteLine(result);//System.InvalidOperationException: Sequence contains no matching element

            #endregion

            #region 03 - If Sequence is empty - throw Exception.

            //List<Product> products = new List<Product>();

            //var result = products.Last(p => p.UnitsInStock == 0);

            //Console.WriteLine(result);//System.InvalidOperationException: Sequence contains no matching element

            #endregion

            #endregion

            #endregion

            #region 03 - FirstOrDefault

            #region 03.1 FirstOrDefault()

            //If the sequence is empty [contain no elements], returned the default value of the type of the sequence Type.
            //If the sequence is not empty, return the first element.

            #region 01 - In Case The sequence not empty [Contain Elements] - return the element.

            //var result = ProductsList.FirstOrDefault();

            //if (result != null)
            //    Console.WriteLine(result);//ProductID:1, ProductName:Chai, Category:Beverages, UnitPrice:$18.00, UnitsInStock:100
            //else
            //    Console.WriteLine("");

            #endregion

            #region 02 - In case the sequence is empty [Contain no elements] - return the default value of Sequence type.

            //List<Product> list = new List<Product>();

            //var result = list.FirstOrDefault();
            //if (result != null)
            //    Console.WriteLine(result);
            //else
            //    Console.WriteLine("No Items!");//No Items!
            //                                        //Because FirstOrDefault() here return the default value of type Product which is reference type and default value is "null"
            //                                        //This because the sequence is empty so the return is the default value "null" which holded in variable "result".

            #endregion

            #endregion

            #region 03.2 FirstOrDefault(Func<Product,bool> predicate)

            //Returns The First Element in a sequence that satisfied/match the specified condition passed. 
            //If there is no elements match the condition or sequence is empty => return the default value of the sequenceType

            //Example -> Returns The first product out of stock.

            #region 01 - If there are elements matches the condition - returned the first element match.

            //var result = ProductsList.FirstOrDefault(p => p.UnitsInStock == 0);

            //Console.WriteLine(result);//ProductID:5, ProductName:Chef Anton's Gumbo Mix, Category:Condiments, UnitPrice:$21.35, UnitsInStock:0

            #endregion

            #region 02 - If no elements in the sequence match the condition - Return the Default value of sequence type.

            //var result = ProductsList.FirstOrDefault(p => p.UnitsInStock == 14569);

            //if(result != null)
            //    Console.WriteLine(result);
            //else
            //    Console.WriteLine("No Elements Match The Condition || Sequence Empty.");//No Elements Match The Condition || Sequence Empty.

            #endregion

            #region 03 - If Sequence is empty - Return the Default value of sequence type.

            //List<Product> products = new List<Product>();

            //var result = products.FirstOrDefault(p => p.UnitsInStock == 0);

            //Console.WriteLine("No Elements Match The Condition || Sequence Empty.");//No Elements Match The Condition || Sequence Empty.

            #endregion

            #endregion

            #endregion

            #region 04 - LastOrDefault

            #region 04.1 LastOrDefault()

            //If the sequence is empty [contain no elements], returned the default value of the type of the sequence Type ["0" => ValueTypes , "null" => ReferenceTypes].
            //If the sequence is not empty, return the Last element.

            #region 01 - In Case The sequence not empty [Contain Elements].

            //var result = ProductsList.LastOrDefault();

            //if (result != null)
            //    Console.WriteLine(result);//ProductID:77, ProductName:Original Frankfurter grüne Soße, Category:Condiments, UnitPrice:$13.00, UnitsInStock:32
            //else
            //    Console.WriteLine("No Elements!");

            #endregion

            #region 02 - In case the sequence is empty [Contain no elements].

            //List<Product> list = new List<Product>();

            //var result = list.LastOrDefault();
            //if (result != null)
            //    Console.WriteLine(result);
            //else
            //    Console.WriteLine("No Items!");//No Items!
            //                                        //Because FirstOrDefault() here return the default value of type Product which is reference type and default value is "null"
            //                                        //This because the sequence is empty so the return is the default value "null" which holded in variable "result".

            #endregion

            ///FirstOrDefault() - LastOrDefault() => 
            ///Return the first or last item in the sequence if the sequence is not empty
            ///Return the default value of the type of the sequence if the sequence is empty [Not thrown Exception] ["0" => ValueTypes , "null" => ReferenceTypes].
            /// 

            #endregion

            #region 04.2 LastOrDefault(Func<Product,bool> predicate)

            //Returns The Last Element in a sequence that satisfied/match the specified condition passed. 
            //If there is no elements match the condition or sequence is empty => return the default value of the sequenceType

            //Example -> Returns The Last product out of stock.

            #region 01 - If there are elements matches the condition - returned the Last element match.

            //var result = ProductsList.LastOrDefault(p => p.UnitsInStock == 0);

            //Console.WriteLine(result);//ProductID: 53, ProductName: Perth Pasties, Category:Meat / Poultry, UnitPrice:$32.80, UnitsInStock: 0

            #endregion

            #region 02 - If no elements in the sequence match the condition - Return the Default value of sequence type.

            //var result = ProductsList.LastOrDefault(p => p.UnitsInStock == 14569);

            //if(result != null)
            //    Console.WriteLine(result);
            //else
            //    Console.WriteLine("No Elements Match The Condition || Sequence Empty.");//No Elements Match The Condition || Sequence Empty.

            #endregion

            #region 03 - If Sequence is empty - Return the Default value of sequence type.

            //List<Product> products = new List<Product>();

            //var result = products.LastOrDefault(p => p.UnitsInStock == 0);

            //Console.WriteLine("No Elements Match The Condition || Sequence Empty.");//No Elements Match The Condition || Sequence Empty.

            #endregion

            #endregion

            #endregion

            #region 05 - ElementAt()

            //Return the element is specific index
            //If index is out of range of sequence indices or sequence is empty => throw exception (Index out of range).

            #region 01 - Try to return element in actual index in range of sequence indices.

            //var result = ProductsList.ElementAt(0);

            //Console.WriteLine(result);//ProductID:1, ProductName:Chai, Category:Beverages, UnitPrice:$18.00, UnitsInStock:100 

            #endregion

            #region 02 - Try to return element in Invalid index out of sequence indices range.

            //var result02 = ProductsList.ElementAt(100);

            //Console.WriteLine(result02);//System.ArgumentOutOfRangeException: Index was out of range. 

            #endregion

            #region 03 - Try to return element in empty sequence.

            //List<Product> products = new List<Product>();
            //var result03 = products.ElementAt(0);

            //Console.WriteLine(result03);//System.ArgumentOutOfRangeException: Index was out of range

            #endregion

            #endregion

            #region 06 - ElementAtOrDefault()

            //Return the element is specific index
            //If index is out of range of sequence indices or sequence is empty => Return The Default value of sequenceType.

            #region 01 - Try to return element in actual index in range of sequence indices.

            //var result = ProductsList.ElementAtOrDefault(0);

            //Console.WriteLine(result);//ProductID:1, ProductName:Chai, Category:Beverages, UnitPrice:$18.00, UnitsInStock:100 

            #endregion

            #region 02 - Try to return element in Invalid index out of sequence indices range.

            //var result02 = ProductsList.ElementAtOrDefault(100);

            //if(result02 != null)
            //    Console.WriteLine(result02);
            //else
            //    Console.WriteLine("index is out of range of sequence indices || sequence is empty");//index is out of range of sequence indices || sequence is empty

            #endregion

            #region 03 - Try to return element in empty sequence.

            //List<Product> products = new List<Product>();
            //var result03 = products.ElementAtOrDefault(0);

            //if (result03 != null)
            //    Console.WriteLine(result03);
            //else
            //    Console.WriteLine("index is out of range of sequence indices || sequence is empty");//index is out of range of sequence indices || sequence is empty

            #endregion

            #endregion

            #region 07 - Single

            #region 01 Single()

            //Return the only element of a sequence
            //Throw Exception => if the sequence not contain exactly one element. [System.InvalidOperationException: Sequence contains more than one element]
            //Throw Exception => if the sequence is empty. [System.InvalidOperationException: Sequence contain no elements]

            #region 01 - In case The sequence contain exactly one element

            //List<Product> products = new List<Product>(1)
            //{
            //    new Product(){ProductID = 100, Category = "Meat", ProductName ="Locus", UnitPrice = 1500, UnitsInStock = 100}
            //};

            //var result = products.Single();

            //Console.WriteLine(result);//ProductID:100, ProductName:Locus, Category:Meat, UnitPrice:$1,500.00, UnitsInStock:100

            #endregion

            #region 02 - In case The sequence Contain more than one element.

            //var result = ProductsList.Single();

            //Console.WriteLine(result);//System.InvalidOperationException: Sequence contains more than one element

            #endregion

            #region 03 - In case The sequence is empty.

            //List<Product> products = new List<Product>();

            //var result = products.Single();

            //Console.WriteLine(result);//System.InvalidOperationException: Sequence contains no elements

            #endregion

            #endregion

            #region 02 Single(Func<Product,bool> predicate)

            //Return the only element of a sequence that satisfy the specified condition
            //Throw Exception => if there are more than one element satisfy the condition [System.InvalidOperationException: Sequence contains more than one matching element]
            //Throw Exception => if the sequence not contain any elements match the condition or it's empty. [Sequence contains no matching element]

            #region 01 - In case The sequence contain exactly one element satisfy the condition

            //List<Product> products = new List<Product>(1)
            //{
            //    new Product(){ProductID = 100, Category = "Meat", ProductName ="Locus", UnitPrice = 1500, UnitsInStock = 100},
            //    new Product(){ProductID = 200, Category = "Veg", ProductName ="Umber", UnitPrice = 1500, UnitsInStock = 0},
            //    new Product(){ProductID = 400, Category = "Noin", ProductName ="Somgn", UnitPrice = 1500, UnitsInStock = 0}
            //};

            //var result = products.Single(p => p.UnitsInStock == 100);

            //Console.WriteLine(result);//ProductID:100, ProductName:Locus, Category:Meat, UnitPrice:$1,500.00, UnitsInStock:100

            #endregion

            #region 02 - In case The sequence Contain more than one element satisfy the condition.

            //List<Product> products = new List<Product>(1)
            //{
            //    new Product(){ProductID = 100, Category = "Meat", ProductName ="Locus", UnitPrice = 1500, UnitsInStock = 100},
            //    new Product(){ProductID = 200, Category = "Veg", ProductName ="Umber", UnitPrice = 1500, UnitsInStock = 0},
            //    new Product(){ProductID = 400, Category = "Noin", ProductName ="Somgn", UnitPrice = 1500, UnitsInStock = 0}
            //};

            //var result = products.Single(p => p.UnitsInStock == 0);

            //Console.WriteLine(result);//System.InvalidOperationException: Sequence contains no matching elementt

            #endregion

            #region 03 - In case The sequence ot contain any elements match the condition or it's empty.

            //var result = ProductsList.Single(p => p.UnitsInStock == 700);

            //Console.WriteLine(result);//System.InvalidOperationException: Sequence contains no matching element

            #endregion

            #endregion

            #endregion

            #region 07 - SingleOrDefault

            #region 01 SingleOrDefault()

            //Return the only element of a sequence
            //Return the default value of sequence Type if no elements exists [sequence is empty]
            //Throw Exception => if the sequence not contain exactly one element. [System.InvalidOperationException: Sequence contains more than one element]

            #region 01 - In case The sequence contain exactly one element

            //List<Product> products = new List<Product>(1)
            //{
            //    new Product(){ProductID = 100, Category = "Meat", ProductName ="Locus", UnitPrice = 1500, UnitsInStock = 100}
            //};

            //var result = products.SingleOrDefault();

            //Console.WriteLine(result);//ProductID:100, ProductName:Locus, Category:Meat, UnitPrice:$1,500.00, UnitsInStock:100

            #endregion

            #region 02 - In case The sequence Contain more than one element.

            //var result = ProductsList.SingleOrDefault();

            //Console.WriteLine(result);//System.InvalidOperationException: Sequence contains more than one element

            #endregion

            #region 03 - In case The sequence is empty.

            //List<Product> products = new List<Product>();

            //var result = products.SingleOrDefault();

            //if (result != null)
            //    Console.WriteLine(result);
            //else
            //    Console.WriteLine("Sequence is empty!");

            #endregion

            #endregion

            #region 02 SingleOrDefault(Func<Product,bool> predicate)

            //Return the only element of a sequence that satisfy the specified condition
            //Return the default value of sequence Type if no elements match the condition or sequence is empty.
            //Throw Exception => if there are more than one element satisfy the condition [System.InvalidOperationException: Sequence contains more than one matching element]

            #region 01 - In case The sequence contain exactly one element satisfy the condition

            //List<Product> products = new List<Product>(1)
            //{
            //    new Product(){ProductID = 100, Category = "Meat", ProductName ="Locus", UnitPrice = 1500, UnitsInStock = 100},
            //    new Product(){ProductID = 200, Category = "Veg", ProductName ="Umber", UnitPrice = 1500, UnitsInStock = 0},
            //    new Product(){ProductID = 400, Category = "Noin", ProductName ="Somgn", UnitPrice = 1500, UnitsInStock = 0}
            //};

            //var result = products.SingleOrDefault(p => p.UnitsInStock == 100);

            //Console.WriteLine(result);//ProductID:100, ProductName:Locus, Category:Meat, UnitPrice:$1,500.00, UnitsInStock:100

            #endregion

            #region 02 - In case The sequence Contain more than one element satisfy the condition.

            //List<Product> products = new List<Product>(1)
            //{
            //    new Product(){ProductID = 100, Category = "Meat", ProductName ="Locus", UnitPrice = 1500, UnitsInStock = 100},
            //    new Product(){ProductID = 200, Category = "Veg", ProductName ="Umber", UnitPrice = 1500, UnitsInStock = 0},
            //    new Product(){ProductID = 400, Category = "Noin", ProductName ="Somgn", UnitPrice = 1500, UnitsInStock = 0}
            //};

            //var result = products.SingleOrDefault(p => p.UnitsInStock == 0);

            //Console.WriteLine(result);//System.InvalidOperationException: Sequence contains no matching elementt

            #endregion

            #region 03 - In case No elements in sequence match the condition or  sequence is empty.

            //List<Product> products = new List<Product>()
            //{
            //    new Product{ProductID = 10, Category = "aaaa", ProductName = "dddd", UnitsInStock = 100, UnitPrice =10},
            //    new Product{ProductID = 10, Category = "aaaa", ProductName = "dddd", UnitsInStock = 100, UnitPrice =10},
            //    new Product{ProductID = 10, Category = "aaaa", ProductName = "dddd", UnitsInStock = 100, UnitPrice =10},
            //};

            //var result = products.SingleOrDefault(p => p.UnitsInStock == 0);

            //if (result != null)
            //    Console.WriteLine(result);
            //else
            //    Console.WriteLine("there is No elements match the condition || Sequence is empty!");//there is No elements match the condition || Sequence is empty!

            #endregion

            #endregion

            #endregion

            #region Hybrid Syntax - QuerySyntax + FluentSyntax - (Query Expression).(Fluent Syntax[LinQ operator])

            ////Get the first element that units in stock of it is zero, get name,price,category.
            
            //var result = (from product in ProductsList
            //             where product.UnitsInStock == 0
            //             select new
            //             {
            //                 product.ProductName,
            //                 product.UnitPrice,
            //                 product.Category
            //             }).FirstOrDefault();

            //Console.WriteLine(result);//{ ProductName = Chef Anton's Gumbo Mix, UnitPrice = 21.3500, Category = Condiments }
            
            #endregion

            #endregion

        }
    }
}
