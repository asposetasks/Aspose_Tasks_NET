﻿/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithTasks.WorkingWithTaskConstraints
{
    using System;

    using Aspose.Tasks.Util;

    internal class GetConstraints
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());
            //ExStart:GetConstraints
            //ExFor: Tsk.ConstraintType
            //ExFor: Tsk.ConstraintDate
            //ExSummary: Shows how to read task constraints' information.
            var project = new Project(dataDir + "Project2.mpp");

            // Create a ChildTasksCollector instance
            var collector = new ChildTasksCollector();

            // Collect all the tasks from RootTask using TaskUtils
            TaskUtils.Apply(project.RootTask, collector, 0);

            // Parse through all the collected tasks
            foreach (var task in collector.Tasks)
            {
                Console.WriteLine(task.Get(Tsk.ConstraintType).ToString());
                Console.WriteLine(task.Get(Tsk.ConstraintDate).ToShortDateString() == "1/1/2000" ? "NA" : task.Get(Tsk.ConstraintDate).ToShortDateString());
            }
            //ExEnd:GetConstraints
        }
    }
}
