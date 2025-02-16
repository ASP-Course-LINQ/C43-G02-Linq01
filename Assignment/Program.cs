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

            #endregion
        }
    }
}
