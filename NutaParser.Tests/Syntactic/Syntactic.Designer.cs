﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.237
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NutaParser.Tests.Syntactic {
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
    internal class Syntactic {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Syntactic() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("NutaParser.Tests.Syntactic.Syntactic", typeof(Syntactic).Assembly);
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
        
        /// <summary>
        ///   Looks up a localized string similar to from c in customers select c.Name.
        /// </summary>
        internal static string QueryExpression1 {
            get {
                return ResourceManager.GetString("QueryExpression1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to from c in customers orderby c.LastName, c.FirstName select c.Name.
        /// </summary>
        internal static string QueryExpression10 {
            get {
                return ResourceManager.GetString("QueryExpression10", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to from c in customers orderby c.LastName descending, c.FirstName ascending select c.Name.
        /// </summary>
        internal static string QueryExpression11 {
            get {
                return ResourceManager.GetString("QueryExpression11", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to from c in customers orderby c.LastName descending, c.FirstName ascending orderby c.Address select c.Name.
        /// </summary>
        internal static string QueryExpression12 {
            get {
                return ResourceManager.GetString("QueryExpression12", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to from c in customers select c.Name.
        /// </summary>
        internal static string QueryExpression13 {
            get {
                return ResourceManager.GetString("QueryExpression13", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to from c in customers group c by c.Country.
        /// </summary>
        internal static string QueryExpression14 {
            get {
                return ResourceManager.GetString("QueryExpression14", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to from c in customers group c by c.Country into g select g.Key.
        /// </summary>
        internal static string QueryExpression15 {
            get {
                return ResourceManager.GetString("QueryExpression15", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to from itm in new int[] { 1, 2, 3, 4, 5 } let i = itm == 1 ? 1 : 0 select i.
        /// </summary>
        internal static string QueryExpression16 {
            get {
                return ResourceManager.GetString("QueryExpression16", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to from b in new int[] { 1, 2, 3, 4, 5 } where true &amp;&amp; (b.Equals) select b.
        /// </summary>
        internal static string QueryExpression17 {
            get {
                return ResourceManager.GetString("QueryExpression17", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to from b in new int[] { 1, 2, 3, 4, 5 } where true || (b.Equals) select b.
        /// </summary>
        internal static string QueryExpression18 {
            get {
                return ResourceManager.GetString("QueryExpression18", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to from b in new int[] { 1, 2, 3, 4, 5 } where true != (b.Equals) select b.
        /// </summary>
        internal static string QueryExpression19 {
            get {
                return ResourceManager.GetString("QueryExpression19", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to from int[] c in customers select c.Count.
        /// </summary>
        internal static string QueryExpression2 {
            get {
                return ResourceManager.GetString("QueryExpression2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to from int[] c in customers from d in deltas select c.Count + d.
        /// </summary>
        internal static string QueryExpression3 {
            get {
                return ResourceManager.GetString("QueryExpression3", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to from c in customers let address = c.Address let area = c.PhoneNumber.AreaCode select address + area.
        /// </summary>
        internal static string QueryExpression4 {
            get {
                return ResourceManager.GetString("QueryExpression4", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to from c in customers join a in address on c.ZipCode equals a.ZipCode select c.Name.
        /// </summary>
        internal static string QueryExpression5 {
            get {
                return ResourceManager.GetString("QueryExpression5", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to from c in customers join a in address on c.ZipCode equals a.ZipCode into g select c.Name.
        /// </summary>
        internal static string QueryExpression6 {
            get {
                return ResourceManager.GetString("QueryExpression6", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to from c in customers join a in address on c.ZipCode equals a.ZipCode join n in phonenumber on c.AreaCode equals n.AreaCode into x select c.Name.
        /// </summary>
        internal static string QueryExpression7 {
            get {
                return ResourceManager.GetString("QueryExpression7", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to from c in customers orderby c.LastName select c.Name.
        /// </summary>
        internal static string QueryExpression8 {
            get {
                return ResourceManager.GetString("QueryExpression8", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to from c in customers orderby c.LastName ascending select c.Name.
        /// </summary>
        internal static string QueryExpression9 {
            get {
                return ResourceManager.GetString("QueryExpression9", resourceCulture);
            }
        }
    }
}
