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
using System.Windows.Forms;

namespace CCommunicationSequentialConsoleApplication
{
	public sealed partial class Workflow1: SequentialWorkflowActivity
	{
		public Workflow1()
		{
			InitializeComponent();
		}
        private void OnApproved(object sender, ExternalDataEventArgs e)
        {
            MessageBox.Show("Approved");
        }
        private void OnNotApproved(object sender, ExternalDataEventArgs e)
        {
            MessageBox.Show("Not Approved");
        }
	}

}
