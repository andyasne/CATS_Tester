using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zand.CATSTester.Entity.Feature
{
   public class Feature
    {
       public Guid Id { get; set; }

       public DateTime CreatedDate { get; set; }

       public Properties Properties { get; set; }

       public ActionFlow ActionFlow { get; set; }

       public List<FeatureData> FeatureData { get; set; }
    }
}
