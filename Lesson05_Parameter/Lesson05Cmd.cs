
#region Namespaces

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Documents;
using System.Windows.Forms;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.DB.Structure;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using Application = Autodesk.Revit.ApplicationServices.Application;

#endregion

namespace AlphaBIM
{
    [Transaction(TransactionMode.Manual)]
    public class Lesson05Cmd : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData,
            ref string message, ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Application app = uiapp.Application;
            Document doc = uidoc.Document;

            // code here

            //#region 2 Cách lấy về giá trị Parameter

            ////Reference r = uidoc.Selection.PickObject(ObjectType.Element);
            ////Element e = doc.GetElement(r);

            ////// cách 1: get_Parameter
            ////Parameter p = e.get_Parameter(BuiltInParameter.ALL_MODEL_INSTANCE_COMMENTS);
            ////string value = p.AsString();

            ////// cách 2: LookupParameter
            ////Parameter p2 = e.LookupParameter("ALB_Column Height");
            ////double value2 = p.AsDouble();

            //#endregion

            //#region Gán giá trị vào parameter

            ////Reference r = uidoc.Selection.PickObject(ObjectType.Element);
            ////Element e = doc.GetElement(r);

            //////// cách 2: LookupParameter
            //////Parameter p = e.LookupParameter("Comments");


            //////Transaction t = new Transaction(doc, "Set value");
            //////t.Start();
            //////// code thay đổi model
            //////p.Set("Set value from API");

            //////t.Commit();

            //////using (Transaction t2 = new Transaction(doc, "Set value"))
            //////{
            //////    string aaaa = "ffff";
            //////    t2.Start();
            //////    // code thay đổi model
            //////    p.Set("Set value from API");

            //////    t2.Commit();
            //////}


            ////Parameter pTopCover = e.get_Parameter(BuiltInParameter.CLEAR_COVER_TOP);

            ////List<Element> listRebarCoverType = new FilteredElementCollector(doc)
            ////    .OfClass(typeof(RebarCoverType))
            ////    .ToElements().ToList();

            ////Element coverType = listRebarCoverType
            ////    .FirstOrDefault(cover => cover.Name.Equals("Vách 3000000"));

            //////foreach (var cover in listRebarCoverType)
            //////{
            //////    if (cover.Name.Equals("Vách 30"))// <30 mm>
            //////    {
            //////        coverType = cover;
            //////        break;
            //////    }
            //////}

            ////if (coverType == null)
            ////{
            ////    MessageBox.Show("Dự án không có Rebar Cover có tên Vách 3000000");
            ////    return Result.Cancelled;
            ////}


            ////using (Transaction t2 = new Transaction(doc, "Change Cover Type"))
            ////{
            ////    string aaaa = "ffff";
            ////    t2.Start();

            ////    // code thay đổi model
            ////    pTopCover.Set(coverType.Id);

            ////    t2.Commit();
            ////}




            //#endregion

            //#region Tạo Shared Parameter


            ////string path = @"C:\Users\Alpha BIM\Desktop\ALB_SharedParameter.txt";
            ////string group = "ARC";
            ////string name = "NGAY THI CONG";
            ////string description = "Biến này chứa thông tin về ngày thi công";

            ////List<Category> categories = new List<Category>();
            ////categories.Add(Category.GetCategory(doc,BuiltInCategory.OST_StructuralFraming));
            ////categories.Add(Category.GetCategory(doc,BuiltInCategory.OST_StructuralColumns));


            ////Transaction t = new Transaction(doc, "Tạo Shared Parameter");
            ////t.Start();

            ////ParameterUtils.CreateSharedParamater(doc, app, path, group, name,
            ////    ParameterType.Text, BuiltInParameterGroup.PG_TEXT, description,
            ////    categories,false);

            ////t.Commit();

            //#endregion Tạo Shared Parameter

            //#region Extension Method 

            //Reference r = uidoc.Selection.PickObject(ObjectType.Element);
            //Element e = doc.GetElement(r);

            //Parameter p = e.LookupParameter("ALB_Column Height");
            //p.GetValue(true);

            //ParameterUtils.GetValue(p, true);

            //string value = p.GetValue(true);

            //MessageBox.Show(value);

            //#endregion

            //#region Tạo thư viện tham chiếu

            

            //#endregion


            return Result.Succeeded;
        }
    }
}
