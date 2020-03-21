namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.Miscellaneous
{
    using System.IO;

    internal class ExtractEmbeddedObjects
    {
        public static void Run()
        {
            // The path to the documents directory.
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            //ExStart:ExtractEmbeddedObjects
            //ExFor: OleObject.Content
            //ExSummary: Shows how to extract an embedded OLE object.
            var project = new Project(dataDir + "ExtractEmbeddedObjects.mpp");
            var ole = project.OleObjects.ToList()[0];

            // We have to check this property because it can be null if the embedded object was created inside the ms project application Or, alternatively, you can use this check: if (ole.FileFormat == "Package")
            if (string.IsNullOrEmpty(ole.FullPath))
            {
                return;
            }

            using (var stream = new FileStream(dataDir, FileMode.Create))
            {
                stream.Write(ole.Content, 0, ole.Content.Length);
            }
            //ExEnd:ExtractEmbeddedObjects
        }
    }
}