﻿#pragma checksum "..\..\..\..\PropertyGrid\Editors\FlatCollectionEditor.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "38A3EA51C1DA59D39E2131C12B75244365360660C8CB28916E02C7FFB1C83ACC"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using ICSharpCode.WpfDesign.Designer.OutlineView;
using ICSharpCode.WpfDesign.Designer.PropertyGrid;
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


namespace ICSharpCode.WpfDesign.Designer.PropertyGrid.Editors {
    
    
    /// <summary>
    /// FlatCollectionEditor
    /// </summary>
    public partial class FlatCollectionEditor : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\..\PropertyGrid\Editors\FlatCollectionEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ListBox;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\PropertyGrid\Editors\FlatCollectionEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddItem;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\PropertyGrid\Editors\FlatCollectionEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RemoveItem;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\..\PropertyGrid\Editors\FlatCollectionEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MoveUpItem;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\..\PropertyGrid\Editors\FlatCollectionEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MoveDownItem;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\..\PropertyGrid\Editors\FlatCollectionEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ICSharpCode.WpfDesign.Designer.PropertyGrid.PropertyGridView PropertyGridView;
        
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
            System.Uri resourceLocater = new System.Uri("/ShaderPan2;component/propertygrid/editors/flatcollectioneditor.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\PropertyGrid\Editors\FlatCollectionEditor.xaml"
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
            this.ListBox = ((System.Windows.Controls.ListBox)(target));
            
            #line 25 "..\..\..\..\PropertyGrid\Editors\FlatCollectionEditor.xaml"
            this.ListBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ListBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.AddItem = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\..\PropertyGrid\Editors\FlatCollectionEditor.xaml"
            this.AddItem.Click += new System.Windows.RoutedEventHandler(this.OnAddItemClicked);
            
            #line default
            #line hidden
            return;
            case 3:
            this.RemoveItem = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\..\..\PropertyGrid\Editors\FlatCollectionEditor.xaml"
            this.RemoveItem.Click += new System.Windows.RoutedEventHandler(this.OnRemoveItemClicked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.MoveUpItem = ((System.Windows.Controls.Button)(target));
            
            #line 56 "..\..\..\..\PropertyGrid\Editors\FlatCollectionEditor.xaml"
            this.MoveUpItem.Click += new System.Windows.RoutedEventHandler(this.OnMoveItemUpClicked);
            
            #line default
            #line hidden
            return;
            case 5:
            this.MoveDownItem = ((System.Windows.Controls.Button)(target));
            
            #line 66 "..\..\..\..\PropertyGrid\Editors\FlatCollectionEditor.xaml"
            this.MoveDownItem.Click += new System.Windows.RoutedEventHandler(this.OnMoveItemDownClicked);
            
            #line default
            #line hidden
            return;
            case 6:
            this.PropertyGridView = ((ICSharpCode.WpfDesign.Designer.PropertyGrid.PropertyGridView)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

