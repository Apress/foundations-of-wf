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

namespace CSendEmailTest
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
            this.sendEmailC1 = new SendEmailC.SendEmailC();
            // 
            // sendEmailC1
            // 
            this.sendEmailC1.Body = null;
            this.sendEmailC1.Description = "Use to send email via SMTP, uses C#";
            this.sendEmailC1.From = "someone@example.com";
            this.sendEmailC1.Name = "sendEmailC1";
            this.sendEmailC1.SmtpHost = "localhost";
            this.sendEmailC1.Subject = null;
            this.sendEmailC1.To = "someone@example.com";
            // 
            // Workflow1
            // 
            this.Activities.Add(this.sendEmailC1);
            this.Name = "Workflow1";
            this.CanModifyActivities = false;

		}

		#endregion

        private SendEmailC.SendEmailC sendEmailC1;
	}
}
