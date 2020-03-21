/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.WorkingWithProjectProperties
{
    using System;

    using Aspose.Tasks.Saving;

    internal class WriteMPPProjectSummary
    {
        public static void Run()
        {
            try
            {
                // The path to the documents directory.
                var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);
                
                //ExStart:WriteMPPProjectSummary
                //ExFor: Prj.Author
                //ExFor: Prj.LastAuthor
                //ExFor: Prj.Revision
                //ExFor: Prj.Keywords
                //ExFor: Prj.Comments
                //ExSummary: Shows how to write project's summary properties.
                // Instantiate Project class
                var project = new Project(dataDir + "WriteMPPProjectSummary.mpp");

                // Set project summary
                project.Set(Prj.Author, "Author");
                project.Set(Prj.LastAuthor, "Last Author");
                project.Set(Prj.Revision, 15);
                project.Set(Prj.Keywords, "MSP Aspose");
                project.Set(Prj.Comments, "Comments");
                project.Save(dataDir + "WriteMPPProjectSummary_out.mpp", SaveFileFormat.MPP);
                //ExEnd:WriteMPPProjectSummary
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }          
        }
    }
}