//------------------------------------------------------------------------------
// <copyright file="CopyObjectCommand1.cs" company="Alex Nelson">
//     Copyright (c) Company.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.ComponentModel.Design;
using System.Globalization;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;

namespace OtCE
{
    internal sealed class CopyObjectCommand
    {
        public const int CommandId = 0x0100;
        
        public static readonly Guid CommandSet = new Guid("1a4f2652-7aec-4422-8134-d18c00ed9192");
        
        private readonly Package package;
        private CopyObjectCommand(Package package)
        {
            if (package == null)
            {
                throw new ArgumentNullException("package");
            }

            this.package = package;

            OleMenuCommandService commandService = this.ServiceProvider.GetService(typeof(IMenuCommandService)) as OleMenuCommandService;
            if (commandService != null)
            {
                var menuCommandID = new CommandID(CommandSet, CommandId);
                var menuItem = new MenuCommand(this.CopyObject, menuCommandID);
                commandService.AddCommand(menuItem);
            }
        }
        public static CopyObjectCommand Instance
        {
            get;
            private set;
        }

        
        private IServiceProvider ServiceProvider
        {
            get
            {
                return this.package;
            }
        }
        
        public static void Initialize(Package package)
        {
            Instance = new CopyObjectCommand(package);
        }

        private void CopyObject(object sender, EventArgs e)
        {
            Process proc = new Process();
            proc.StartInfo.FileName = "notepad.exe";
            proc.Start();
        }
    }
}
