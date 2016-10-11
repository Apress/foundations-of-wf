Public Class EPRService
    Implements IEPRService
    Private e As EPREventArgs
    Public Sub RaiseEmployeetoSupervisor(ByVal ReviewID As Integer, ByVal InstanceId As Guid)
        e = New EPREventArgs(InstanceId, ReviewID)
        RaiseEvent EmployeeToSupervisor(Me, e)
    End Sub
    Public Sub RaiseSupervisorToEmployee(ByVal ReviewID As Integer, ByVal InstanceID As Guid)
        e = New EPREventArgs(InstanceID, ReviewID)
        RaiseEvent SupervisorToEmployee(Me, e)
    End Sub
    Public Sub RaiseEmployeeApproved(ByVal ReviewID As Integer, ByVal InstanceID As Guid)
        e = New EPREventArgs(InstanceID, ReviewID)
        RaiseEvent EmployeeApproved(Me, e)
    End Sub
    Public Sub RaiseEmployeeNotApproved(ByVal ReviewID As Integer, ByVal instanceid As Guid)
        e = New EPREventArgs(instanceid, ReviewID)
        RaiseEvent EmployeeNotApproved(Me, e)
    End Sub
    Public Event EmployeeToSupervisor(ByVal sender As Object, ByVal e As EPREventArgs) Implements IEPRService.EmployeeToSupervisor

    Public Event EmployeeApproved(ByVal sender As Object, ByVal e As EPREventArgs) Implements IEPRService.EmployeeApproved

    Public Event EmployeeNotApproved(ByVal sender As Object, ByVal e As EPREventArgs) Implements IEPRService.EmployeeNotApproved

    Public Event SupervisorToEmployee(ByVal sender As Object, ByVal e As EPREventArgs) Implements IEPRService.SupervisorToEmployee
End Class
