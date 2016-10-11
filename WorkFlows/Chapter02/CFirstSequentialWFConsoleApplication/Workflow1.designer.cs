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

namespace CFirstSequentialWFConsoleApplication
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
            this.Step2 = new System.Workflow.Activities.CodeActivity();
            this.Step1 = new System.Workflow.Activities.CodeActivity();
            // 
            // Step2
            // 
            this.Step2.Description = "This is step 2";
            this.Step2.Name = "Step2";
            this.Step2.ExecuteCode += new System.EventHandler(this.Step2_ExecuteCode);
            // 
            // Step1
            // 
            this.Step1.Name = "Step1";
            this.Step1.ExecuteCode += new System.EventHandler(this.Step1_ExecuteCode);
            // 
            // Workflow1
            // 
            this.Activities.Add(this.Step1);
            this.Activities.Add(this.Step2);
            this.Name = "Workflow1";
            this.CanModifyActivities = false;

		}

		#endregion

        private CodeActivity Step2;
        private CodeActivity Step1;





    }
}
