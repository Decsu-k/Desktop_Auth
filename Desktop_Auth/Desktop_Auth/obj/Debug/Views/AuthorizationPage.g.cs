﻿#pragma checksum "..\..\..\Views\AuthorizationPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "86F8A9AC1152ED8F387793595069C9B5F77348AF1918F305426C1A580332DEBE"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Desktop_Auth.Views;
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


namespace Desktop_Auth.Views {
    
    
    /// <summary>
    /// AuthorizationPage
    /// </summary>
    public partial class AuthorizationPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 72 "..\..\..\Views\AuthorizationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxbNumber;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\Views\AuthorizationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxbPassword;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\..\Views\AuthorizationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxbCode;
        
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
            System.Uri resourceLocater = new System.Uri("/Desktop_Auth;component/views/authorizationpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\AuthorizationPage.xaml"
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
            this.TxbNumber = ((System.Windows.Controls.TextBox)(target));
            
            #line 74 "..\..\..\Views\AuthorizationPage.xaml"
            this.TxbNumber.KeyDown += new System.Windows.Input.KeyEventHandler(this.EmployeeNumberTextBox_KeyDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TxbPassword = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.TxbCode = ((System.Windows.Controls.TextBox)(target));
            
            #line 95 "..\..\..\Views\AuthorizationPage.xaml"
            this.TxbCode.KeyDown += new System.Windows.Input.KeyEventHandler(this.TxbCode_KeyDown);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 105 "..\..\..\Views\AuthorizationPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_ReloadClick);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 121 "..\..\..\Views\AuthorizationPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_InputClick);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 132 "..\..\..\Views\AuthorizationPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_CancelClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

