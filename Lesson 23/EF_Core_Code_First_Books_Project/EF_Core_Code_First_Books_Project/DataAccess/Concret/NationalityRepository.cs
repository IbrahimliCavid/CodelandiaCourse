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
    public class NationalityRepository : INationalityRepository
    {
        private BookManagmentDbContex _dbContex = new();


        public void Add(Nationality entity)
        {

            _dbContex.Nationalities.Add(entity);
            _dbContex.SaveChanges();
        }

        public void DeleteById(int id)
        {
            Nationality nationality = _dbContex.Nationalities.Find(id);
            if (nationality != null)
            {
                _dbContex.Nationalities.Remove(nationality);
                _dbContex.SaveChanges();
            }

        }

        public void DeleteAll()
        {
            foreach (var item in GetAll())
            {
                _dbContex.Nationalities.Remove(item);
                _dbContex.SaveChanges();
            }
        }

        public Nationality Get(int id)
        {
            Nationality nationality = _dbContex.Nationalities.Find(id);
            return nationality;

        }

        public List<Nationality> GetAll()
        {
            List<Nationality> nationalities = _dbContex.Nationalities.ToList();
            return nationalities;
        }

        public void Update(Nationality entity)
        {
            _dbContex.Nationalities.Update(entity);
            _dbContex.SaveChanges();
        }
    }
}
