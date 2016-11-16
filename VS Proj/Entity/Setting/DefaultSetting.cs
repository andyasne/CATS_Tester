using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zand.CATSTester.Entity.Enums;

namespace Zand.CATSTester.Entity.Setting
{
  public  class DefaultSetting
    {

      public DefaultSetting()
      {
          Initialize();
      }

      void Initialize()
      {
          this.Browser = Browser.Chrome;

          

      }


        public ScreenDefault ScreenDefault{get;set;}

        public Browser Browser { get; set; }

        public String ServerBranch { get; set; }

        public Boolean CheckRunAllFeatures { get; set; }

        public Boolean CheckRunSelectedFeatures { get; set; }

        public Boolean CheckTestAllDataofFeatures { get; set; }

        public Boolean SynchOnStart { get; set; }

        public int DefaultSpeed { get; set; }



    }
}
