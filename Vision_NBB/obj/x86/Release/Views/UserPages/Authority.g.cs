﻿#pragma checksum "..\..\..\..\..\Views\UserPages\Authority.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6291A941C17DA96FE9DFE4A94860F5D19C1F2B165E83AF8307F2AA32072BA199"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
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
using Vision_NBB.Views.UserPages;


namespace Vision_NBB.Views.UserPages {
    
    
    /// <summary>
    /// Authority
    /// </summary>
    public partial class Authority : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 37 "..\..\..\..\..\Views\UserPages\Authority.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmb;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\..\Views\UserPages\Authority.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lst;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\..\..\Views\UserPages\Authority.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox groupsettings;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\..\Views\UserPages\Authority.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox authority;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\..\..\Views\UserPages\Authority.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox soluctionSet;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\..\..\Views\UserPages\Authority.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox userSet;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\..\..\Views\UserPages\Authority.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox openVM;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\..\..\Views\UserPages\Authority.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox plcSet;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\..\..\Views\UserPages\Authority.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button save;
        
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
            System.Uri resourceLocater = new System.Uri("/Vision_NBB;component/views/userpages/authority.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Views\UserPages\Authority.xaml"
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
            
            #line 10 "..\..\..\..\..\Views\UserPages\Authority.xaml"
            ((Vision_NBB.Views.UserPages.Authority)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 28 "..\..\..\..\..\Views\UserPages\Authority.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Btn_close_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.cmb = ((System.Windows.Controls.ComboBox)(target));
            
            #line 38 "..\..\..\..\..\Views\UserPages\Authority.xaml"
            this.cmb.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmb_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.lst = ((System.Windows.Controls.ListBox)(target));
            
            #line 42 "..\..\..\..\..\Views\UserPages\Authority.xaml"
            this.lst.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.lst_SelectionChanged);
            
            #line default
            #line hidden
            
            #line 42 "..\..\..\..\..\Views\UserPages\Authority.xaml"
            this.lst.AddHandler(System.Windows.Controls.Primitives.ButtonBase.ClickEvent, new System.Windows.RoutedEventHandler(this.lst_SelectionChanged));
            
            #line default
            #line hidden
            return;
            case 5:
            this.groupsettings = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 6:
            this.authority = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 7:
            this.soluctionSet = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 8:
            this.userSet = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 9:
            this.openVM = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 10:
            this.plcSet = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 11:
            this.save = ((System.Windows.Controls.Button)(target));
            
            #line 60 "..\..\..\..\..\Views\UserPages\Authority.xaml"
            this.save.Click += new System.Windows.RoutedEventHandler(this.Save_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
