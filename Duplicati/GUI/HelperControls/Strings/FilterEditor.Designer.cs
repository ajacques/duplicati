﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Duplicati.GUI.HelperControls.Strings {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class FilterEditor {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal FilterEditor() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Duplicati.GUI.HelperControls.Strings.FilterEditor", typeof(FilterEditor).Assembly);
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
        ///   Looks up a localized string similar to Choose the folder to add for exclusion.
        /// </summary>
        internal static string ExcludeFolderBrowseTitle {
            get {
                return ResourceManager.GetString("ExcludeFolderBrowseTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The file {0} is excluded due to rule {1}.
        /// </summary>
        internal static string FileIsExcluded {
            get {
                return ResourceManager.GetString("FileIsExcluded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The file {0} is included due to rule {1}.
        /// </summary>
        internal static string FileIsIncluded {
            get {
                return ResourceManager.GetString("FileIsIncluded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The file {0} is included because no rule matched.
        /// </summary>
        internal static string FileIsIncludedDefault {
            get {
                return ResourceManager.GetString("FileIsIncludedDefault", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The filename {0} is not located in any of the source folders.
        /// </summary>
        internal static string FilenameIsNotInAnyRootFolder {
            get {
                return ResourceManager.GetString("FilenameIsNotInAnyRootFolder", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The filename {0} is not an absolute path.
        /// </summary>
        internal static string FilepathIsNotAbsoluteError {
            get {
                return ResourceManager.GetString("FilepathIsNotAbsoluteError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The folder {0} is excluded due to rule {1}.
        /// </summary>
        internal static string FolderIsExcluded {
            get {
                return ResourceManager.GetString("FolderIsExcluded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The folder {0} is included because it is a source folder.
        /// </summary>
        internal static string FolderIsRootFolder {
            get {
                return ResourceManager.GetString("FolderIsRootFolder", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Choose the folder to add for inclusion.
        /// </summary>
        internal static string IncludeFolderBrowseTitle {
            get {
                return ResourceManager.GetString("IncludeFolderBrowseTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The filename {0} has invalid characters.
        /// </summary>
        internal static string InvalidCharsInFilenameError {
            get {
                return ResourceManager.GetString("InvalidCharsInFilenameError", resourceCulture);
            }
        }
    }
}
