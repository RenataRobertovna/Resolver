﻿#pragma checksum "..\..\..\Bookmarks.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56C2CBC8A28142607CE5157FDABB2B828AED587D"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Resolver;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace Resolver {
    
    
    /// <summary>
    /// Bookmarks
    /// </summary>
    public partial class Bookmarks : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\Bookmarks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Home_Page;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Bookmarks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Vip_Page;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\Bookmarks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Bookmarks_Page;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\Bookmarks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Questions_Page;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Resolver;component/bookmarks.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Bookmarks.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Home_Page = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\Bookmarks.xaml"
            this.Home_Page.Click += new System.Windows.RoutedEventHandler(this.Home_Page_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Vip_Page = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\..\Bookmarks.xaml"
            this.Vip_Page.Click += new System.Windows.RoutedEventHandler(this.Vip_Page_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Bookmarks_Page = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\..\Bookmarks.xaml"
            this.Bookmarks_Page.Click += new System.Windows.RoutedEventHandler(this.Bookmarks_Page_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Questions_Page = ((System.Windows.Controls.Button)(target));
            
            #line 65 "..\..\..\Bookmarks.xaml"
            this.Questions_Page.Click += new System.Windows.RoutedEventHandler(this.Questions_Page_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

