
#region Namespaces

using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.IO;
using System.Reflection;
using Application = Autodesk.Revit.ApplicationServices.Application;

#endregion

namespace AlphaBIM
{
    [Transaction(TransactionMode.Manual)]
    public class TransferParameterCmd : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData,
            ref string message, ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Application app = uiapp.Application;
            Document doc = uidoc.Document;

            // Khi chạy bằng Add-in Manager thì comment 2 dòng bên dưới để tránh lỗi
            // When running with Add-in Manager, comment the 2 lines below to avoid errors
            //string dllFolder = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            //AssemblyLoader.LoadAllRibbonAssemblies(dllFolder);


            // code here

            using (TransactionGroup tranGroup = new TransactionGroup(doc))
            {
                tranGroup.Start("TransferParameterCmd");

                TransferParameterViewModel viewModel = new TransferParameterViewModel(uidoc);
                TransferParameterWindow hieu = new TransferParameterWindow(viewModel);

                bool? dialog = hieu.ShowDialog();

                if (dialog==false) return Result.Cancelled;

                tranGroup.Assimilate();
            }

            return Result.Succeeded;
        }
    }
}
