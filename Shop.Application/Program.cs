using Shop.Application.Entity;
using Shop.Application.Service;
using Shop.Application.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            CategoryUI _CagegoryUI = new CategoryUI(new CategoryService());

            while(true)
            {
                Console.WriteLine();
                Console.WriteLine("======================================");
                Console.WriteLine("==== Shopping Category ====");
                Console.WriteLine("======================================");
                Console.WriteLine("1 -- Add Category");
                Console.WriteLine("2 -- Get All Category");
                Console.WriteLine("3 -- Get Category By Id");
                Console.WriteLine("4 -- Search by Name");
                Console.WriteLine("5 -- Delete Category by Id");
                Console.WriteLine("6 -- Exit");
                Console.WriteLine("====================================");

                int Choice = Convert.ToInt32(Console.ReadLine());

                switch (Choice)
                {
                    case 1:
                        _CagegoryUI.AddScreen();
                        break;

                    case 2:
                        _CagegoryUI.ShowCategoryScreen();
                        break;

                    case 3:
                        break;

                    case 4:
                        break;

                    case 5:
                        _CagegoryUI.DeleteScreen();
                        break;

                    case 6:
                        System.Environment.Exit(0);
                        break;
                }
            }           
        }
    }
}
