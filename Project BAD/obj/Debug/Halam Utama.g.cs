﻿#pragma checksum "..\..\Halam Utama.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "EB843A605EE9FD3ADF9E40F4B6778E429DCC6AA64DAD166928C9D5FC6C48749E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Project_BAD;
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


namespace Project_BAD {
    
    
    /// <summary>
    /// Halam_Utama
    /// </summary>
    public partial class Halam_Utama : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\Halam Utama.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnData;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\Halam Utama.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnStat;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\Halam Utama.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLogout;
        
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
            System.Uri resourceLocater = new System.Uri("/Project BAD;component/halam%20utama.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Halam Utama.xaml"
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
            this.btnData = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\Halam Utama.xaml"
            this.btnData.Click += new System.Windows.RoutedEventHandler(this.BtnData);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnStat = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\Halam Utama.xaml"
            this.btnStat.Click += new System.Windows.RoutedEventHandler(this.BtnStat);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnLogout = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\Halam Utama.xaml"
            this.btnLogout.Click += new System.Windows.RoutedEventHandler(this.BtnLogout);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
