﻿#pragma checksum "..\..\..\Silnik.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2A82AF6546B12111988FBCD5F1BF94637BB58D11"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

using Samochody;
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


namespace Samochody {
    
    
    /// <summary>
    /// Silnik
    /// </summary>
    public partial class Silnik : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\Silnik.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbutton_benzyna;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\Silnik.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbutton_diesel;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\Silnik.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbutton_gaz;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\Silnik.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbutton_hybryda;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\Silnik.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox moc;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Silnik.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_powrót;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Silnik.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label cena_silnik;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.10.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Samochody;component/silnik.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Silnik.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.10.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.rbutton_benzyna = ((System.Windows.Controls.RadioButton)(target));
            
            #line 10 "..\..\..\Silnik.xaml"
            this.rbutton_benzyna.Checked += new System.Windows.RoutedEventHandler(this.rbutton_benzyna_Checked);
            
            #line default
            #line hidden
            
            #line 10 "..\..\..\Silnik.xaml"
            this.rbutton_benzyna.Unchecked += new System.Windows.RoutedEventHandler(this.rbutton_benzyna_Checked);
            
            #line default
            #line hidden
            return;
            case 2:
            this.rbutton_diesel = ((System.Windows.Controls.RadioButton)(target));
            
            #line 11 "..\..\..\Silnik.xaml"
            this.rbutton_diesel.Checked += new System.Windows.RoutedEventHandler(this.rbutton_diesel_Checked);
            
            #line default
            #line hidden
            
            #line 11 "..\..\..\Silnik.xaml"
            this.rbutton_diesel.Unchecked += new System.Windows.RoutedEventHandler(this.rbutton_diesel_Checked);
            
            #line default
            #line hidden
            return;
            case 3:
            this.rbutton_gaz = ((System.Windows.Controls.RadioButton)(target));
            
            #line 12 "..\..\..\Silnik.xaml"
            this.rbutton_gaz.Checked += new System.Windows.RoutedEventHandler(this.rbutton_gaz_Checked);
            
            #line default
            #line hidden
            
            #line 12 "..\..\..\Silnik.xaml"
            this.rbutton_gaz.Unchecked += new System.Windows.RoutedEventHandler(this.rbutton_gaz_Checked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.rbutton_hybryda = ((System.Windows.Controls.RadioButton)(target));
            
            #line 13 "..\..\..\Silnik.xaml"
            this.rbutton_hybryda.Checked += new System.Windows.RoutedEventHandler(this.rbutton_hybryda_Checked);
            
            #line default
            #line hidden
            
            #line 13 "..\..\..\Silnik.xaml"
            this.rbutton_hybryda.Unchecked += new System.Windows.RoutedEventHandler(this.rbutton_hybryda_Checked);
            
            #line default
            #line hidden
            return;
            case 5:
            this.moc = ((System.Windows.Controls.ComboBox)(target));
            
            #line 15 "..\..\..\Silnik.xaml"
            this.moc.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.moc_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.button_powrót = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\Silnik.xaml"
            this.button_powrót.Click += new System.Windows.RoutedEventHandler(this.button_powrót_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.cena_silnik = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

