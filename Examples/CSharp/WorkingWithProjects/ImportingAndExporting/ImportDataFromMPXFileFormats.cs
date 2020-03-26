/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.ImportingAndExporting
{
    using System;

    internal class ImportDataFromMPXFileFormats
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());

            //ExStart:ImportDataFromMPXFileFormats
            //ExFor: Project.Save(String,SaveFileFormat)
            //ExFor: Project.GetProjectFileInfo(String)
            //ExFor: ProjectFileInfo.ProjectFileFormat
            //ExSummary: Shows how to import a project from MPX format.
            var info = Project.GetProjectFileInfo(dataDir + "EUC-KR-encoding.mpx");
            Console.WriteLine(info.ProjectFileFormat);
            //ExEnd:ImportDataFromMPXFileFormats
        }
    }
}