using System;
using System.Collections.Generic;
namespace GradeBook{
    public class Book
    {
        private List<double> grades;
        public Book(string name){
            grades = new List<double>();
            this.grades = grades;
        }
        public void AddLetterGrade(char letter)
        {
            switch(letter)
            {
            case 'A':
                    AddGrade(90);
                    break;
                case 'B':
                    AddGrade(80);
                    break;
                case 'C':
                    AddGrade(70);
                    break;
                default:
                    AddGrade(0);
                    break;
            }

        }
        public void AddGrade(double grade)
        {
            if(grade <= 100 && grade > 0){
                grades.Add(grade);
            } 
        }
        public Statistics GetStatistics(){
            
            var result = new Statistics();
            result.Average = 0.0;
            result.highGrade = double.MinValue;
            result.lowGrade = double.MaxValue;
            foreach(var grade in grades){
               result.highGrade = Math.Max(grade,result.highGrade);
               result.lowGrade = Math.Min(grade,result.lowGrade);
               result +=  grade;  
            }
            result.Average = result.Average / grades.Count;
            switch(result.Average){
                case var d when d>= 90.0:
                    result.Letter = 'A';
                    break;
                case var d when d>= 80.0:
                    result.Letter = 'B';
                    break;
                case var d when d>= 70.0:
                    result.Letter = 'C';
                    break;
                case var d when d>= 60.0:
                    result.Letter = 'D';
                    break;
                default:
                    result.Letter = 'F':
                    break;
            }
            return result;
            
        }
       
        private string name;
    }
}