using Shop.Application.Entity;
using Shop.Application.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application.Service
{
    public class CategoryService
    {
        private ICategoryRepository _CagetoryRepository = new CategoryRepository();

        public List<Category> GetAll()
        {
            return _CagetoryRepository.GetAll();
        }

        public Category GetById(int id)
        {
            return _CagetoryRepository.GetById(id);
        }

        public void Insert(Category c)
        {
            _CagetoryRepository.Insert(c);
        }

        public bool Delete(int id)
        {
            return _CagetoryRepository.Delete(id);
        }

        public List<Category> Search(string pName)
        {
            return _CagetoryRepository.Search(pName);
        }
    }
}
