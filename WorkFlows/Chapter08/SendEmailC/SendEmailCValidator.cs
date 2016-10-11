using System;
using System.Workflow.Activities;
using System.Workflow.ComponentModel;
using System.Workflow.ComponentModel.Compiler;
using System.Text.RegularExpressions;
using System.Net.Mail;


namespace SendEmailC
{
	class SendEmailCValidator:ActivityValidator 
	{
        public override ValidationErrorCollection ValidateProperties(ValidationManager manager, object obj)
        {
            ValidationErrorCollection Errors = new ValidationErrorCollection(base.ValidateProperties(manager, obj));
            SendEmailC sendMailActivityToBeValidated = obj as SendEmailC;

            if (string.IsNullOrEmpty(sendMailActivityToBeValidated.To))
            {
                ValidationError CustomActivityValidationError =
                    new ValidationError("To Address Not Provided", 1);

                Errors.Add(CustomActivityValidationError);
            }

            if (string.IsNullOrEmpty (sendMailActivityToBeValidated.From))
            {
                ValidationError CustomActivityValidationError =
                    new ValidationError("From Address Not Provided", 1);

                Errors.Add(CustomActivityValidationError);
            }
            if (Errors.HasErrors)
            {
                throw new InvalidOperationException(Errors.ToString); 
            }
            return Errors;

        }
	}
}
