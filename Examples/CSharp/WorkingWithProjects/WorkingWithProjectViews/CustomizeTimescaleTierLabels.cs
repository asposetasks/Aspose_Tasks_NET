﻿namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.WorkingWithProjectViews
{
    using System;

    using Aspose.Tasks.Saving;
    using Aspose.Tasks.Visualization;

    public class CustomizeTimescaleTierLabels
    {
        public static void Run()
        {
            // The path to the documents directory.
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            //ExStart:CustomizeTimescaleTierLabels
            var project = new Project(dataDir + "Project5.mpp");

            // Add task links
            project.TaskLinks.Add(project.RootTask.Children.Add("Task 1"), project.RootTask.Children.Add("Task 2"));
            
            var view = (GanttChartView)project.DefaultView;
            
            // This code is added for better visualization
            view.MiddleTimescaleTier.Unit = TimescaleUnit.Months;
            project.Set(Prj.TimescaleStart, new DateTime(2012, 8, 6));
            
            // Customize middle tier dates
            view.MiddleTimescaleTier.DateTimeConverter =
            date => new[] { "Янв.", "Фев.", "Мар.", "Апр.", "Май", "Июнь", "Июль", "Авг.", "Сен.", "Окт.", "Ноя.", "Дек." }[date.Month - 1];
            project.Save(dataDir + "CustomizeTimescaleTierLabels_out.pdf", SaveFileFormat.PDF);
            //ExEnd:CustomizeTimescaleTierLabels
        }
    }
}