﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MediaToolkit.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MediaToolkit.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Input file not found.
        /// </summary>
        internal static string Exception_Media_Input_File_Not_Found {
            get {
                return ResourceManager.GetString("Exception_Media_Input_File_Not_Found", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to FFmpeg process is not running..
        /// </summary>
        internal static string Exceptions_FFmpeg_Process_Not_Running {
            get {
                return ResourceManager.GetString("Exceptions_FFmpeg_Process_Not_Running", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to FFMpeg GZip stream is null.
        /// </summary>
        internal static string Exceptions_Null_FFmpeg_Gzip_Stream {
            get {
                return ResourceManager.GetString("Exceptions_Null_FFmpeg_Gzip_Stream", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to MediaToolkit.Resources.FFmpeg.exe.gz.
        /// </summary>
        internal static string FFmpegManifestResourceName {
            get {
                return ResourceManager.GetString("FFmpegManifestResourceName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ffmpeg.
        /// </summary>
        internal static string FFmpegProcessName {
            get {
                return ResourceManager.GetString("FFmpegProcessName", resourceCulture);
            }
        }
    }
}
