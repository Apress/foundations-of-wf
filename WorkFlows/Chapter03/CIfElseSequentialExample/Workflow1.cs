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

namespace CIfElseSequentialExample
{
	public sealed partial class Workflow1: SequentialWorkflowActivity
	{
        private int IntInputValue;

        public int InputValue
        {
            set
            {
               IntInputValue  = value;
            }
        }
 
		public Workflow1()
		{
			InitializeComponent();
		}

        private void Branch1Condition(object sender, ConditionalEventArgs e)
        {
            e.Result = IntInputValue > 50;
        }

        private void Branch2Condition(object sender, ConditionalEventArgs e)
        {
            e.Result = IntInputValue > 25;
        }

        private void Branch1Code_ExecuteCode(object sender, EventArgs e)
        {
            Console.WriteLine("Branch1");
        }

        private void Branch2Code_ExecuteCode(object sender, EventArgs e)
        {
            Console.WriteLine("Branch2");
        }
	}

}
