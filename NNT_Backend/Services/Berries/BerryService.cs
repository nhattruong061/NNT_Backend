using NNT_Backend.Entities.Berries;
using NNT_Backend.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NNT_Backend.Services.Berries
{
    public interface IBerryService
    {
        IEnumerable<Berry> GetAll();
        Berry GetById(int id);
        Berry Create(Berry berry);
        void Update(Berry berry);
        void Delete(int id);
    }
    public class BerryService: IBerryService
    {
        private DataContext _context;

        public BerryService(DataContext context)
        {
            _context = context;
        }

        public Berry Create(Berry berry)
        {
            _context.Berries.Add(berry);
            _context.SaveChanges();

            return berry;
        }

        public void Delete(int id)
        {
            var berry = _context.Berries.Find(id);
            if (berry != null)
            {
                _context.Berries.Remove(berry);
                _context.SaveChanges();
            }
        }

        public IEnumerable<Berry> GetAll()
        {
            return _context.Berries;
        }

        public Berry GetById(int id)
        {
            var berry = _context.Berries.Find(id);
            if (berry != null)
            {
                return berry;
            }

            return null;
        }

        public void Update(Berry berry)
        {
            _context.Berries.Update(berry);
            _context.SaveChanges();
        }
    }
}

