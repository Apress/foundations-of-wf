using System;
using System.Collections.Generic;
using System.Text;
using System.Workflow.Activities;
using System.Workflow.ComponentModel;
using System.Workflow.Runtime;
using System.Windows.Forms;
using System.Threading;

namespace CCommunicationSequentialConsoleApplication
{
    [Serializable]
    internal class ReviewEventArgs : ExternalDataEventArgs
    {
        private string alias;

        public ReviewEventArgs(Guid InstanceID, string alias)
            : base(InstanceID)
        {
            this.alias = alias;
        }

        public string Alias
        {
            get { return this.alias; }
            set { this.alias = value; }
        }
    }
   
    [ExternalDataExchange]
    interface IReview
    {
        Boolean CreateReview(String Reviewer, String Reviewee);
        event EventHandler<ExternalDataEventArgs  > ReviewApproved;
        event EventHandler<ExternalDataEventArgs  > ReviewNotApproved;
    }

	class ReviewService:IReview
	{
        static String StrReviewer;
        static String StrReviewee;
        public event EventHandler<ExternalDataEventArgs > ReviewApproved;
        public event EventHandler<ExternalDataEventArgs > ReviewNotApproved;

        public Boolean CreateReview(String Reviewer, String Reviewee)
        {
            StrReviewer = Reviewer;
            StrReviewee = Reviewee;
            MessageBox.Show("Reviewer: " + Reviewer);
            ThreadPool.QueueUserWorkItem (AskForApproval ,new ReviewEventArgs(WorkflowEnvironment.WorkflowInstanceId,Reviewer ));
            return true;
        }
        public void AskForApproval(Object O)
        {
            DialogResult Result;
            ReviewEventArgs  revieweargs = O as ReviewEventArgs ;
            Guid instanceId = revieweargs.InstanceId;
            string alias = revieweargs.Alias;
            Result = MessageBox.Show("Do you approve the review for " + StrReviewee + " ?", "Approval", MessageBoxButtons.YesNo);
            if (Result == DialogResult.Yes)
            {
              ReviewApproved(null, revieweargs);
            }
            else
            {
                ReviewNotApproved(null, revieweargs);
            }

        }

        
	}
}
