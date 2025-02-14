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

            ////IntExtension.ReverseInt(ref num);
            //num.ReverseInt();// Call it as Extension Method - [object[int num] member method].

            //Console.WriteLine(num);// 97845

            #endregion

            #endregion
        }
    }
}
