﻿#pragma checksum "..\..\..\..\..\Views\Pages\ImageHistoryShow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4560414281022DCB136071DE86E89FCF5FE567A54B32FB5D232C36B7E5279CA3"
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
using Vision_NBB.Views.Pages;


namespace Vision_NBB.Views.Pages {
    
    
    /// <summary>
    /// ImageHistoryShow
    /// </summary>
    public partial class ImageHistoryShow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\..\..\Views\Pages\ImageHistoryShow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContentControl Part_ImageContainer;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\..\Views\Pages\ImageHistoryShow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image image;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\..\Views\Pages\ImageHistoryShow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.TransformGroup group;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\..\Views\Pages\ImageHistoryShow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.ScaleTransform scaler;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\..\Views\Pages\ImageHistoryShow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.TranslateTransform transer;
        
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
            System.Uri resourceLocater = new System.Uri("/Vision_NBB;component/views/pages/imagehistoryshow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Views\Pages\ImageHistoryShow.xaml"
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
            this.Part_ImageContainer = ((System.Windows.Controls.ContentControl)(target));
            
            #line 20 "..\..\..\..\..\Views\Pages\ImageHistoryShow.xaml"
            this.Part_ImageContainer.MouseWheel += new System.Windows.Input.MouseWheelEventHandler(this.ImgMouseWheel);
            
            #line default
            #line hidden
            return;
            case 2:
            this.image = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.group = ((System.Windows.Media.TransformGroup)(target));
            return;
            case 4:
            this.scaler = ((System.Windows.Media.ScaleTransform)(target));
            return;
            case 5:
            this.transer = ((System.Windows.Media.TranslateTransform)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

