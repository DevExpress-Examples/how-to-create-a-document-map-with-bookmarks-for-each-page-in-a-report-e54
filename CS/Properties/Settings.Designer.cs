﻿// Developer Express Code Central Example:
// How to create a Document Map with bookmarks for each page in a report
// 
// The following example demonstrates how to create a Document Map with bookmarks
// (http://www.devexpress.com/Help/Content.aspx?help=XtraReports&document=CustomDocument2603.htm)
// for each page in a report.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E54

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace docBookmarks.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\"C:\\Program Files\\Developer Express " +
            ".NET v8.1\\Demos\\Data\\nwind.mdb\"")]
        public string nwindConnectionString {
            get {
                return ((string)(this["nwindConnectionString"]));
            }
        }
    }
}
