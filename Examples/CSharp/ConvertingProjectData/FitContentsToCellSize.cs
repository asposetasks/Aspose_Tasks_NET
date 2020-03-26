/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.ConvertingProjectData
{
    using Aspose.Tasks.Saving;
    using Aspose.Tasks.Visualization;

    internal class FitContentsToCellSize
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());

            //ExStart:FitContentsToCellSize
            //ExFor: SaveOptions.FitContent
            //ExSummary: Shows how to set the option whether row height should be increased to fit its content.
            var project = new Project(dataDir + "CreateProject2.mpp");
            SaveOptions saveOptions = new PdfSaveOptions();

            // Set option fit content to true
            saveOptions.FitContent = true;
            saveOptions.Timescale = Timescale.Months;
            saveOptions.PresentationFormat = PresentationFormat.TaskUsage;
            project.Save(dataDir + "FitContentsToCellSize_out.pdf", saveOptions);
            //ExEnd:FitContentsToCellSize
        }
    }
}