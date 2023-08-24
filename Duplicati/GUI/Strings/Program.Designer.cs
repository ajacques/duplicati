﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Duplicati.GUI.Strings {
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
    internal class Program {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Program() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Duplicati.GUI.Strings.Program", typeof(Program).Assembly);
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
        ///   Looks up a localized string similar to Another instance is running, and was notified.
        /// </summary>
        internal static string AnotherInstanceDetected {
            get {
                return ResourceManager.GetString("AnotherInstanceDetected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to create, open or upgrade the database.
        ///Error message: {0}.
        /// </summary>
        internal static string DatabaseOpenError {
            get {
                return ResourceManager.GetString("DatabaseOpenError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Forces the --run-backup command to perform a full backup.
        /// </summary>
        internal static string FullCommandDescription {
            get {
                return ResourceManager.GetString("FullCommandDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Displays this help.
        /// </summary>
        internal static string HelpCommandDescription {
            get {
                return ResourceManager.GetString("HelpCommandDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Supported commandline arguments:
        ///
        ///{0}.
        /// </summary>
        internal static string HelpDisplayDialog {
            get {
                return ResourceManager.GetString("HelpDisplayDialog", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to --{0}: {1}.
        /// </summary>
        internal static string HelpDisplayFormat {
            get {
                return ResourceManager.GetString("HelpDisplayFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to set the user interface language: {0}.
        /// </summary>
        internal static string LanguageSelectionError {
            get {
                return ResourceManager.GetString("LanguageSelectionError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Outputs log information to the file given.
        /// </summary>
        internal static string LogfileCommandDescription {
            get {
                return ResourceManager.GetString("LogfileCommandDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Determines the amount of information written in the log file.
        /// </summary>
        internal static string LoglevelCommandDescription {
            get {
                return ResourceManager.GetString("LoglevelCommandDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Pauses Duplicati, supply a time eg. 5m to limit pause to 5 minutes.
        /// </summary>
        internal static string PauseCommandDescription {
            get {
                return ResourceManager.GetString("PauseCommandDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Activates portable mode where the database is placed below the program executable.
        /// </summary>
        internal static string PortablemodeCommandDescription {
            get {
                return ResourceManager.GetString("PortablemodeCommandDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Resumes operation of Duplicati, if paused.
        /// </summary>
        internal static string ResumeCommandDescription {
            get {
                return ResourceManager.GetString("ResumeCommandDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Runs the backup with the name supplied. If no backup name is supplied, the available backups are displayed.
        /// </summary>
        internal static string RunbackupCommandDescription {
            get {
                return ResourceManager.GetString("RunbackupCommandDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Runs all backups in the group with the name supplied. If no group name is supplied, the available backups are displayed. If the group name is not found, an error message is displayed..
        /// </summary>
        internal static string RunbackupGroupCommandDescription {
            get {
                return ResourceManager.GetString("RunbackupGroupCommandDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A serious error occured in Duplicati: {0}.
        /// </summary>
        internal static string SeriousError {
            get {
                return ResourceManager.GetString("SeriousError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Displays the status window.
        /// </summary>
        internal static string ShowstausCommandDescription {
            get {
                return ResourceManager.GetString("ShowstausCommandDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Displays the wizard window.
        /// </summary>
        internal static string ShowwizardCommandDescription {
            get {
                return ResourceManager.GetString("ShowwizardCommandDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to start up, perhaps another process is already running?
        ///Error message: {0}.
        /// </summary>
        internal static string StartupFailure {
            get {
                return ResourceManager.GetString("StartupFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Runs Duplicati without showing the tray icon, closing the main window closes Duplicati.
        /// </summary>
        internal static string TraylessCommandDescription {
            get {
                return ResourceManager.GetString("TraylessCommandDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Disables database encryption.
        /// </summary>
        internal static string UnencrypteddatabaseCommandDescription {
            get {
                return ResourceManager.GetString("UnencrypteddatabaseCommandDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unsupported version of SQLite detected ({0}), must be {1} or higher.
        /// </summary>
        internal static string WrongSQLiteVersion {
            get {
                return ResourceManager.GetString("WrongSQLiteVersion", resourceCulture);
            }
        }
    }
}
