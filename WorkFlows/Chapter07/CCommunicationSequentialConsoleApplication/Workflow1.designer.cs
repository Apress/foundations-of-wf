using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Collections;
using System.Drawing;
using System.Reflection;
using System.Workflow.ComponentModel.Compiler;
using System.Workflow.ComponentModel.Serialization;
using System.Workflow.ComponentModel;
using System.Workflow.ComponentModel.Design;
using System.Workflow.Runtime;
using System.Workflow.Activities;
using System.Workflow.Activities.Rules;

namespace CCommunicationSequentialConsoleApplication
{
	partial class Workflow1
	{
		#region Designer generated code
		
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
        [System.Diagnostics.DebuggerNonUserCode]
		private void InitializeComponent()
		{
            this.CanModifyActivities = true;
            System.Workflow.ComponentModel.WorkflowParameterBinding workflowparameterbinding1 = new System.Workflow.ComponentModel.WorkflowParameterBinding();
            System.Workflow.ComponentModel.WorkflowParameterBinding workflowparameterbinding2 = new System.Workflow.ComponentModel.WorkflowParameterBinding();
            this.handleReviewNotApproved = new System.Workflow.Activities.HandleExternalEventActivity();
            this.handleReviewApproval = new System.Workflow.Activities.HandleExternalEventActivity();
            this.eventDrivenActivity2 = new System.Workflow.Activities.EventDrivenActivity();
            this.eventDrivenActivity1 = new System.Workflow.Activities.EventDrivenActivity();
            this.ReviewResponse = new System.Workflow.Activities.ListenActivity();
            this.callCreateReview = new System.Workflow.Activities.CallExternalMethodActivity();
            // 
            // handleReviewNotApproved
            // 
            this.handleReviewNotApproved.EventName = "ReviewNotApproved";
            this.handleReviewNotApproved.InterfaceType = typeof(CCommunicationSequentialConsoleApplication.IReview);
            this.handleReviewNotApproved.Name = "handleReviewNotApproved";
            this.handleReviewNotApproved.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.OnNotApproved);
            // 
            // handleReviewApproval
            // 
            this.handleReviewApproval.EventName = "ReviewApproved";
            this.handleReviewApproval.InterfaceType = typeof(CCommunicationSequentialConsoleApplication.IReview);
            this.handleReviewApproval.Name = "handleReviewApproval";
            this.handleReviewApproval.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.OnApproved);
            // 
            // eventDrivenActivity2
            // 
            this.eventDrivenActivity2.Activities.Add(this.handleReviewNotApproved);
            this.eventDrivenActivity2.Name = "eventDrivenActivity2";
            // 
            // eventDrivenActivity1
            // 
            this.eventDrivenActivity1.Activities.Add(this.handleReviewApproval);
            this.eventDrivenActivity1.Name = "eventDrivenActivity1";
            // 
            // ReviewResponse
            // 
            this.ReviewResponse.Activities.Add(this.eventDrivenActivity1);
            this.ReviewResponse.Activities.Add(this.eventDrivenActivity2);
            this.ReviewResponse.Name = "ReviewResponse";
            // 
            // callCreateReview
            // 
            this.callCreateReview.InterfaceType = typeof(CCommunicationSequentialConsoleApplication.IReview);
            this.callCreateReview.MethodName = "CreateReview";
            this.callCreateReview.Name = "callCreateReview";
            workflowparameterbinding1.ParameterName = "Reviewee";
            workflowparameterbinding1.Value = "You";
            workflowparameterbinding2.ParameterName = "Reviewer";
            workflowparameterbinding2.Value = "Me";
            this.callCreateReview.ParameterBindings.Add(workflowparameterbinding1);
            this.callCreateReview.ParameterBindings.Add(workflowparameterbinding2);
            // 
            // Workflow1
            // 
            this.Activities.Add(this.callCreateReview);
            this.Activities.Add(this.ReviewResponse);
            this.Name = "Workflow1";
            this.CanModifyActivities = false;

		}

		#endregion

        private HandleExternalEventActivity handleReviewNotApproved;
        private EventDrivenActivity eventDrivenActivity2;
        private EventDrivenActivity eventDrivenActivity1;
        private ListenActivity ReviewResponse;
        private HandleExternalEventActivity handleReviewApproval;
        private CallExternalMethodActivity callCreateReview;










    }
}
