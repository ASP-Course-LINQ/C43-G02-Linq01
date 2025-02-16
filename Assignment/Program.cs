using static Assignment.ListGenerator;
namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Part01 - Restriction Operators

            #region P01|Q01 - Find all products that are out of stock.

            #region 01 - Fluent Syntax

            //var result = ProductsList.Where(p => p.UnitsInStock == 0);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();

            #endregion

            #region 02 - Query Syntax

            //var result = from product in ProductsList
            //             where product.UnitsInStock == 0
            //             select product;

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();

            #endregion

            #endregion

            #region P01|Q02 - Find all products that are in stock and cost more than 3.00 per unit.

            #region 01 - Fluent Syntax

            //var result = ProductsList.Where(p => p.UnitsInStock != 0 && p.UnitPrice > 3m);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();

            #endregion

            #region 02 - Query Syntax

            //var result = from p in ProductsList
            //             where p.UnitsInStock != 0 && p.UnitPrice > 3m
            //             select p;

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();

            #endregion

            #endregion

            #region P01|Q03 - Returns digits whose name is shorter than their value.

            #region 01 - Fluent Syntax

            //String[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var result = Arr.Where((str, i) => str.Length < i);//Indexed Where.

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(); 

            #endregion

            #region 02 - Query Syntax

            //Can't use Indexed Where With Query Syntax.

            #endregion

            #endregion

            #endregion

            #region Part02 - Ordering Operators

            #region P02|Q01 -  Sort a list of products by name

            #region 01 - Fluent Syntax

            //var result = ProductsList.OrderBy(p => p.ProductName);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(); 

            #endregion

            #region 02 - Query Syntax

            //var result = from p in ProductsList
            //             orderby p.ProductName
            //             select p;

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();

            #endregion

            #endregion

            #region P02|Q02 - Uses a custom comparer to do a case-insensitive sort of the words in an array

            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            #region 01 - Fluent Syntax

            //var comparer = new newStringComparer();
            //var result = Arr.OrderBy(str => str, comparer);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();

            #endregion

            #region 02 - Query Syntax

            //var result = from str in Arr
            //         orderby str ascending
            //         select str;

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();


            #endregion

            #endregion

            #region P02|Q03 - Sort a list of products by units in stock from highest to lowest.

            #region 01 - Fluent Syntax

            //var result = ProductsList.OrderByDescending(p => p.UnitsInStock);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();

            #endregion

            #region 02 - Query Syntax

            //var result = from p in ProductsList
            //             orderby p.UnitsInStock descending
            //             select p;

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();

            #endregion

            #endregion

            #endregion

        }
    }
}
