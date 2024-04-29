using EF_Core_Code_First_Books_Project.DataAccess.Abstract;
using EF_Core_Code_First_Books_Project.DataAccess.SqlDbContext;
using EF_Core_Code_First_Books_Project.Entities.Concret;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Code_First_Books_Project.DataAccess.Concret
{
    public class AuthorRepository : IAuthorRepository
    {
        private BookManagmentDbContex _dbContex = new();
        public void Add(Author entity)
        {
            _dbContex.Authors.Add(entity);
            _dbContex.SaveChanges();
        }

        public void DeleteAll()
        {
            foreach (var item in GetAll())
            {
                _dbContex.Authors.Remove(item);
                _dbContex.SaveChanges();
            }
        }

        public void DeleteById(int id)
        {
            Author author = _dbContex.Authors.Find(id);
            if (author != null)
            {
                _dbContex.Authors.Remove(author);
                _dbContex.SaveChanges();
            }
        }

        public Author Get(int id)
        {
            Author author = _dbContex.Authors.Find(id);
            return author;
        }

        public List<Author> GetAll()
        {
            List<Author> authors = _dbContex.Authors.ToList();
            return authors;
        }

        public void Update(Author entity)
        {
            _dbContex.Authors.Update(entity);
            _dbContex.SaveChanges();
        }
    }
}
