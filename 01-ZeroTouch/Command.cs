#region Namespaces
using System;
using System.Collections.Generic;
using System.Diagnostics;
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using RAMDATAACCESSLib;


#endregion

namespace Lab1PlaceGroup
{
    public class GETSIMPLEINFO
    {
        private GETSIMPLEINFO()
        {
        }
        public static int MarcelloAgeNodeNoInput()
        {
            int marcelloAge = 1;
            return marcelloAge;
        }

        public static int MarcelloAgeNodeInput(int fudgefactor = 0)
        {
            int marcelloAge = 1 - fudgefactor;
            return marcelloAge;
        }

    }
}
