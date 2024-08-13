using EF_Meyawo.DataAccess.Abstract;
using EF_Meyawo.DataAccess.SqlDbContex;
using EF_Meyawo.Entity.Concret;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Meyawo.DataAccess.Concret
{
    public class BlogRepository : IBlogRepository
    {
        private ManagmentSqlDbContex _dbContex;
        public void Add(Blog entity)
        {
            _dbContex.Blogs.Add(entity);
            _dbContex.SaveChanges();

        }

        public void Delete(Blog entity)
        {
            _dbContex.Blogs.Update(entity);
            _dbContex.SaveChanges();
        }

        public List<Blog> GetAll()
        {
            List<Blog> blogs = _dbContex.Blogs.ToList();
            return blogs;
        }

        public Blog GetByID(int id)
        {
            Blog blog = _dbContex.Blogs.Find(id);
            return blog;
        }

        public void Update(Blog entity)
        {
            _dbContex.Blogs.Update(entity);
            _dbContex.SaveChanges();
        }
    }
}
