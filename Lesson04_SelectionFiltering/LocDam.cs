using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI.Selection;

namespace AlphaBIM
{
    class LocDam : ISelectionFilter
    {
        public bool AllowElement(Element elem)
        {
            int categoryId = elem.Category.Id.IntegerValue;
            if (categoryId == (int) BuiltInCategory.OST_StructuralFraming)
            {
                return true;
            }

            return false;
        }

        public bool AllowReference(Reference reference, XYZ position)
        {
            return true;
        }
    }
}
