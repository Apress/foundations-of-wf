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

namespace CFirstStateMachineWFConsoleApplication
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
            this.CompletedState = new System.Workflow.Activities.StateActivity();
            this.FirstState = new System.Workflow.Activities.StateActivity();
            this.eventDrivenActivity1 = new System.Workflow.Activities.EventDrivenActivity();
            this.delayActivity1 = new System.Workflow.Activities.DelayActivity();
            this.setStateActivity1 = new System.Workflow.Activities.SetStateActivity();
            this.SecondState = new System.Workflow.Activities.StateActivity();
            this.eventDrivenActivity2 = new System.Workflow.Activities.EventDrivenActivity();
            this.delayActivity2 = new System.Workflow.Activities.DelayActivity();
            this.setStateActivity2 = new System.Workflow.Activities.SetStateActivity();
            // 
            // CompletedState
            // 
            this.CompletedState.Description = "This is the completed state";
            this.CompletedState.Name = "CompletedState";
            // 
            // FirstState
            // 
            this.FirstState.Activities.Add(this.eventDrivenActivity1);
            this.FirstState.Description = "This is the first state";
            this.FirstState.Name = "FirstState";
            // 
            // eventDrivenActivity1
            // 
            this.eventDrivenActivity1.Activities.Add(this.delayActivity1);
            this.eventDrivenActivity1.Activities.Add(this.setStateActivity1);
            this.eventDrivenActivity1.Name = "eventDrivenActivity1";
            // 
            // delayActivity1
            // 
            this.delayActivity1.Name = "delayActivity1";
            this.delayActivity1.TimeoutDuration = System.TimeSpan.Parse("00:00:30");
            // 
            // setStateActivity1
            // 
            this.setStateActivity1.Name = "setStateActivity1";
            this.setStateActivity1.TargetStateName = "SecondState";
            // 
            // SecondState
            // 
            this.SecondState.Activities.Add(this.eventDrivenActivity2);
            this.SecondState.Description = "This is the second state";
            this.SecondState.Name = "SecondState";
            // 
            // eventDrivenActivity2
            // 
            this.eventDrivenActivity2.Activities.Add(this.delayActivity2);
            this.eventDrivenActivity2.Activities.Add(this.setStateActivity2);
            this.eventDrivenActivity2.Name = "eventDrivenActivity2";
            // 
            // delayActivity2
            // 
            this.delayActivity2.Name = "delayActivity2";
            this.delayActivity2.TimeoutDuration = System.TimeSpan.Parse("00:00:30");
            // 
            // setStateActivity2
            // 
            this.setStateActivity2.Name = "setStateActivity2";
            this.setStateActivity2.TargetStateName = "CompletedState";
            // 
            // Workflow1
            // 
            this.Activities.Add(this.CompletedState);
            this.Activities.Add(this.FirstState);
            this.Activities.Add(this.SecondState);
            this.CompletedStateName = "CompletedState";
            this.DynamicUpdateCondition = null;
            this.InitialStateName = "FirstState";
            this.Name = "Workflow1";
            this.CanModifyActivities = false;

        }

        #endregion

        private StateActivity FirstState;
        private EventDrivenActivity eventDrivenActivity1;
        private DelayActivity delayActivity1;
        private SetStateActivity setStateActivity1;
        private StateActivity SecondState;
        private EventDrivenActivity eventDrivenActivity2;
        private DelayActivity delayActivity2;
        private SetStateActivity setStateActivity2;
        private StateActivity CompletedState;


    }
}
