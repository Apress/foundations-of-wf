using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Collections;
using System.Drawing;
using System.Workflow.ComponentModel.Compiler;
using System.Workflow.ComponentModel.Serialization;
using System.Workflow.ComponentModel;
using System.Workflow.ComponentModel.Design;
using System.Workflow.Runtime;
using System.Workflow.Activities;
using System.Workflow.Activities.Rules;

namespace CDelaySuspendTerminateSequential
{   
   
	public sealed partial class Workflow1: SequentialWorkflowActivity
	{
        private int IntCounter = 10;
		public Workflow1()
		{
           
			InitializeComponent();
		}

        private void GreaterThan1Condition(object sender, ConditionalEventArgs e)
        {
            e.Result = IntCounter >1;
            IntCounter++;
        }

        private void LessThanEqual1Condition(object sender, ConditionalEventArgs e)
        {
            e.Result = IntCounter <=1;
            IntCounter++;
        }
	}

}
