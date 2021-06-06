#region Namespaces

using Autodesk.Revit.DB;
using Autodesk.Revit.UI.Selection;
#endregion

namespace AlphaBIM
{
    public class PlanarFaceSelectionFilter : ISelectionFilter
    {
        private readonly Document _doc;
        public PlanarFaceSelectionFilter(Document doc)
        {
            _doc = doc;
        }

        /// <summary>
        /// Cho phép chọn el nếu kết quả của hàm trả về true
        /// </summary>
        /// <param name="el"></param>
        /// <returns></returns>
        public bool AllowElement(Element el)
        {
            return true;
        }

        /// <summary>
        /// Cho phép chọn el nếu kết quả của hàm trả về true
        /// </summary>
        /// <param name="reference"></param>
        /// <param name="position"></param>
        /// <returns></returns>
        public bool AllowReference(Reference reference, XYZ position)
        {
            // Tham khảo: http://bit.ly/2oa9NcF

            Element e = _doc.GetElement(reference);
            GeometryObject geoObject = 
                e.GetGeometryObjectFromReference(reference);

            return geoObject is PlanarFace;
        }
    }
}