using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtlasCompanyTracker.Models.Models
{
    public class ResourceModel
    {
        public int ID { get; private set; }
        public Guid ResourceGuid { get; private set; }
        public string Name { get; set; }
        public string Thumbnail { get; set; }

        public ResourceModel()
        {
            ResourceGuid = Guid.NewGuid();
        }
    }
}
