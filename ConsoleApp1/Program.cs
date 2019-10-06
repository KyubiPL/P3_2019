using System;
using Serilog;

namespace ConsoleApp1
{
    class Program
    {
        [Flags]
        enum Font: uint //unsigned == u przed typem np uint
        {
            Bold = 1,
            Underscore = 2,
            Underline = 4,
            All = 8
        }

        static Random rnd = new Random();//obiekt klasy

        static void Main(string[] args)
        {

            /*
                        var losowaliczba = rnd.Next(maxValue: 100);



                        Console.WriteLine("Hello World!");// MSIL-microsoft/comon 

                        for (int i = 0; i < 10; i++)
                        {
                            Console.WriteLine("what nr?");
                            Console.WriteLine($"podaj liczbe (podejście {i + 1})");

                            string s = Console.ReadLine();




                            int cosliczba;
                            if(!int.TryParse(s, out cosliczba));//na razie to jest złe parse zły
                            {
                                Console.WriteLine("prosze wpisac poprawna liczbe");
                                continue;
                            }

                            if(losowaliczba==cosliczba)
                            {
                                Console.WriteLine("super");
                                break;
                            }
                            if (cosliczba > losowaliczba)//else jest tutaj zbedny
                            {
                                Console.WriteLine("czlowiek podal za duzo");
                            }
                            else
                            {
                                Console.WriteLine("czlowiek podal za malo");
                            }
                        }
                        */
            int year = 2019;

            bool isLeapYear =year % 4 == 0 && year % 100 != 0 || year % 400 == 0;

            Console.WriteLine("czy learp year? {0}",isLeapYear);

            var a = DateTime.Now;

            Console.WriteLine(DateTime.IsLeapYear(year));

            //serilog do monitorowania aktywnosci logowania 

            var log = new LoggerConfiguration()
                .MinimumLevel.Information()
                .WriteTo.Console()
                .CreateLogger();

            log.Information(messageTemplate: "hello info");
            log.Error(messageTemplate: "hello error");


            /// <summary>
            /// </summary>
            /// <param name="args"></param>

            var c = Font.Bold | Font.Underline;

            // Console.WriteLine((c&Font.Underline)==Font.Underline);
            Console.WriteLine(c.HasFlag(Font.Underline));
        }
    }
}
//garbage collector - nie ma delete w C#, sam zarządza pamięcią
