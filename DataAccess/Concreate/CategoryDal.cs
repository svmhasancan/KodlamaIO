using KodlamaIO.DataAccess.Abstracts;
using KodlamaIO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KodlamaIO.DataAccess.Concreate
{
    public class CategoryDal : ICategoryDal
    {
        List<Category> _categories;
        public CategoryDal()
        {
            _categories = new List<Category>()
            {
                new Category()
                {
                    CategoryId = 11,
                    CategoryName = "Programlama"
                },
                new Category()
                {
                    CategoryId = 12,
                    CategoryName = "Mobil Programlama"
                },
                new Category(){
                    CategoryId = 13,
                    CategoryName = "Web Programlama"
                }
            };
        }

        public void Add(Category category)
        {
            _categories.Add(category);
        }

        public void Delete(Category category)
        {
            _categories.RemoveAll(
                deleteCategory => 
                    deleteCategory.CategoryId == category.CategoryId
                    &&
                    deleteCategory.CategoryName.ToUpper() == category.CategoryName.ToUpper()
            );
        }

        public List<Category> GetAll()
        {
            return _categories;
        }

        public void Update(Category category)
        {
            foreach(Category updatedCategory in _categories)
            {
                if(updatedCategory.CategoryId == category.CategoryId)
                {
                    updatedCategory.CategoryName = category.CategoryName;
                }
            }
        }
    }
}
