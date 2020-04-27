﻿namespace Aspose.Tasks.Examples.CSharp
{
    using System.Drawing;
    using NUnit.Framework;
    using Saving;

    [TestFixture]
    public class ExUsageView : ApiExampleBase
    {
        [Test]
        public void RenderTaskUsageViewWithDetails()
        {
            // ExStart:RenderTaskUsageViewWithDetails
            // ExFor: UsageView
            // ExFor: UsageView.#ctor
            // ExFor: UsageView.DisplayDetailsHeaderColumn
            // ExFor: UsageView.RepeatDetailsHeaderOnAllRows
            // ExFor: UsageView.DisplayShortDetailHeaderNames
            // ExFor: UsageView.AlignDetailsData
            // ExSummary: Shows how to render task usage view with details.
            var project = new Project(DataDir + "TaskUsageViewWithDetails.mpp");

            // get the view
            UsageView view = (TaskUsageView)project.DefaultView;

            // details header column will not be displayed
            view.DisplayDetailsHeaderColumn = false;
            view.RepeatDetailsHeaderOnAllRows = false;
            view.DisplayShortDetailHeaderNames = false;
            view.AlignDetailsData = StringAlignment.Near;
            project.Save(OutDir + "task usage1_out.pdf", SaveFileFormat.PDF);

            // display details header column
            view.DisplayDetailsHeaderColumn = true;

            // repeat details header on all assignments rows
            view.RepeatDetailsHeaderOnAllRows = true;
            view.AlignDetailsData = StringAlignment.Far;
            project.Save(OutDir + "task usage2_out.pdf", SaveFileFormat.PDF);

            // ExEnd:RenderTaskUsageViewWithDetails
        }
    }
}