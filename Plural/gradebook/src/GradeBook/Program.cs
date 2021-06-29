using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Scott's new book");
            var input = double.Parse(Console.ReadLine());
            while(true){
                Console.WriteLine("Enter a grade or q to quit");
                var i = Console.ReadLine();
                if(i =="q"){
                    break;
                }
                var grade = double.Parse(i);
                book.AddGrade(grade);
            }
            var stats = book.GetStatistics();
            Console.WriteLine($"The lowest grade is {stats.lowGrade}");
            Console.WriteLine($"The high grade is {stats.highGrade}");
            Console.WriteLine($"The average grade is {stats.result:N1}");
            Console.WriteLine($"The letter grade is {stats.Letter}");
            /*if(args.Length>0){
                //Console.WriteLine("Hello" + args[0] + "!");
                Console.WriteLine($"Hello {args[0]}!");
            }
            else{
                Console.WriteLine("Hello");
            }*/
        }
    }
}
                         