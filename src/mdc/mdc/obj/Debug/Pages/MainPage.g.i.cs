﻿

#pragma checksum "C:\Data\hack\Missiondump_Client\src\mdc\mdc\Pages\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "5236EF0FE2CDD94BFCDAA4896F639EE8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace mdc.Pages
{
    partial class MainPage : global::Windows.UI.Xaml.Controls.Page
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Media.Animation.Storyboard FadeResultsIn; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Media.Animation.Storyboard FadeResultsOut; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.StackPanel QueryPanel; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.ListView ResultItemsControl; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.TextBox CompanyFor; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.StackPanel RightPanel; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private bool _contentLoaded;

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent()
        {
            if (_contentLoaded)
                return;

            _contentLoaded = true;
            global::Windows.UI.Xaml.Application.LoadComponent(this, new global::System.Uri("ms-appx:///Pages/MainPage.xaml"), global::Windows.UI.Xaml.Controls.Primitives.ComponentResourceLocation.Application);
 
            FadeResultsIn = (global::Windows.UI.Xaml.Media.Animation.Storyboard)this.FindName("FadeResultsIn");
            FadeResultsOut = (global::Windows.UI.Xaml.Media.Animation.Storyboard)this.FindName("FadeResultsOut");
            QueryPanel = (global::Windows.UI.Xaml.Controls.StackPanel)this.FindName("QueryPanel");
            ResultItemsControl = (global::Windows.UI.Xaml.Controls.ListView)this.FindName("ResultItemsControl");
            CompanyFor = (global::Windows.UI.Xaml.Controls.TextBox)this.FindName("CompanyFor");
            RightPanel = (global::Windows.UI.Xaml.Controls.StackPanel)this.FindName("RightPanel");
        }
    }
}



