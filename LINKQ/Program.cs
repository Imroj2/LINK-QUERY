// program to create LINQ query using Query Syntax
class HelloWorld
{
    static void Main()
    {
        int[] scroes= new int[] { 97, 92, 81, 60 };
        //define the query expression
        IEnumerable<int> scoreQuery =
            //query syntax
            from score in scroes
            where score > 80
            select score;
        //execute the query
        foreach (int i in scoreQuery)
        {
            Console.WriteLine(i);
        }
    }
}