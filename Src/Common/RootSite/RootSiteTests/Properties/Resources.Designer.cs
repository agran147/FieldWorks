﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SIL.FieldWorks.Common.RootSites.Properties {
	using System;


	/// <summary>
	///   A strongly-typed resource class, for looking up localized strings, etc.
	/// </summary>
	// This class was auto-generated by the StronglyTypedResourceBuilder
	// class via a tool like ResGen or Visual Studio.
	// To add or remove a member, edit your .ResX file then rerun ResGen
	// with the /str option, or rebuild your VS project.
	[global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
	[global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
	internal class Resources {

		private static global::System.Resources.ResourceManager resourceMan;

		private static global::System.Globalization.CultureInfo resourceCulture;

		[global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
		internal Resources() {
		}

		/// <summary>
		///   Returns the cached ResourceManager instance used by this class.
		/// </summary>
		[global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		internal static global::System.Resources.ResourceManager ResourceManager {
			get {
				if (object.ReferenceEquals(resourceMan, null)) {
					global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SIL.FieldWorks.Common.RootSites.Properties.Resources", typeof(Resources).Assembly);
					resourceMan = temp;
				}
				return resourceMan;
			}
		}

		/// <summary>
		///   Overrides the current thread's CurrentUICulture property for all
		///   resource lookups using this strongly typed resource class.
		/// </summary>
		[global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		internal static global::System.Globalization.CultureInfo Culture {
			get {
				return resourceCulture;
			}
			set {
				resourceCulture = value;
			}
		}

		internal static System.Drawing.Bitmap InterlinPopupArrow {
			get {
				object obj = ResourceManager.GetObject("InterlinPopupArrow", resourceCulture);
				return ((System.Drawing.Bitmap)(obj));
			}
		}

		/// <summary>
		///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
		///&lt;EntireModel xmlns:xsi=&quot;http://www.w3.org/2001/XMLSchema-instance&quot; version=&quot;7000010&quot; xsi:noNamespaceSchemaLocation=&quot;TestModel.xsd&quot;&gt;
		///    &lt;class num=&quot;0&quot; id=&quot;CmObject&quot; abstract=&quot;true&quot; abbr=&quot;obj&quot;&gt;
		///      &lt;props/&gt;
		///    &lt;/class&gt;
		///	&lt;class num=&quot;1&quot; id=&quot;Document&quot; abstract=&quot;false&quot; abbr=&quot;proj&quot; base=&quot;CmObject&quot; depth=&quot;0&quot;&gt;
		///		&lt;props&gt;
		///			&lt;owning num=&quot;1&quot; id=&quot;Title&quot; card=&quot;atomic&quot; sig=&quot;StText&quot;/&gt;
		///			&lt;owning num=&quot;2&quot; id=&quot;Divisions&quot; card=&quot;seq&quot; sig=&quot;Section&quot;/&gt;
		///			&lt;owning num=&quot;3&quot; id=&quot;Foot [rest of string was truncated]&quot;;.
		/// </summary>
		internal static string RootSiteDataProviderCacheModel_xml {
			get {
				return ResourceManager.GetString("RootSiteDataProviderCacheModel_xml", resourceCulture);
			}
		}
	}
}
