//css_dir ..\..\..\;
//css_ref Wix_bin\SDK\Microsoft.Deployment.WindowsInstaller.dll;
//css_ref System.Core.dll;

using System;
using System.Windows.Forms;
using WixSharp;

class Script
{
    static public void Main(string[] args)
    {
        Project project =
               new Project("MyMergeModule",
                   new Dir(@"%ProgramFiles%\My Company",
                       new File(@"File1.txt"),
                       new File(@"File2.txt")));

        //project.GUID = new Guid("6f330b47-2577-43ad-9095-1861ba258895");
        project.UI = WUI.WixUI_ProgressOnly;

        var msm = Compiler.BuildMsm(project);
    }
}
