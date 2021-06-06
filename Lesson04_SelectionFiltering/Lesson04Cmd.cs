
#region Namespaces

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Documents;
using System.Windows.Forms;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using Application = Autodesk.Revit.ApplicationServices.Application;

#endregion

namespace AlphaBIM
{
    [Transaction(TransactionMode.Manual)]
    public class Lesson04Cmd : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData,
            ref string message, ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Application app = uiapp.Application;
            Document doc = uidoc.Document;

            // code here

            #region  Cách 1: Dùng class Selection

            #region 1.1: Lấy về các elements đang được chọn trước

            //ICollection<ElementId> ids = uidoc.Selection.GetElementIds();
            //double tong = 0;
            //List<Element> allCot = new List<Element>();

            //foreach (ElementId zzzzz in ids)
            //{
            //    Element e = doc.GetElement(zzzzz);

            //    // Cách 1 để lọc đối tượng: Dùng Category Name
            //    string categoryName = e.Category.Name;

            //    if (categoryName.Equals("Structural Columns"))
            //    {
            //        allCot.Add(e);
            //        Parameter p = e.get_Parameter(BuiltInParameter.HOST_VOLUME_COMPUTED);
            //        tong = tong + p.AsDouble();
            //    }

            //    // Cách 2 để lọc đối tượng: Dùng CategoryId
            //    int categoryId = e.Category.Id.IntegerValue;
            //    int structuralColumnId = (int) BuiltInCategory.OST_StructuralColumns;

            //    if (categoryId == structuralColumnId)
            //    {
            //        allCot.Add(e);
            //    }
            //}

            //tong = UnitUtils.ConvertFromInternalUnits(tong, UnitTypeId.CubicMeters);
            //MessageBox.Show(Math.Round(tong, 3).ToString());

            #endregion 1.1: Lấy về các elements đang được chọn trước

            #region 1.2: PickObject

            #region 1.2.1 Pick một đối tượng, dùng bộ lọc

            /* 1. Lọc Element
             * 2. Lọc Face
             */

            //uidoc.Selection.PickObject(ObjectType.Element);
            //uidoc.Selection.PickObject(ObjectType.Element,"Hay chon Dam");

            //LocCot loc1 = new LocCot();
            //uidoc.Selection.PickObject(ObjectType.Element, loc1);

            //LocCot loc2 = new LocCot();
            //uidoc.Selection.PickObject(ObjectType.Element, loc2, "Hay chon Cot");


            //LocCot locCot = new LocCot(doc);
            //Reference reference = uidoc.Selection.PickObject(ObjectType.Edge, locCot, "Hay chon Face cot");

            //Element e = doc.GetElement(reference);
            //GeometryObject geometryObject = e.GetGeometryObjectFromReference(reference);
            //Face face = geometryObject as Face;

            //if (face != null)
            //{
            //    double dienTich = UnitUtils.ConvertFromInternalUnits(face.Area,
            //        UnitTypeId.SquareMeters);
            //    MessageBox.Show(dienTich.ToString());
            //}

            //IList<Reference> references = uidoc.Selection.PickObjects(ObjectType.Element);
            //foreach (var reference in references)
            //{

            //}


            #endregion 1.2.1 Pick một đối tượng, dùng bộ lọc

            #region 1.2.2 Pick nhiều đối tượng
            #endregion 1.2.2 Pick nhiều đối tượng

            #endregion 1.2: PickObject

            #endregion Cách 1: Dùng class Selection

            #region Cách 2: Dùng class FilteredElementCollector
            // Tham khảo Apply Filter: http://bit.ly/2mDKH5n

            #region 2.1 Áp 1 Filter

            //FilteredElementCollector collector = new FilteredElementCollector(doc, doc.ActiveView.Id);
            //collector = collector.OfCategory(BuiltInCategory.OST_StructuralFraming);
            //IList<Element> allDam = collector.ToElements();

            //foreach (var dam in allDam)
            //{
            //    // ve thep
            //}



            #endregion 2.1 Áp 1 Filter

            #region 2.2 ElementLogicalFilter

            #region 2.2.1 LogicalOrFilter

            #region Cách 1 : Truyền vô 2 Filter

            //FilteredElementCollector collector = new FilteredElementCollector(doc, doc.ActiveView.Id);

            //// public LogicalOrFilter(IList<ElementFilter> filters);
            //// public LogicalOrFilter(ElementFilter filter1, ElementFilter filter2);

            //ElementCategoryFilter filterVach = new ElementCategoryFilter(BuiltInCategory.OST_Walls);
            //ElementCategoryFilter filterCot = new ElementCategoryFilter(BuiltInCategory.OST_StructuralColumns);
            //LogicalOrFilter orFilter = new LogicalOrFilter(filterVach, filterCot);

            //IList<Element> cotOrVach = collector.WherePasses(orFilter).ToElements();
            //MessageBox.Show(cotOrVach.Count.ToString());


            #endregion

            #region Cách 2 : Truyền vô List Filter

            //FilteredElementCollector collector = new FilteredElementCollector(doc, doc.ActiveView.Id);

            //IList<ElementFilter> filters = new List<ElementFilter>();
            //filters.Add(new ElementCategoryFilter(BuiltInCategory.OST_StructuralFraming));
            //filters.Add(new ElementCategoryFilter(BuiltInCategory.OST_StructuralFoundation));
            //filters.Add(new ElementCategoryFilter(BuiltInCategory.OST_Doors));
            //filters.Add(new ElementCategoryFilter(BuiltInCategory.OST_PierPiles));

            //LogicalOrFilter logicalOrFilter = new LogicalOrFilter(filters);

            //collector.WherePasses(logicalOrFilter).ToElementIds();


            #endregion Truyền vô List Filter

            #endregion 2.2.1 LogicalOrFilter



            #region 2.2.2 LogicalAndFilter

            #region Chọn tất cả sàn có level 20

            //FilteredElementCollector collector = new FilteredElementCollector(doc, doc.ActiveView.Id);

            //ElementCategoryFilter filterSan = new ElementCategoryFilter(BuiltInCategory.OST_Floors);

            //Element level20 = new FilteredElementCollector(doc)
            //    .OfClass(typeof(Level))
            //    .FirstOrDefault(l => l.Name.Equals("Level 20"));

            //ElementLevelFilter levelFilter = null;
            //if (level20 != null)
            //{
            //    levelFilter = new ElementLevelFilter(level20.Id);
            //}

            //LogicalAndFilter andFilter = new LogicalAndFilter(filterSan, levelFilter);

            //ICollection<ElementId> elementIds = collector.WherePasses(andFilter).ToElementIds();

            //MessageBox.Show(elementIds.Count.ToString());



            #endregion Chọn tất cả sàn có level 3


            #region Chọn tất cả dầm có Length = 6m

            //FilteredElementCollector collector = new FilteredElementCollector(doc, doc.ActiveView.Id);

            //ElementCategoryFilter filterDam = new ElementCategoryFilter(BuiltInCategory.OST_StructuralFraming);

            //ElementId parameterId = new ElementId(BuiltInParameter.STRUCTURAL_FRAME_CUT_LENGTH);
            //double value = UnitUtils.ConvertToInternalUnits(6, UnitTypeId.Meters); ;
            //double epsilon = 0.01;

            //FilterRule filterRule = ParameterFilterRuleFactory.CreateEqualsRule(parameterId, value, epsilon);

            //ElementParameterFilter pFilter = new ElementParameterFilter(filterRule);

            //LogicalAndFilter andFilter = new LogicalAndFilter(filterDam, pFilter);

            //IList<Element> list = collector.WherePasses(andFilter).ToElements();


            //MessageBox.Show(list.Count.ToString());

            #endregion Chọn tất cả dầm có Length = 6m


            #endregion 2.2.2 LogicalAndFilter

            #endregion 2.2 ElementLogicalFilter




            #region 2.3 ElementMulticategoryFilter, ElementMulticlassFilter

            #region ElementMulticategoryFilter

            //FilteredElementCollector collector = new FilteredElementCollector(doc, doc.ActiveView.Id);

            //ICollection<BuiltInCategory> categories = new List<BuiltInCategory>();
            //categories.Add(BuiltInCategory.OST_Walls);
            //categories.Add(BuiltInCategory.OST_StructuralFraming);

            //ElementMulticategoryFilter filter = new ElementMulticategoryFilter(categories);

            //IList<Element> list = collector.WherePasses(filter).ToElements();
            

            #endregion ElementMulticategoryFilter

            #region ElementMulticlassFilter

            FilteredElementCollector collector = new FilteredElementCollector(doc);


            IList<Type> typeList = new List<Type>();
            typeList.Add(typeof(Floor));
            typeList.Add(typeof(Wall));
            typeList.Add(typeof(Grid));
            typeList.Add(typeof(Level));


            ElementMulticlassFilter multiclassFilter = new ElementMulticlassFilter(typeList);
            IList<Element> list = collector.WherePasses(multiclassFilter).ToElements();

            MessageBox.Show(list.Count.ToString());


            #endregion ElementMulticlassFilter

            #endregion 2.3 ElementMulticategoryFilter, ElementMulticlassFilter




            #endregion Cách 2: Dùng class FilteredElementCollector

            return Result.Succeeded;
        }
    }
}
