﻿/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/
namespace Aspose.Tasks.Examples.CSharp.WorkingWithResourceAssignments
{
    using System;

    using Aspose.Tasks.Saving;

    internal class ReadWriteRateScaleForResourceAssignment
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());

            try
            {
                //ExStart: ReadWriteRateScaleForResourceAssignment
                //ExFor: Asn.RateScale
                //ExSummary: Shows how to work with assignment's rate scale. 
                var project = new Project(dataDir + "New project 2013.mpp");

                var task = project.RootTask.Children.Add("t1");

                var materialResource = project.Resources.Add("materialResource");
                materialResource.Set(Rsc.Type, ResourceType.Material);

                var nonMaterialResource = project.Resources.Add("nonMaterialResource");
                nonMaterialResource.Set(Rsc.Type, ResourceType.Work);

                var materialResourceAssignment = project.ResourceAssignments.Add(task, materialResource);
                materialResourceAssignment.Set(Asn.RateScale, RateScaleType.Week);

                var nonMaterialResourceAssignment = project.ResourceAssignments.Add(task, nonMaterialResource);
                nonMaterialResourceAssignment.Set(Asn.RateScale, RateScaleType.Week);

                project.Save(dataDir + "ReadWriteRateScaleForResourceAssignment_out.mpp", SaveFileFormat.MPP);

                var resavedProject = new Project(dataDir + "ReadWriteRateScaleForResourceAssignment_out.mpp");

                var resavedMaterialResourceAssignment = resavedProject.ResourceAssignments.GetByUid(2);
                Console.WriteLine(resavedMaterialResourceAssignment.Get(Asn.RateScale));

                // only material resource assignments can have non-zero rate scale value.
                var resavedNonMaterialResourceAssignment = resavedProject.ResourceAssignments.GetByUid(3);
                Console.WriteLine(resavedNonMaterialResourceAssignment.Get(Asn.RateScale));
                //ExEnd: ReadWriteRateScaleForResourceAssignment
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
    }
}
