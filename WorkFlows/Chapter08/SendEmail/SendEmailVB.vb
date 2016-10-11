'NOTE: When changing the namespace; please update XmlnsDefinitionAttribute in AssemblyInfo.vb
Imports System.Net.Mail
<ActivityValidator(GetType(SendEmailVBValidator))> _
Public Class SendEmailVB
    Inherits System.Workflow.ComponentModel.Activity

    Public Shared FromProperty As DependencyProperty = DependencyProperty.Register("From", GetType(String), GetType(SendEmailVB), New PropertyMetadata("someone@example.com"))
    Public Shared ToProperty As DependencyProperty = DependencyProperty.Register("To", GetType(String), GetType(SendEmailVB), New PropertyMetadata("someone@example.com"))
    Public Shared BodyProperty As DependencyProperty = DependencyProperty.Register("Body", GetType(String), GetType(SendEmailVB))
    Public Shared SubjectProperty As DependencyProperty = DependencyProperty.Register("Subject", GetType(String), GetType(SendEmailVB))
    Public Shared SmtpHostProperty As DependencyProperty = DependencyProperty.Register("SmtpHost", GetType(String), GetType(SendEmailVB), New PropertyMetadata("localhost"))
    <DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)> _
        <ValidationOption(ValidationOption.Required)> _
        <BrowsableAttribute(True)> _
        <DescriptionAttribute("The ToAddress property is used to specify the receipient's email address.")> _
        Public Property ToAddress() As String
        Get
            Return CType(MyBase.GetValue(SendEmailVB.ToProperty), String)
        End Get
        Set(ByVal value As String)
            MyBase.SetValue(SendEmailVB.ToProperty, value)
        End Set
    End Property
    <DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)> _
     <ValidationOption(ValidationOption.Optional)> _
     <BrowsableAttribute(True)> _
     <DescriptionAttribute("The Subject property is used to specify the subject of the Email message.")> _
     Public Property Subject() As String
        Get
            Return CType(MyBase.GetValue(SendEmailVB.SubjectProperty), String)
        End Get
        Set(ByVal value As String)
            MyBase.SetValue(SendEmailVB.SubjectProperty, value)
        End Set
    End Property

    <DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)> _
    <ValidationOption(ValidationOption.Required)> _
    <BrowsableAttribute(True)> _
    <DescriptionAttribute("The From property is used to specify the From (Sender's) address for the email mesage.")> _
    Public Property From() As String
        Get
            Return CType(MyBase.GetValue(SendEmailVB.FromProperty), String)
        End Get
        Set(ByVal value As String)
            MyBase.SetValue(SendEmailVB.FromProperty, value)
        End Set
    End Property

    <DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)> _
    <ValidationOption(ValidationOption.Optional)> _
    <BrowsableAttribute(True)> _
    <DescriptionAttribute("The Body property is used to specify the Body of the email message.")> _
   Public Property Body() As String
        Get
            Return CType(MyBase.GetValue(SendEmailVB.BodyProperty), String)
        End Get
        Set(ByVal value As String)
            MyBase.SetValue(SendEmailVB.BodyProperty, value)
        End Set
    End Property
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)> _
        <ValidationOption(ValidationOption.Required)> _
        <Description("The SMTP host is the machine running SMTP that will send the email.  The default is 'localhost'")> _
        <Browsable(True)> _
        Public Property SmtpHost() As String
        Get
            Return CType(MyBase.GetValue(SendEmailVB.SmtpHostProperty), String)
        End Get
        Set(ByVal value As String)
            MyBase.SetValue(SendEmailVB.SmtpHostProperty, value)
        End Set
    End Property
    
    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub
    Protected Overrides Function Execute(ByVal context As ActivityExecutionContext) As ActivityExecutionStatus
        Dim clsMail As New SmtpClient
        Dim Message As New MailMessage
        Try
            Message.From = New MailAddress(Me.From)
            Message.To.Add(Me.ToAddress)
            If Not String.IsNullOrEmpty(Me.Subject) Then
                Message.Subject = Me.Subject
            End If
            If Not String.IsNullOrEmpty(Me.Body) Then
                Message.Body = Me.Body
            End If

            clsMail.Host = Me.SmtpHost
            clsMail.Send(Message)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return ActivityExecutionStatus.Closed
    End Function
End Class
