//css_dir ..\..\;
//css_ref Wix_bin\SDK\Microsoft.Deployment.WindowsInstaller.dll;
//css_ref System.Core.dll;
using System;
using WixSharp;

class Script
{
    static public void Main(string[] args)
    {
        var binaries = new Feature("MyApp Binaries");
        var docs = new Feature("MyApp Documentation");
        binaries.Children.Add(docs);

        var project =
            new Project("MyProduct",
                new Dir(@"%ProgramFiles%\My Company\My Product",
                    new File(binaries, @"Files\Bin\MyApp.exe"),
                    new Dir(@"Docs\Manual",
                        new File(docs, @"Files\Docs\Manual.txt"))));

        project.GUID = new Guid("6f330b47-2577-43ad-9095-1861ba25889b");
        project.UI = WUI.WixUI_FeatureTree;

        project.BuildMsi();
    }
}



