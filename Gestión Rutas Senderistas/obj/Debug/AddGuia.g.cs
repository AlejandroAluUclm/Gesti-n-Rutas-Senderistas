﻿#pragma checksum "..\..\AddGuia.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "34C7E4543BA50612DAE992F5D4A888CBBCEDDD8875AD47D71C72F8EEA5B16DB9"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using Gestión_Rutas_Senderistas;
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


namespace Gestión_Rutas_Senderistas {
    
    
    /// <summary>
    /// AddGuia
    /// </summary>
    public partial class AddGuia : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 35 "..\..\AddGuia.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Nombretxt;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\AddGuia.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Apellidotxt;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\AddGuia.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Telefonotxt;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\AddGuia.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Emailtxt;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\AddGuia.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Idiomastxt;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\AddGuia.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Add;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\AddGuia.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Idiomastxt2;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\AddGuia.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Fotocombo;
        
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
            System.Uri resourceLocater = new System.Uri("/Gestión Rutas Senderistas;component/addguia.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddGuia.xaml"
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
            
            #line 9 "..\..\AddGuia.xaml"
            ((Gestión_Rutas_Senderistas.AddGuia)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Nombretxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.Apellidotxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.Telefonotxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.Emailtxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.Idiomastxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.Add = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\AddGuia.xaml"
            this.Add.Click += new System.Windows.RoutedEventHandler(this.Add_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Idiomastxt2 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.Fotocombo = ((System.Windows.Controls.ComboBox)(target));
            
            #line 43 "..\..\AddGuia.xaml"
            this.Fotocombo.Initialized += new System.EventHandler(this.Fotocombo_Initialized);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

