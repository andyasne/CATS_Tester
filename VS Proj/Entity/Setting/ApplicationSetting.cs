using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zand.CATSTester.Entity.Enums;
using Zand.CATSTester.Entity.Setting;
/*
 * Holds all settings of the application
 * 
 * 1.Default value for application 
 * 
 * 
 * 
 * */

namespace Zand.CATSTester.Entity
{

   public class ApplicationSetting
    {

        private String applicationClientName;

        public String ApplicationClientName
        {
            get { return applicationClientName; }
            set { applicationClientName = value; }
        }

        private DefaultSetting defaultSetting;

        public DefaultSetting DefaultSetting
        {
            get { return defaultSetting; }
            set { defaultSetting = value; }
        }


        private OptionValue optionValue;

        internal OptionValue OptionValue
        {
            get { return optionValue; }
            set { optionValue = value; }
        }
    }
}
