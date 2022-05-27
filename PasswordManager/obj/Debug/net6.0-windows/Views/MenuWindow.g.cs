﻿#pragma checksum "..\..\..\..\Views\MenuWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B9D9271870E12EA0081B6CA332DD36ED5A8B756E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace PasswordManager.Views {
    
    
    /// <summary>
    /// MenuWindow
    /// </summary>
    public partial class MenuWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\..\..\Views\MenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem MenuItemMyData;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\Views\MenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem MenuItemServices;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\Views\MenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem MenuItemSignOut;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\..\Views\MenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonAdd;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\..\Views\MenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonEdit;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\..\Views\MenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonMyData;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\..\Views\MenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGridPasswords;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/PasswordManager;component/views/menuwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\MenuWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.MenuItemMyData = ((System.Windows.Controls.MenuItem)(target));
            
            #line 31 "..\..\..\..\Views\MenuWindow.xaml"
            this.MenuItemMyData.Click += new System.Windows.RoutedEventHandler(this.MenuItemMyData_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.MenuItemServices = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 3:
            this.MenuItemSignOut = ((System.Windows.Controls.MenuItem)(target));
            
            #line 35 "..\..\..\..\Views\MenuWindow.xaml"
            this.MenuItemSignOut.Click += new System.Windows.RoutedEventHandler(this.MenuItemSignOut_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 61 "..\..\..\..\Views\MenuWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ButtonAdd = ((System.Windows.Controls.Button)(target));
            
            #line 68 "..\..\..\..\Views\MenuWindow.xaml"
            this.ButtonAdd.Click += new System.Windows.RoutedEventHandler(this.ButtonAdd_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ButtonEdit = ((System.Windows.Controls.Button)(target));
            
            #line 76 "..\..\..\..\Views\MenuWindow.xaml"
            this.ButtonEdit.Click += new System.Windows.RoutedEventHandler(this.ButtonEdit_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ButtonMyData = ((System.Windows.Controls.Button)(target));
            
            #line 83 "..\..\..\..\Views\MenuWindow.xaml"
            this.ButtonMyData.Click += new System.Windows.RoutedEventHandler(this.ButtonMyData_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.DataGridPasswords = ((System.Windows.Controls.DataGrid)(target));
            
            #line 93 "..\..\..\..\Views\MenuWindow.xaml"
            this.DataGridPasswords.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DataGridPasswords_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

