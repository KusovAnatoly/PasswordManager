﻿#pragma checksum "..\..\..\..\Views\ServicesWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5571D4F1B1D50ABD91ED9FB69E8C0CFC2FA256C5"
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
using PasswordManager.Views;
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
    /// ServicesWindow
    /// </summary>
    public partial class ServicesWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\..\Views\ServicesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxEmail;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\Views\ServicesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxLogin;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\Views\ServicesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox PassBoxPassword;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\Views\ServicesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox PassBoxRepeatPassword;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\..\Views\ServicesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxFirstName;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\..\Views\ServicesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxLastName;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\..\Views\ServicesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker DatePickerBirthDate;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\..\Views\ServicesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextBlockValidation;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\..\Views\ServicesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonSignUp;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\..\Views\ServicesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonCancel;
        
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
            System.Uri resourceLocater = new System.Uri("/PasswordManager;component/views/serviceswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\ServicesWindow.xaml"
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
            this.TextBoxEmail = ((System.Windows.Controls.TextBox)(target));
            
            #line 28 "..\..\..\..\Views\ServicesWindow.xaml"
            this.TextBoxEmail.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TextBoxLogin = ((System.Windows.Controls.TextBox)(target));
            
            #line 37 "..\..\..\..\Views\ServicesWindow.xaml"
            this.TextBoxLogin.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.PassBoxPassword = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 44 "..\..\..\..\Views\ServicesWindow.xaml"
            this.PassBoxPassword.PasswordChanged += new System.Windows.RoutedEventHandler(this.PassBoxPassword_PasswordChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.PassBoxRepeatPassword = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 51 "..\..\..\..\Views\ServicesWindow.xaml"
            this.PassBoxRepeatPassword.PasswordChanged += new System.Windows.RoutedEventHandler(this.PassBoxPassword_PasswordChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.TextBoxFirstName = ((System.Windows.Controls.TextBox)(target));
            
            #line 57 "..\..\..\..\Views\ServicesWindow.xaml"
            this.TextBoxFirstName.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.TextBoxLastName = ((System.Windows.Controls.TextBox)(target));
            
            #line 63 "..\..\..\..\Views\ServicesWindow.xaml"
            this.TextBoxLastName.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.DatePickerBirthDate = ((System.Windows.Controls.DatePicker)(target));
            
            #line 69 "..\..\..\..\Views\ServicesWindow.xaml"
            this.DatePickerBirthDate.SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.DatePickerBirthDate_SelectedDateChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.TextBlockValidation = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.ButtonSignUp = ((System.Windows.Controls.Button)(target));
            
            #line 81 "..\..\..\..\Views\ServicesWindow.xaml"
            this.ButtonSignUp.Click += new System.Windows.RoutedEventHandler(this.ButtonSignUp_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.ButtonCancel = ((System.Windows.Controls.Button)(target));
            
            #line 86 "..\..\..\..\Views\ServicesWindow.xaml"
            this.ButtonCancel.Click += new System.Windows.RoutedEventHandler(this.ButtonCancel_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

