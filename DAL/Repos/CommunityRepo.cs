using DAL.Interface;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class CommunityRepo : Repo, IRepo<Community, int, bool>
    {
        public bool Delete(int id)
        {
            var data = db.Communities.Find(id);
            db.Communities.Remove(data);
            return db.SaveChanges() > 0;
        }

        public List<Community> Get()
        {
            return db.Communities.ToList();
        }

        public Community Get(int id)
        {
            return db.Communities.Find(id);
        }

        public bool Insert(Community obj)
        {
            db.Communities.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Update(Community obj)
        {
            var data = db.Communities.Find(obj.Id);
            db.Entry(data).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
