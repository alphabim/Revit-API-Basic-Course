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
    public class TransferParameterViewModel
    {
        public TransferParameterViewModel(UIDocument uiDoc)
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

            List<Element> allFloor = new FilteredElementCollector(Doc, Doc.ActiveView.Id)
                .OfClass(typeof(Floor)).ToList();
            ParameterSet parameterSet = allFloor[0].Parameters;

            foreach (Parameter p in parameterSet)
            {
                AllSourceParameter.Add(p.Definition.Name);
                if (p.Definition.ParameterType==ParameterType.Text && !p.IsReadOnly)
                {
                    AllTargetParameter.Add(p.Definition.Name);
                }
            }
        }

        #region public property

        public UIDocument UiDoc;
        public Document Doc;

        public List<string> AllSourceParameter { get; set; } = new List<string>();
        public string SelectedSourceParameter { get; set; }  
        
        public List<string> AllTargetParameter { get; set; } = new List<string>();
        public string SelectedTargetParameter { get; set; }



        #endregion public property

        #region private variable

        private double _percent;

        #endregion private variable

        // Các method khác viết ở dưới đây | Other methods written below

       
    }
}
