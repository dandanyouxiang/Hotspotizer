﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApplication.Properties {
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
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("WpfApplication.Properties.Resources", typeof(Resources).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Create New Gesture Collection.
        /// </summary>
        public static string CreateNewGestureCollection {
            get {
                return ResourceManager.GetString("CreateNewGestureCollection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Delete Gesture from Collection.
        /// </summary>
        public static string DeleteGesture {
            get {
                return ResourceManager.GetString("DeleteGesture", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Do you really want to delete the gesture &quot;%s&quot; from the collection?.
        /// </summary>
        public static string DeleteGestureConfirmation {
            get {
                return ResourceManager.GetString("DeleteGestureConfirmation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Do you really want to discard the current gesture collection and create a new one?.
        /// </summary>
        public static string DiscardGestureCollectionConfirmation {
            get {
                return ResourceManager.GetString("DiscardGestureCollectionConfirmation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Hotspotizer Gesture files (*.hsjson)|*.hsjson.
        /// </summary>
        public static string HotspotizerFileFilter {
            get {
                return ResourceManager.GetString("HotspotizerFileFilter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        /// </summary>
        public static System.Drawing.Icon Logo {
            get {
                object obj = ResourceManager.GetObject("Logo", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to New Gesture.
        /// </summary>
        public static string NewGesture {
            get {
                return ResourceManager.GetString("NewGesture", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to http://www.microsoft.com/en-us/download/details.aspx?id=40278.
        /// </summary>
        public static string URL_DownloadKinectSDK {
            get {
                return ResourceManager.GetString("URL_DownloadKinectSDK", resourceCulture);
            }
        }
    }
}
