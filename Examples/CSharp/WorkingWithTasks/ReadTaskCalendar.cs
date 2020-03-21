﻿/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithTasks
{
    using System;

    using Aspose.Tasks.Util;

    internal class ReadTaskCalendar
    {
        public static void Run()
        {
            // The path to the documents directory.
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            //ExStart:ReadTaskCalendar
            //ExFor: Tsk.Calendar
            //ExSummary: Shows how to read task calendars.
            // Create project instance
            var prj = new Project(dataDir + "ReadTaskCalendar.mpp");

            // Declare ChildTasksCollector class object
            var collector = new ChildTasksCollector();

            // Use TaskUtils to get all children tasks in RootTask
            TaskUtils.Apply(prj.RootTask, collector, 0);

            // Parse all the recursive children
            foreach (var tsk in collector.Tasks)
            {
                var calendar = tsk.Get(Tsk.Calendar);
                Console.WriteLine("Task calendar name: {0}", calendar == null ? "None" : calendar.Name);
            }
            //ExEnd:ReadTaskCalendar
        }
    }
}
