using System;

class Program
{
    static void Main(string[] args)
    {
    //    Assignment A1 = new Assignment();
    //    A1.SetName("Zach");
    //    A1.SetTopic("Random Topic");

    //    Console.WriteLine(A1.GetSummary());


        Math M1 = new Math("John","Fractions","Section 7.3", "Problems 8 - 19");
        Console.WriteLine(M1.GetSummary());
        Console.WriteLine(M1.GetHomeworkList());

        Console.WriteLine()

       Writing W1 = new Writing("Mary Waters", "European War", "The Cause of WWII by Mary Waters");
       Console.WriteLine(W1.GetSummary());
       Console.WriteLine(W1.GetWritingInfo());
       
    }
}