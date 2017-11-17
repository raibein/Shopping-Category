using Shop.Application.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application.Repository
{
    public interface ICategoryRepository
    {
        List<Category> GetAll();
        void Insert(Category c);
        bool Delete(int id);
        Category GetById(int id);
        List<Category> Search(string pName);
    }

    public class CategoryRepository : ICategoryRepository
    {
        private List<Category> _CategoryList;

        public CategoryRepository()
        {
            _CategoryList = new List<Category>();
        }


        public bool Delete(int id)
        {
            bool _Success = false;

            foreach(Category c in _CategoryList)
            {
                if(c.Id == id)
                {
                    _CategoryList.Remove(c);
                    _Success = true;
                    break;
                }
            }

            return _Success;
        }

        public List<Category> GetAll()
        {
            return _CategoryList;
        }

        public Category GetById(int id)
        {
            Category _Category = null;
            foreach(Category c in _CategoryList)
            {
                if(c.Id == id)
                {
                    _Category = c;
                    break;
                }
            }
            return _Category;
        }

        public void Insert(Category c)
        {
            _CategoryList.Add(c);
        }

        public List<Category> Search(string pName)
        {
            List<Category> _SearchList = new List<Category>();

            foreach(Category c in _CategoryList)
            {
                if(c.Name.StartsWith(pName))
                {
                    _SearchList.Add(c);
                    break;
                }
            }
            return _SearchList;
        }
    }
}
