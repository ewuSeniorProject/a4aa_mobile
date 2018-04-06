using System;
using System.Collections.Generic;
using System.Text;
using HelloWorld.SurveyClasses.SurveyTables;

namespace HelloWorld.SurveyClasses.SurveySections
{
    class SectionI
    {
        private RestroomT restroomT;
        private Restroom_InfoT restroom_InfoT;

        public RestroomT RestroomT { get => restroomT; set => restroomT = value; }
        public Restroom_InfoT Restroom_InfoT { get => restroom_InfoT; set => restroom_InfoT = value; }
    }
}
