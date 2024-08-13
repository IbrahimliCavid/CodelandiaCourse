using EF_Meyawo.DataAccess.Abstract;
using EF_Meyawo.DataAccess.SqlDbContex;
using EF_Meyawo.Entity.Concret;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Meyawo.DataAccess.Concret
{
    public class PortfoiloRepository : IPortfoiloRepository
    {
        private ManagmentSqlDbContex _dbContex;
        public void Add(Portfoilo entity)
        {
            _dbContex.Portfoils.Add(entity);
            _dbContex.SaveChanges();

        }

        public void Delete(Portfoilo entity)
        {
            _dbContex.Portfoils.Update(entity);
            _dbContex.SaveChanges();
        }

        public List<Portfoilo> GetAll()
        {

            List<Portfoilo> portfoilos = _dbContex.Portfoils.ToList();
            return portfoilos;
        }

        public Portfoilo GetByID(int id)
        {
            Portfoilo portfoilo = _dbContex.Portfoils.Find(id);
            return portfoilo;
        }

        public void Update(Portfoilo entity)
        {
            _dbContex.Portfoils.Update(entity);
            _dbContex.SaveChanges();
        }
    }
}
