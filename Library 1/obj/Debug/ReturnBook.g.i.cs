﻿#pragma checksum "..\..\ReturnBook.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9AB79ABFC052D61333289558B82903513BCAAE0B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace Library_1 {
    
    
    /// <summary>
    /// ReturnBook
    /// </summary>
    public partial class ReturnBook : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 6 "..\..\ReturnBook.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DATAGRID;
        
        #line default
        #line hidden
        
        
        #line 7 "..\..\ReturnBook.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnShowD;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\ReturnBook.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBookIssueDate;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\ReturnBook.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBookName;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\ReturnBook.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dateTimePicker3;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\ReturnBook.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnreturn;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\ReturnBook.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btncancel;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\ReturnBook.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtEnrollbox1;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\ReturnBook.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnrefresh;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\ReturnBook.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnexit;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\ReturnBook.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtEnrollbox3;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\ReturnBook.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button close;
        
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
            System.Uri resourceLocater = new System.Uri("/Library 1;component/returnbook.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ReturnBook.xaml"
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
            this.DATAGRID = ((System.Windows.Controls.DataGrid)(target));
            
            #line 6 "..\..\ReturnBook.xaml"
            this.DATAGRID.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DATAGRID_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnShowD = ((System.Windows.Controls.Button)(target));
            
            #line 7 "..\..\ReturnBook.xaml"
            this.btnShowD.Click += new System.Windows.RoutedEventHandler(this.btnShowD_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtBookIssueDate = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtBookName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.dateTimePicker3 = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 6:
            this.btnreturn = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\ReturnBook.xaml"
            this.btnreturn.Click += new System.Windows.RoutedEventHandler(this.btnreturn_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btncancel = ((System.Windows.Controls.Button)(target));
            return;
            case 8:
            this.txtEnrollbox1 = ((System.Windows.Controls.TextBox)(target));
            
            #line 21 "..\..\ReturnBook.xaml"
            this.txtEnrollbox1.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtEnrollbox1_TextChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnrefresh = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\ReturnBook.xaml"
            this.btnrefresh.Click += new System.Windows.RoutedEventHandler(this.btnrefresh_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btnexit = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\ReturnBook.xaml"
            this.btnexit.Click += new System.Windows.RoutedEventHandler(this.btnexit_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.txtEnrollbox3 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            this.close = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\ReturnBook.xaml"
            this.close.Click += new System.Windows.RoutedEventHandler(this.close_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
