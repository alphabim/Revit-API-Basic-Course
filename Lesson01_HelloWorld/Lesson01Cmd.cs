
#region Namespaces

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
    public class Lesson01Cmd : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData,
            ref string message, ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Application app = uiapp.Application;
            Document doc = uidoc.Document;

            // code here

            Reference r = uidoc.Selection.PickObject(ObjectType.Element);
            Element e = doc.GetElement(r);

            // Get length of element
            Parameter p = e.get_Parameter(BuiltInParameter.INSTANCE_LENGTH_PARAM);

            MessageBox.Show("Length = " + p.AsDouble() + " (ft)");
            MessageBox.Show(string.Concat("Length = ", p.AsDouble(), " (ft)"));

            return Result.Succeeded;
        }
    }
}
