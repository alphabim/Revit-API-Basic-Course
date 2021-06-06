using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI.Selection;

namespace AlphaBIM
{
    class LocFaceDam : ISelectionFilter
    {
        public bool AllowElement(Element elem)
        {
            return true;
        }

        public bool AllowReference(Reference reference, XYZ position)
        {
            Element e = _doc.GetElement(reference);

            GeometryObject geometryObject = e.GetGeometryObjectFromReference(reference);
            Face face = geometryObject as Face;

            if (face is CylindricalFace)
            {
                return true;
            }

            return false;
        }

        private Document _doc = null;
        public LocFaceDam(Document doc)
        {
            _doc = doc;
        }
    }
}
