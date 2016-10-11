Imports System
Imports System.Workflow.Activities
<ExternalDataExchange()> _
Public Interface IEPRService
    Event EmployeeToSupervisor As EventHandler(Of EPREventArgs)
    Event SupervisorToEmployee As EventHandler(Of EPREventArgs)
    Event EmployeeApproved As EventHandler(Of EPREventArgs)
    Event EmployeeNotApproved As EventHandler(Of EPREventArgs)
End Interface
