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

namespace CDelaySuspendTerminateSequential
{
	public sealed partial class Workflow1
	{
		#region Designer generated code
		
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.CanModifyActivities = true;
            System.Workflow.Activities.CodeCondition codecondition1 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition2 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.ComponentModel.ActivityBind activitybind1 = new System.Workflow.ComponentModel.ActivityBind();
            this.Delay1 = new System.Workflow.Activities.DelayActivity();
            this.ifElseActivity1 = new System.Workflow.Activities.IfElseActivity();
            this.CounterGreater1 = new System.Workflow.Activities.IfElseBranchActivity();
            this.CounterLessEqual1 = new System.Workflow.Activities.IfElseBranchActivity();
            this.SuspendError = new System.Workflow.ComponentModel.SuspendActivity();
            this.terminateError = new System.Workflow.ComponentModel.TerminateActivity();
            // 
            // Delay1
            // 
            this.Delay1.Name = "Delay1";
            this.Delay1.TimeoutDuration = System.TimeSpan.Parse("00:00:30");
            // 
            // ifElseActivity1
            // 
            this.ifElseActivity1.Activities.Add(this.CounterGreater1);
            this.ifElseActivity1.Activities.Add(this.CounterLessEqual1);
            this.ifElseActivity1.Name = "ifElseActivity1";
            // 
            // CounterGreater1
            // 
            this.CounterGreater1.Activities.Add(this.SuspendError);
            codecondition1.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.GreaterThan1Condition);
            this.CounterGreater1.Condition = codecondition1;
            this.CounterGreater1.Name = "CounterGreater1";
            // 
            // CounterLessEqual1
            // 
            this.CounterLessEqual1.Activities.Add(this.terminateError);
            codecondition2.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.LessThanEqual1Condition);
            this.CounterLessEqual1.Condition = codecondition2;
            this.CounterLessEqual1.Name = "CounterLessEqual1";
            activitybind1.Name = "Workflow1";
            activitybind1.Path = "Name";
            // 
            // SuspendError
            // 
            this.SuspendError.Name = "SuspendError";
            this.SuspendError.SetBinding(System.Workflow.ComponentModel.SuspendActivity.ErrorProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind1)));
            // 
            // terminateError
            // 
            this.terminateError.Name = "terminateError";
            // 
            // Workflow1
            // 
            this.Activities.Add(this.Delay1);
            this.Activities.Add(this.ifElseActivity1);
            this.Name = "Workflow1";
            this.CanModifyActivities = false;

		}

		#endregion

        private DelayActivity Delay1;
        private IfElseActivity ifElseActivity1;
        private IfElseBranchActivity CounterGreater1;
        private SuspendActivity SuspendError;
        private TerminateActivity terminateError;
        private IfElseBranchActivity CounterLessEqual1;





    }
}
