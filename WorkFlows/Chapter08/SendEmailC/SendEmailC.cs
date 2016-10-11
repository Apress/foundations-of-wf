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

namespace SendEmailC
{
    public partial class SendEmailC : System.Workflow.ComponentModel.Activity
	{
        public static DependencyProperty FromProperty = DependencyProperty.Register("From", typeof(string), typeof(SendEmailC), new PropertyMetadata("someone@example.com"));
        public static DependencyProperty ToProperty = DependencyProperty.Register("To", typeof(string), typeof(SendEmailC), new PropertyMetadata("someone@example.com"));
        public static DependencyProperty BodyProperty = DependencyProperty.Register("Body", typeof(string), typeof(SendEmailC));
        public static DependencyProperty SubjectProperty = DependencyProperty.Register("Subject", typeof(string), typeof(SendEmailC));
        public static DependencyProperty SmtpHostProperty = DependencyProperty.Register("SmtpHost", typeof(string), typeof(SendEmailC), new PropertyMetadata("localhost"));



		public SendEmailC()
		{
			InitializeComponent();
		}

        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)]
        [ValidationOption(ValidationOption.Required)]
        [BrowsableAttribute(true)]
        [DescriptionAttribute("The To property is used to specify the receipient's email address.")]
        public string To
        {
            get
            {
                return ((string)(base.GetValue(SendEmailC.ToProperty)));
            }
            set
            {
                base.SetValue(SendEmailC.ToProperty, value);
            }
        }


        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)]
        [ValidationOption(ValidationOption.Optional)]
        [BrowsableAttribute(true)]
        [DescriptionAttribute("The Subject property is used to specify the subject of the Email message.")]
        public string Subject
        {
            get
            {
                return ((string)(base.GetValue(SendEmailC.SubjectProperty)));
            }
            set
            {
                base.SetValue(SendEmailC.SubjectProperty, value);
            }
        }


        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)]
        [ValidationOption(ValidationOption.Required)]
        [BrowsableAttribute(true)]
        [DescriptionAttribute("The From property is used to specify the From (Sender's) address for the email mesage.")]
        public string From
        {
            get
            {
                return ((string)(base.GetValue(SendEmailC.FromProperty)));
            }
            set
            {
                base.SetValue(SendEmailC.FromProperty, value);
            }
        }


        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)]
        [ValidationOption(ValidationOption.Optional)]
        [BrowsableAttribute(true)]
        [DescriptionAttribute("The Body property is used to specify the Body of the email message.")]
        public string Body
        {

            get
            {
                return (string)base.GetValue(SendEmailC.BodyProperty);
            }
            set
            {

                base.SetValue(SendEmailC.BodyProperty, value);
            }

        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [ValidationOption(ValidationOption.Required)]
        [Description("The SMTP host is the machine running SMTP that will send the email.  The default is 'localhost'")]
        [Browsable(true)]
        public string SmtpHost
        {
            get
            {
                return ((string)(base.GetValue(SendEmailC.SmtpHostProperty)));
            }
            set
            {
                base.SetValue(SendEmailC.SmtpHostProperty, value);
            }
        }

        

	}
}
