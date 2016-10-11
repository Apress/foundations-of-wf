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

namespace CIfElseSequentialExample
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
            this.ifElseActivity1 = new System.Workflow.Activities.IfElseActivity();
            this.Branch1 = new System.Workflow.Activities.IfElseBranchActivity();
            this.Branch2 = new System.Workflow.Activities.IfElseBranchActivity();
            this.Branch1Code = new System.Workflow.Activities.CodeActivity();
            this.Branch2Code = new System.Workflow.Activities.CodeActivity();
            // 
            // ifElseActivity1
            // 
            this.ifElseActivity1.Activities.Add(this.Branch1);
            this.ifElseActivity1.Activities.Add(this.Branch2);
            this.ifElseActivity1.Name = "ifElseActivity1";
            // 
            // Branch1
            // 
            this.Branch1.Activities.Add(this.Branch1Code);
            codecondition1.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.Branch1Condition);
            this.Branch1.Condition = codecondition1;
            this.Branch1.Name = "Branch1";
            // 
            // Branch2
            // 
            this.Branch2.Activities.Add(this.Branch2Code);
            codecondition2.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.Branch2Condition);
            this.Branch2.Condition = codecondition2;
            this.Branch2.Name = "Branch2";
            // 
            // Branch1Code
            // 
            this.Branch1Code.Name = "Branch1Code";
            this.Branch1Code.ExecuteCode += new System.EventHandler(this.Branch1Code_ExecuteCode);
            // 
            // Branch2Code
            // 
            this.Branch2Code.Name = "Branch2Code";
            this.Branch2Code.ExecuteCode += new System.EventHandler(this.Branch2Code_ExecuteCode);
            // 
            // Workflow1
            // 
            this.Activities.Add(this.ifElseActivity1);
            this.Name = "Workflow1";
            this.CanModifyActivities = false;

		}

		#endregion

        private IfElseActivity ifElseActivity1;
        private IfElseBranchActivity Branch1;
        private CodeActivity Branch1Code;
        private CodeActivity Branch2Code;
        private IfElseBranchActivity Branch2;





    }
}
