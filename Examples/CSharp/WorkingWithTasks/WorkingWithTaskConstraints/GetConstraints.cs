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
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);
            //ExStart:GetConstraints
            var project = new Project(dataDir + "Project2.mpp");

            // Create a ChildTasksCollector instance
            var collector = new ChildTasksCollector();

            // Collect all the tasks from RootTask using TaskUtils
            TaskUtils.Apply(project.RootTask, collector, 0);

            // Parse through all the collected tasks
            foreach (var tsk1 in collector.Tasks)
            {
                Console.WriteLine(tsk1.Get(Tsk.ConstraintDate).ToShortDateString() == "1/1/2000" ? "NA" : tsk1.Get(Tsk.ConstraintDate).ToShortDateString());

                Console.WriteLine(tsk1.Get(Tsk.ConstraintType).ToString());
            }
            //ExEnd:GetConstraints
        }
    }
}
