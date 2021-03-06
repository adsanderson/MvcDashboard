﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcDashboard.Contracts;

namespace ViewAbsenceWidget
{
    public class WidgetDefinition : MvcDashboard.Contracts.IWidget
    {
        public string GetHtml()
        {
            return ViewAbsenceWidget.Properties.Resources.index;
        }

        public WidgetLayout Getlayout()
        {
            return new WidgetLayout()
            {
                X = 0,
                Y = 0,
                Widh = 7,
                Height = 3
            };
        }

        public string GetScript()
        {
            return ViewAbsenceWidget.Properties.Resources.main;
        }

        public List<string> GetScriptReferences()
        {
            var refs = new List<string>();
            return refs;
        }

        public string GetStyle()
        {
            return ViewAbsenceWidget.Properties.Resources.style;
        }

        public List<string> GetStyleReferences()
        {
            return new List<string>();
        }

        public bool HasAuthority()
        {
            return true;
        }
    }
}