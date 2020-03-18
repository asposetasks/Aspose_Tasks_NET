namespace Aspose.Tasks.Examples.CSharp.ConvertingProjectData
{
    using Aspose.Tasks.Saving;

    public class SaveProjectAsPDF
    {
        public static void Run()
        {
            // The path to the documents directory.
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            //ExStart:SaveProjectAsPDF
            //ExFor: SaveFileFormat.PDF
            //ExSummary: Shows how to save a project in PDF format.
            var project = new Project(dataDir + "CreateProject2.mpp");

            // Save the Project as PDF
            project.Save(dataDir + "SaveProjectAsPDF_out.pdf", SaveFileFormat.PDF);
            //ExEnd:SaveProjectAsPDF
        }
    }
}