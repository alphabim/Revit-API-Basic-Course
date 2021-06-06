#region Namespaces
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.DB.Structure;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

#endregion

namespace AlphaBIM
{
    public class Lesson06ViewModel
    {
        public Lesson06ViewModel(UIDocument uiDoc)
        {
            // Khởi tạo sự kiện(nếu có) | Initialize event (if have)

            // Lưu trữ data từ Revit | Store data from Revit
            UiDoc = uiDoc;
            Doc = UiDoc.Document;

            // Khởi tạo data cho WPF | Initialize data for WPF
            Initialize();

            // Get setting(if have)

        }

        private void Initialize()
        {
            // code here
        }

        #region public property

        public UIDocument UiDoc;
        public Document Doc;

        public double TopElevation { get; set; }


        #endregion public property

        #region private variable

        private double _percent;

        #endregion private variable

        // Các method khác viết ở dưới đây | Other methods written below

        internal void SetElevationFloor()
        {
            ElementId id = UiDoc.Selection.GetElementIds().FirstOrDefault();
            if (id==null) return;

            Element e = Doc.GetElement(id);

            ElementId idLevel = e.get_Parameter(BuiltInParameter.LEVEL_PARAM)
                .AsElementId();

            Level level = Doc.GetElement(idLevel) as Level;
            if (level == null) return;

            double x = level.Elevation - UnitUtils.ConvertToInternalUnits(TopElevation, UnitTypeId.Meters);

            using (Transaction trans = new Transaction(Doc))
            {
                trans.Start("x");

                e.get_Parameter(BuiltInParameter.FLOOR_HEIGHTABOVELEVEL_PARAM)
                    .Set(-x);

                trans.Commit();
            }

        }
    }
}
