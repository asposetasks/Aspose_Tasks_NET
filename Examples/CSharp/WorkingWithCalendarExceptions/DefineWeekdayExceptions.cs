﻿namespace Aspose.Tasks.Examples.CSharp.WorkingWithCalendarExceptions
{
    using System;

    internal class DefineWeekdayExceptions
    {
        public static void Run()
        {
            //ExStart:DefineWeekdayExceptions
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            // Create a project instance
            var prj = new Project();

            // Define Calendar
            var cal = prj.Calendars.Add("Calendar1");

            // Define week days exception for a holiday
            var except = new CalendarException();
            except.EnteredByOccurrences = false;
            except.FromDate = new DateTime(2009, 12, 24, 0, 0, 0);
            except.ToDate = new DateTime(2009, 12, 31, 23, 59, 0);
            except.Type = CalendarExceptionType.Daily;
            except.DayWorking = false;
            cal.Exceptions.Add(except);

            // Save the Project
            prj.Save(dataDir + "Project_DefineWeekDayException_out.xml", Saving.SaveFileFormat.XML);
            //ExEnd:DefineWeekdayExceptions
        }
    }
}
