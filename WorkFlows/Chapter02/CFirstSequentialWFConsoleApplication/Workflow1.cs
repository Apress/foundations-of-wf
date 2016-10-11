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

namespace CFirstSequentialWFConsoleApplication
{
	public sealed partial class Workflow1: SequentialWorkflowActivity
	{
        private int InputValue1;
        private int InputValue2;
        private int OutputResult;

        public int Input1
        {
            set {
                InputValue1 = value;
            }
        }

        public int Input2
        {
            set
            {
                InputValue2 = value;
            }
        }

        public int OutputValue
        {
            get
            {
                return OutputResult;
            }
        }

		public Workflow1()
		{
			InitializeComponent();
		}

        private void Step1_ExecuteCode(object sender, EventArgs e)
        {
            OutputResult = InputValue1 + InputValue2;
            Console.WriteLine("Step1");
        }

        private void Step2_ExecuteCode(object sender, EventArgs e)
        {
            Console.WriteLine("Step2");
        }

       

	}

}
