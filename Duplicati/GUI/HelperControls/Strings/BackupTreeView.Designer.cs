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
    internal class BackupTreeView {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal BackupTreeView() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Duplicati.GUI.HelperControls.Strings.BackupTreeView", typeof(BackupTreeView).Assembly);
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
        ///   Looks up a localized string similar to Do you want to delete the folder {0} and all the backups contained in it?.
        /// </summary>
        internal static string ConfirmDeleteFolder {
            get {
                return ResourceManager.GetString("ConfirmDeleteFolder", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove the backup &apos;{0}&apos; ?.
        /// </summary>
        internal static string ConfirmRemoveBackup {
            get {
                return ResourceManager.GetString("ConfirmRemoveBackup", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to New Backup.
        /// </summary>
        internal static string NewBackup {
            get {
                return ResourceManager.GetString("NewBackup", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to New Folder.
        /// </summary>
        internal static string NewFolder {
            get {
                return ResourceManager.GetString("NewFolder", resourceCulture);
            }
        }
    }
}
