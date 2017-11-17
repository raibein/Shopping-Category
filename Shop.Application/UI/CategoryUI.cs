using Shop.Application.Entity;
using Shop.Application.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application.UI
{
    public class CategoryUI
    {
        private CategoryService _CategoryService;

        public CategoryUI(CategoryService pCategoryService)
        {
            this._CategoryService = pCategoryService;
        }

        public void AddScreen()
        {
            while(true)
            {
                Category _Category = new Category();
                Console.WriteLine();
                Console.Write("Enter Id : ");
                _Category.Id = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Name : ");
                _Category.Name = Console.ReadLine();
                _CategoryService.Insert(_Category);
                Console.WriteLine();
                Console.Write("Do you want to continue? [Y / N] : ");
                Console.WriteLine();
                if (Console.ReadLine().ToLower().Equals("n"))
                {
                    Console.WriteLine();
                    break;
                }
            }
        }

        public void ShowCategoryScreen()
        {
            foreach(Category c in _CategoryService.GetAll())
            {
                Console.WriteLine("----------------------------------");
                Console.WriteLine("Id : {0}\r\nName : {1}\n", c.Id, c.Name);
                Console.WriteLine("----------------------------------");
            }
        }

        public void DeleteScreen()
        {
            while(true)
            {
                Console.WriteLine("Enter Id to Delete");
                int id = Convert.ToInt32(Console.ReadLine());

                if (!_CategoryService.Delete(id))
                {
                    Console.WriteLine("Invalid Id Please Try Again !");
                }
                else
                {
                    Console.WriteLine("Given record has been deleted successfully");
                }

                Console.WriteLine();
                Console.Write("Do you want to continue? [Y / N] : ");
                Console.WriteLine();
                if (Console.ReadLine().ToLower().Equals("n"))
                {
                    Console.WriteLine();
                    break;
                }
            }
        }

        public void SearchScreen()
        {

        }
    }
}
