using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void Test1()
        {
            //arrange
            var book = new Book("");
           book.AddGrade(89.1);
           book.AddGrade(90.5);
           book.AddGrade(77.3);
           //act
          var result = book.GetStatistics();

           //assert
           Assert.Equals(85.6,result.Average,1);
           Assert.Equals(90.5,result.High,1);
           Assert.Equals(77.3,result.Low,1);
           Assert.Equals('B', result.Letter);
        }
    }
}
