﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Duplicati.GUI.Wizard_pages.Add_backup.Strings {
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
    internal class SelectFiles {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SelectFiles() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Duplicati.GUI.Wizard_pages.Add_backup.Strings.SelectFiles", typeof(SelectFiles).Assembly);
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
        ///   Looks up a localized string similar to Calculating size ....
        /// </summary>
        internal static string CalculatingSize {
            get {
                return ResourceManager.GetString("CalculatingSize", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (...).
        /// </summary>
        internal static string CalculatingSizeMarker {
            get {
                return ResourceManager.GetString("CalculatingSizeMarker", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The folder &quot;{0}&quot; is included twice.
        /// </summary>
        internal static string DuplicateFolderError {
            get {
                return ResourceManager.GetString("DuplicateFolderError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The selected items take up {0} of space.
        /// </summary>
        internal static string FinalSizeCalculated {
            get {
                return ResourceManager.GetString("FinalSizeCalculated", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The folder &quot;{0}&quot; does not exist.
        ///How do you want to proceed?.
        /// </summary>
        internal static string FolderDoesNotExistWarning {
            get {
                return ResourceManager.GetString("FolderDoesNotExistWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You have not included any files..
        /// </summary>
        internal static string NoFilesSelectedError {
            get {
                return ResourceManager.GetString("NoFilesSelectedError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to On this page you must select the folder and files you wish to backup.
        /// </summary>
        internal static string PageDescription {
            get {
                return ResourceManager.GetString("PageDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Select files to backup.
        /// </summary>
        internal static string PageTitle {
            get {
                return ResourceManager.GetString("PageTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Calculating ... (using more than {0} of space).
        /// </summary>
        internal static string PartialSizeCalculated {
            get {
                return ResourceManager.GetString("PartialSizeCalculated", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The folder &quot;{0}&quot; is a subfolder of &quot;{1}&quot;, which is not allowed.
        /// </summary>
        internal static string RelatedFoldersError {
            get {
                return ResourceManager.GetString("RelatedFoldersError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The setup is loaded from an older version of Duplicati. 
        ///If you save the backup settings, the internal storage will be change to the new version.
        ///Please verify the content of the backup after the next run to ensure
        ///that it contains the files and folders that you expect..
        /// </summary>
        internal static string UpgradeWarning {
            get {
                return ResourceManager.GetString("UpgradeWarning", resourceCulture);
            }
        }
    }
}
