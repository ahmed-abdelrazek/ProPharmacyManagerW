﻿#pragma checksum "..\..\CP.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "FFE3CF294947CA4532EE37861C183506"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ProPharmacyManagerW.Controls;
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


namespace ProPharmacyManagerW {
    
    
    /// <summary>
    /// CP
    /// </summary>
    public partial class CP : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 5 "..\..\CP.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ProPharmacyManagerW.CP PCP;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\CP.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GridPanel1;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\CP.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ProPharmacyManagerW.Controls.ImageButton button1;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\CP.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ProPharmacyManagerW.Controls.ImageButton imageButton1;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\CP.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image image1;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\CP.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border border1;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\CP.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame FFhost;
        
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
            System.Uri resourceLocater = new System.Uri("/ProPharmacyManagerW;component/cp.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\CP.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            this.PCP = ((ProPharmacyManagerW.CP)(target));
            
            #line 5 "..\..\CP.xaml"
            this.PCP.KeyDown += new System.Windows.Input.KeyEventHandler(this.PCP_KeyDown);
            
            #line default
            #line hidden
            
            #line 5 "..\..\CP.xaml"
            this.PCP.Loaded += new System.Windows.RoutedEventHandler(this.PCP_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.GridPanel1 = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.button1 = ((ProPharmacyManagerW.Controls.ImageButton)(target));
            return;
            case 4:
            this.imageButton1 = ((ProPharmacyManagerW.Controls.ImageButton)(target));
            return;
            case 5:
            this.image1 = ((System.Windows.Controls.Image)(target));
            return;
            case 6:
            this.border1 = ((System.Windows.Controls.Border)(target));
            
            #line 19 "..\..\CP.xaml"
            this.border1.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.border1_MouseDown);
            
            #line default
            #line hidden
            return;
            case 7:
            this.FFhost = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

