using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI.Selection;

namespace AlphaBIM
{
    class LocCot : ISelectionFilter
    {
        public bool AllowElement(Element elem)
        {
            // Cách 2: để lọc đối tượng: Dùng CategoryId
            int categoryId = elem.Category.Id.IntegerValue;
            int structuralColumnId = (int)BuiltInCategory.OST_StructuralColumns;
            if (categoryId == structuralColumnId)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool AllowReference(Reference reference, XYZ position)
        {
            return true;
        }
    }
}
