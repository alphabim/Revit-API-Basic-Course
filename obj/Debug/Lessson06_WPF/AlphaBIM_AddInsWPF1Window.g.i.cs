﻿#pragma checksum "..\..\..\Lessson06_WPF\AlphaBIM_AddInsWPF1Window.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D9555DF7937A0D302C414D4F057A9F8A569B6857360BB9CE5F0BC84708F0583F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using AlphaBIM;
using MahApps.Metro;
using MahApps.Metro.Accessibility;
using MahApps.Metro.Actions;
using MahApps.Metro.Automation.Peers;
using MahApps.Metro.Behaviors;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using MahApps.Metro.Converters;
using MahApps.Metro.Markup;
using MahApps.Metro.Theming;
using MahApps.Metro.ValueBoxes;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace AlphaBIM {
    
    
    /// <summary>
    /// AlphaBIM_AddInsWPF1Window
    /// </summary>
    public partial class AlphaBIM_AddInsWPF1Window : MahApps.Metro.Controls.MetroWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\..\Lessson06_WPF\AlphaBIM_AddInsWPF1Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal AlphaBIM.AlphaBIM_AddInsWPF1Window MainWindow;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\Lessson06_WPF\AlphaBIM_AddInsWPF1Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel MainPanel;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/AlphaBIM_RevitAPI_Training;component/lessson06_wpf/alphabim_addinswpf1window.xam" +
                    "l", System.UriKind.Relative);
            
            #line 1 "..\..\..\Lessson06_WPF\AlphaBIM_AddInsWPF1Window.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.MainWindow = ((AlphaBIM.AlphaBIM_AddInsWPF1Window)(target));
            
            #line 13 "..\..\..\Lessson06_WPF\AlphaBIM_AddInsWPF1Window.xaml"
            this.MainWindow.KeyDown += new System.Windows.Input.KeyEventHandler(this.MainWindow_KeyDown);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 45 "..\..\..\Lessson06_WPF\AlphaBIM_AddInsWPF1Window.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OpenWebSite);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 50 "..\..\..\Lessson06_WPF\AlphaBIM_AddInsWPF1Window.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CustomDevelopment);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 61 "..\..\..\Lessson06_WPF\AlphaBIM_AddInsWPF1Window.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Feedback);
            
            #line default
            #line hidden
            return;
            case 5:
            this.MainPanel = ((System.Windows.Controls.DockPanel)(target));
            return;
            case 6:
            
            #line 89 "..\..\..\Lessson06_WPF\AlphaBIM_AddInsWPF1Window.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnCancel_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 97 "..\..\..\Lessson06_WPF\AlphaBIM_AddInsWPF1Window.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnOk_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

