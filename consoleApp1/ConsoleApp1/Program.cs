using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            // retttrrrrrrr
            // test comment stash
            // test statsh master
            // test comment playwithstash
            // test comment master
            Console.WriteLine("Hello World!");
            PlayWithDish();
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
        public static void SetThirdIngredient(string[] ingredients)
        {
            for (int i = 0; i < ingredients.Length; i++)
            {
                if (ingredients[i] != "")
                {
                    ingredients[i] = "";
                    break;
                }
            }
        }
        public static void PlayWithDish()
        {
            string ingrediantId = Console.ReadLine();
          
            string[] ingredients = ingrediantId.Split(' ');
            int days = Convert.ToInt32(Console.ReadLine());
            int check = -1, check1 = -1, check2 = -1;
          
            for (int i = 0; i < days; i++)
            {
                check = -1; check1 = -1; check2 = -1;
                if (i >= 2)
                {
                    for (int j = 0; j <= i; j++)
                    {

                        if (ingredients[j].Contains("FIBER"))
                        {
                            if (check != -1 && ingredients[j] != ingredients[check])
                            {
                                ingredients[j] = "";
                                ingredients[check] = "";
                                SetThirdIngredient(ingredients);
                                check = -2;
                                break;
                            }
                            else
                            {
                                check = j;
                            }
                        }
                        if (ingredients[j].Contains("CARB"))
                        {
                            if (check1 != -1 && ingredients[j] != ingredients[check1])
                            {
                                ingredients[j] = "";
                                ingredients[check1] = "";
                                SetThirdIngredient(ingredients);
                                check = -2;
                                break;
                            }
                            else
                            {
                                check1 = j;
                            }
                        }
                        if (ingredients[j].Contains("FAT"))
                        {
                            if (check2 != -1 && ingredients[j] != ingredients[check2])
                            {
                                ingredients[j] = "";
                                ingredients[check2] = "";
                                SetThirdIngredient(ingredients);
                                check = -2;
                                break;
                            }
                            else
                            {
                                check2 = j;
                            }
                        }
                    }
                    if (check == -2)
                        Console.Write(1);
                    else
                        Console.Write(0);
                }
                else
                {
                    Console.Write(0);
                }

            }

        }
    }
}
