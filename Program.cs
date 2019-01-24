using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a program that prints the numbers from 1 to 100. 
            But for multiples of three print “Fizz” instead of the number and for the multiples of five print “Buzz”. 
            For numbers which are multiples of both three and five print “FizzBuzz*/
            
            //simple with if and else if
            //SimpleFizzBuzz(1, 100);
            
            //simple with conditional operators ? :
            //SimpleFizzBuzz2(1, 100);

            ComplexFizzBuzz(1, 100,
                new Tuple<Func<int, bool>, string>((x) => x%3 == 0 && x%5 == 0, "FizzBuzz"),
                new Tuple<Func<int, bool>, string>((x) => x % 3 == 0, "Fizz"),
                new Tuple<Func<int, bool>, string>((x) => x % 5 == 0, "Buzz"),
                new Tuple<Func<int, bool>, string>((x) => x % 7 == 0, "Senad")
            );


        }
        static void ComplexFizzBuzz(int from, int to, params Tuple<Func<int, bool>, string>[] conditions){
            
            for(var i = from; i <= to; i++){
                var conditionValid = false;
                foreach(var condition in conditions){
                    var result = condition.Item1(i);
                    if(result){
                        Console.Write($"{condition.Item2},");
                        conditionValid = true;
                        break;
                    }
                }
                if(!conditionValid){
                    Console.Write($"{i},");
                }
            }
        }
        static void SimpleFizzBuzz2(int from, int to)
        {
            for(var i = from; i <= to; i++){
                var value = (i%3 == 0 && i%5 == 0) ? "FizzBuzz"
                    : (i % 3 == 0) ? "Fizz" : (i % 5 == 0) ? "Buzz" : i.ToString();

                Console.Write($"{value},");
            }
        }
        static void SimpleFizzBuzz(int from, int to){
            for(var i = from; i<= to; i++){
                if(i% 3 == 0 && i % 5 == 0)
                {
                    Console.Write("FizzBuzz,");
                }
                else if(i % 3 == 0){
                    Console.Write("Fizz,");
                }  else if (i % 5 == 0){
                    Console.Write("Buzz,");                    
                } else {
                    Console.Write($"{i},");
                }

            }
        }
    }
}
