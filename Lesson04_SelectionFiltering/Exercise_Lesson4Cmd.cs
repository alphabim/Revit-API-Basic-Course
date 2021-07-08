
#region Namespaces

using System;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Application = Autodesk.Revit.ApplicationServices.Application;

#endregion

namespace AlphaBIM
{
    [Transaction(TransactionMode.Manual)]
    public class Exercise_Lesson4Cmd : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData,
            ref string message, ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Application app = uiapp.Application;
            Document doc = uidoc.Document;


            #region Code Alpha BIM sửa bài tập

            // Lấy về Id của các đối tượng đang được chọn trước
            ICollection<ElementId> elementIds = uidoc.Selection.GetElementIds();

            // Lấy về 1 Dầm đang được chọn trước
            Element framing = null;
            foreach (ElementId id in elementIds)
            {
                Element e = doc.GetElement(id);

                //Kiểm tra điều kiện là dầm hay không
                int idIntegerValue = e.Category.Id.IntegerValue;
                if (idIntegerValue == (int)BuiltInCategory.OST_StructuralFraming)
                {
                    framing = e;
                    break;
                }
            }

            if (framing == null) return Result.Cancelled;

            // Lấy về chiều dài của Dầm đang được chọn trước
            double beamLength = framing.get_Parameter(BuiltInParameter.INSTANCE_LENGTH_PARAM).AsDouble();

            // Lấy về Level của Dầm đang được chọn trước
            ElementId beamLevelId = framing.get_Parameter(BuiltInParameter.INSTANCE_REFERENCE_LEVEL_PARAM).AsElementId();

            // Tạo collector
            FilteredElementCollector collector = new FilteredElementCollector(doc, doc.ActiveView.Id);

            // Tạo bộ lọc Dầm
            ElementCategoryFilter filterDam = new ElementCategoryFilter(BuiltInCategory.OST_StructuralFraming);

            // Tạo bộ lọc chiều dài
            ElementId parameterId = new ElementId(BuiltInParameter.STRUCTURAL_FRAME_CUT_LENGTH);
            double value = beamLength;
            double epsilon = 0.01;
            FilterRule filterRule = ParameterFilterRuleFactory.CreateEqualsRule(parameterId, value, epsilon);
            ElementParameterFilter lengthFilter = new ElementParameterFilter(filterRule);

            // Tạo bộ lọc Level
            parameterId = new ElementId(BuiltInParameter.INSTANCE_REFERENCE_LEVEL_PARAM);
            filterRule = ParameterFilterRuleFactory.CreateEqualsRule(parameterId, beamLevelId);
            ElementParameterFilter levelFilter = new ElementParameterFilter(filterRule);

            // Tạo LogicalAndFilter
            IList<ElementFilter> filters = new List<ElementFilter>();
            filters.Add(filterDam);
            filters.Add(lengthFilter);
            filters.Add(levelFilter);
            LogicalAndFilter andFilter = new LogicalAndFilter(filters);

            // Áp filter vào collector và trả về danh sách id của các Dầm thõa điều kiện lọc 
            IList<ElementId> allDam = collector.WherePasses(andFilter).ToElementIds().ToList();

            // Chọn các Dầm thõa điều kiện lọc
            uidoc.Selection.SetElementIds(allDam);

            // Show ra màn hình số lượng Dầm thõa điều kiện lọc     
            MessageBox.Show(allDam.Count.ToString());

            #endregion

            return Result.Succeeded;
        }
    }
}
