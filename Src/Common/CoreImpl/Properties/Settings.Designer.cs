﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.296
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#pragma warning disable 1591 // Hand-added to satisfy compiler. Redo when regenerated. Yuck.
namespace SIL.CoreImpl.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    public sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool UpdateGlobalWSStore {
            get {
                return ((bool)(this["UpdateGlobalWSStore"]));
            }
            set {
                this["UpdateGlobalWSStore"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Palaso.Reporting.ReportingSettings Reporting {
            get {
                return ((global::Palaso.Reporting.ReportingSettings)(this["Reporting"]));
            }
            set {
                this["Reporting"] = value;
            }
        }

		[global::System.Configuration.UserScopedSettingAttribute()]
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.Configuration.DefaultSettingValueAttribute("True")]
	    public bool CallUpgrade
		{
			get
			{
				return ((bool)(this["CallUpgrade"]));
			}
			set
			{
				this["CallUpgrade"] = value;
			}
	    }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool AutoCheckForUpdates {
            get {
                return ((bool)(this["AutoCheckForUpdates"]));
            }
            set {
                this["AutoCheckForUpdates"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool CheckForBetaUpdates {
            get {
                return ((bool)(this["CheckForBetaUpdates"]));
            }
            set {
                this["CheckForBetaUpdates"] = value;
            }
        }
    }
}
