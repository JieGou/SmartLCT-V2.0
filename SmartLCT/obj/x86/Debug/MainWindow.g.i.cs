﻿#pragma checksum "..\..\..\MainWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "0CB75C5D1E28596A4FAA853BC677DCFE"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using GalaSoft.MvvmLight.Command;
using Microsoft.Expression.Controls;
using Microsoft.Expression.Media;
using Microsoft.Expression.Shapes;
using Microsoft.Windows.Themes;
using Nova.SmartLCT.Behavior;
using Nova.SmartLCT.Interface;
using Nova.SmartLCT.SmartLCTControl;
using Nova.SmartLCT.UI;
using Nova.SmartLCT.UI.MetroUI;
using Nova.Wpf.Control;
using SmartLCT;
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
using System.Windows.Interactivity;
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


namespace SmartLCT {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : Nova.SmartLCT.UI.MetroUI.MetroWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 2165 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabControl tabControl1;
        
        #line default
        #line hidden
        
        
        #line 2229 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TreeView treeview1;
        
        #line default
        #line hidden
        
        
        #line 2301 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ToolBar toolBar_File;
        
        #line default
        #line hidden
        
        
        #line 2302 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_New;
        
        #line default
        #line hidden
        
        
        #line 2323 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_OpenFile;
        
        #line default
        #line hidden
        
        
        #line 2344 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_save;
        
        #line default
        #line hidden
        
        
        #line 2365 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_sendToHw;
        
        #line default
        #line hidden
        
        
        #line 2388 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ToolBar toolBar_Edit;
        
        #line default
        #line hidden
        
        
        #line 2389 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_UnDo;
        
        #line default
        #line hidden
        
        
        #line 2410 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_ReDo;
        
        #line default
        #line hidden
        
        
        #line 2431 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_Cut1;
        
        #line default
        #line hidden
        
        
        #line 2452 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_Copy;
        
        #line default
        #line hidden
        
        
        #line 2473 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_Paste;
        
        #line default
        #line hidden
        
        
        #line 2494 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_Delete;
        
        #line default
        #line hidden
        
        
        #line 2515 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_ClearLine;
        
        #line default
        #line hidden
        
        
        #line 2536 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_Increased;
        
        #line default
        #line hidden
        
        
        #line 2557 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_Decrease;
        
        #line default
        #line hidden
        
        
        #line 2578 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_orignalSize;
        
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
            System.Uri resourceLocater = new System.Uri("/SmartLCT;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow.xaml"
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
            
            #line 26 "..\..\..\MainWindow.xaml"
            ((SmartLCT.MainWindow)(target)).Closed += new System.EventHandler(this.CustomWindow_Closed);
            
            #line default
            #line hidden
            
            #line 28 "..\..\..\MainWindow.xaml"
            ((SmartLCT.MainWindow)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.tabControl1 = ((System.Windows.Controls.TabControl)(target));
            return;
            case 3:
            this.treeview1 = ((System.Windows.Controls.TreeView)(target));
            return;
            case 4:
            this.toolBar_File = ((System.Windows.Controls.ToolBar)(target));
            return;
            case 5:
            this.button_New = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.button_OpenFile = ((System.Windows.Controls.Button)(target));
            return;
            case 7:
            this.button_save = ((System.Windows.Controls.Button)(target));
            return;
            case 8:
            this.button_sendToHw = ((System.Windows.Controls.Button)(target));
            return;
            case 9:
            this.toolBar_Edit = ((System.Windows.Controls.ToolBar)(target));
            return;
            case 10:
            this.button_UnDo = ((System.Windows.Controls.Button)(target));
            return;
            case 11:
            this.button_ReDo = ((System.Windows.Controls.Button)(target));
            return;
            case 12:
            this.button_Cut1 = ((System.Windows.Controls.Button)(target));
            return;
            case 13:
            this.button_Copy = ((System.Windows.Controls.Button)(target));
            return;
            case 14:
            this.button_Paste = ((System.Windows.Controls.Button)(target));
            return;
            case 15:
            this.button_Delete = ((System.Windows.Controls.Button)(target));
            return;
            case 16:
            this.button_ClearLine = ((System.Windows.Controls.Button)(target));
            return;
            case 17:
            this.button_Increased = ((System.Windows.Controls.Button)(target));
            return;
            case 18:
            this.button_Decrease = ((System.Windows.Controls.Button)(target));
            return;
            case 19:
            this.button_orignalSize = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

