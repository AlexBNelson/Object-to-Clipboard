//------------------------------------------------------------------------------
// <copyright file="CopyObjectCommand1Package.cs" company="Company">
//     Copyright (c) Company.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio;
using Microsoft.VisualStudio.OLE.Interop;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;
using Microsoft.Win32;

namespace OtCE
{
   
    [PackageRegistration(UseManagedResourcesOnly = true)]
    [InstalledProductRegistration("#110", "#112", "1.0", IconResourceID = 400)] // Info on this package for Help/About
    [ProvideMenuResource("Menus.ctmenu", 1)]
    [Guid(CopyObjectCommandPackage.PackageGuidString)]
    [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly", Justification = "pkgdef, VS and vsixmanifest are valid VS terms")]
    public sealed class CopyObjectCommandPackage : Package
    {
        public const string PackageGuidString = "77409125-59cf-4746-8e6e-9986bb6cf4e7";

        
        public CopyObjectCommandPackage()
        {
            
        }

        #region Package Members

        
        protected override void Initialize()
        {
            CopyObjectCommand.Initialize(this);
            base.Initialize();
        }

        #endregion
    }
}
