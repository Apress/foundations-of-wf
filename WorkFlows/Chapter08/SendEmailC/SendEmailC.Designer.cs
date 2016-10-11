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
using System.Net.Mail;

namespace SendEmailC
{
	public partial class SendEmailC
	{
		#region Activity Designer generated code
		
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
        [System.Diagnostics.DebuggerNonUserCode]
		private void InitializeComponent()
		{
            // 
            // SendEmailC
            // 
            this.Description = "Use to send email via SMTP, uses C#";
            this.Name = "SendEmailC";

		}

		#endregion
        protected override ActivityExecutionStatus Execute(ActivityExecutionContext context)
        {
            try
            {
             
			SmtpClient clsmail = new SmtpClient();
			MailMessage message = new MailMessage();
                               
            message.From = new MailAddress(this.From);
			message.To.Add(this.To);
                			
			if (!String.IsNullOrEmpty(this.Subject))
			{
				message.Subject = this.Subject;
			}

			if (!String.IsNullOrEmpty(this.Body))
			{
				message.Body = this.Body;
			}
                			
			clsmail.Host = this.SmtpHost;
			clsmail.Send(message);
		
            return ActivityExecutionStatus.Closed;
            }
            catch
            {
                // An unhandled exception occured.  Throw it back to the WorkflowRuntime.
                throw;
            }
        }
	}
}
