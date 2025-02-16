using System.Net.Http.Headers;
using System.Runtime.Intrinsics.Arm;
using System.Threading;
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

            //Console.WriteLine(string.Join(", ",result));

            #endregion

            #region 02 - Query Syntax

            //var result = from str in Arr
            //             orderby str.ToLower() ascending
            //             select str;

            //Console.WriteLine(string.Join(", ",result));

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

            #region P02|Q04 - Sort a list of digits, first by length of their name, and then alphabetically by the name itself.

            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            #region 01 - Fluent Syntax

            //var result = Arr.OrderBy(str => str.Length).ThenBy(str => str);

            //Console.WriteLine(string.Join(", ",result));

            #endregion

            #region 02 - Query Syntax

            //var result = from str in Arr
            //             orderby str.Length, str
            //             select str;

            //Console.WriteLine(string.Join(", ", result));

            #endregion

            #endregion

            #region P02|Q05 - Sort first by-word length and then by a case-insensitive sort of the words in an array.

            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            #region 01 - Fluent Syntax

            //var comparer = new newStringComparer();
            //var result = Arr.OrderBy(str => str.Length).ThenBy(str => str, comparer);

            //Console.WriteLine(string.Join(", ", result));

            #endregion

            #region 02 - Query Syntax

            //var result = from str in Arr
            //             orderby str.Length, str.ToLower()
            //             select str;

            //Console.WriteLine(string.Join(", ", result));

            #endregion

            #endregion

            #region P02|Q06 - Sort a list of products, first by category, and then by unit price, from highest to lowest.

            #region 01 - Fluent Syntax

            //var result = ProductsList.OrderByDescending(p => p.Category).ThenByDescending(p => p.UnitPrice);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(); 

            #endregion

            #region 02 - Query Syntax

            //var result = from p in ProductsList
            //             orderby p.Category descending, p.UnitPrice descending
            //             select p;

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();

            #endregion

            #endregion

            #region P02|Q07 - Sort first by-word length and then by a case-insensitive descending sort of the words in an array.

            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            #region 01 - Fluent Syntax

            //var comparer = new newStringComparer();
            //var result = Arr.OrderBy(str => str.Length).ThenByDescending(str => str, comparer);

            //Console.WriteLine(string.Join(", ", result));

            #endregion

            #region 02 - Query Syntax

            //var result = from str in Arr
            //             orderby str.Length, str.ToLower() descending
            //             select str;

            //Console.WriteLine(string.Join(", ", result));

            #endregion

            #endregion

            #region P02|Q08 - Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.

            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            #region 01 - Fluent Syntax

            //var result = Arr.Where(str => str.Contains('i')).Reverse();

            //Console.WriteLine(string.Join(", ", result)); 

            #endregion

            #region 02 - Query Syntax

            //var result = (from str in Arr
            //             where str.Contains("i")
            //             select str).Reverse();

            //Console.WriteLine(string.Join(", ",result));

            #endregion

            #endregion

            #endregion

            #region Part03 - Transformation/Projection Operators

            #region P03|Q01 - Return a sequence of just the names of a list of products.

            #region 01 - Fluent Syntax

            //var result = ProductsList.Select(p => new { p.ProductName });

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();

            #endregion

            #region 02 - Query Syntax

            //var result = from p in ProductsList
            //             select new { p.ProductName };

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
