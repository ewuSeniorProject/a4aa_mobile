using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.SurveyClasses.SurveyTables
{
    class ConfigurationT
    {
        private string name;

        public string Name
        {
            get => name;
            set
            {
                if (value.Length > 255)
                    throw new ArgumentOutOfRangeException();

                name = value;
            }
        }
    }
}
