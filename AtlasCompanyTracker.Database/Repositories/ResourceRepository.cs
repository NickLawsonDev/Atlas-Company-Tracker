using AtlasCompanyTracker.Database.Contexts;
using AtlasCompanyTracker.Models.Models;
using System.Collections.Generic;
using System.Linq;

namespace AtlasCompanyTracker.Database.Repositories
{
    public class ResourceRepository
    {
        public static ResourceModel GetResource(int id)
        {
            using (var db = new ResourceContext())
            {
                return db.Resources.Where(x => x.ID == id).FirstOrDefault();
            }
        }

        public static ResourceModel GetResource(string name)
        {
            using (var db = new ResourceContext())
            {
                return db.Resources.Where(x => x.Name == name).FirstOrDefault();
            }
        }

        public static IEnumerable<ResourceModel> GetResources()
        {
            using (var db = new ResourceContext())
            {
                return db.Resources.ToList();
            }
        }

        public static bool CreateNewResource(ResourceModel resource)
        {
            if (resource == null) return false;

            using (var db = new ResourceContext())
            {
                db.Resources.Add(resource);
                db.SaveChanges();
                return true;
            }
        }

        public static bool DeleteResource(int id)
        {
            if (id <= 0) return false;

            using (var db = new ResourceContext())
            {
                var resource = db.Resources.Where(x => x.ID == id).FirstOrDefault();
                db.Resources.Remove(resource);
                db.SaveChanges();
                return true;
            }
        }

        public static bool UpdateResource(int id)
        {
            if (id <= 0) return false;

            using (var db = new ResourceContext())
            {
                var resource = db.Resources.Where(x => x.ID == id).FirstOrDefault();
                var oldResource = db.Resources.Where(x => x.ID == resource.ID).FirstOrDefault();
                if (oldResource == null) return false;

                oldResource = resource;
                db.Resources.Update(oldResource);
                db.SaveChanges();
                return true;
            }
        }
    }
}
