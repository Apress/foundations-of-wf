'NOTE: When changing the namespace; please update XmlnsDefinitionAttribute in AssemblyInfo.vb
Module Module1
    Class Program

        Shared WaitHandle As New AutoResetEvent(False)

        Shared Sub Main()
            Dim Parameters As New Dictionary(Of String, Object)
            Console.Write("Enter the Part Number:")
            Parameters.Add("PartNumber", Console.ReadLine)

            Console.Write("Enter the Purchase Date:")
            Parameters.Add("PurchaseDate", CDate(Console.ReadLine))

            Console.Write("Enter the Expected Date:")
            Parameters.Add("ExpectedDate", CDate(Console.ReadLine))

            Console.Write("Enter the Buyer Login:")
            Parameters.Add("BuyerLogin", Console.ReadLine)

            Console.Write("Enter the Buyer Name:")
            Parameters.Add("BuyerName", Console.ReadLine)

            Console.Write("Enter the Quantity Ordered:")
            Parameters.Add("QuantityOrdered", CInt(Console.ReadLine))


            Using workflowRuntime As New WorkflowRuntime()
                AddHandler workflowRuntime.WorkflowCompleted, AddressOf OnWorkflowCompleted
                AddHandler workflowRuntime.WorkflowTerminated, AddressOf OnWorkflowTerminated

                Dim workflowInstance As WorkflowInstance


                workflowInstance = workflowRuntime.CreateWorkflow(GetType(PurchaseOrderProcess), Parameters)
                workflowInstance.Start()
                WaitHandle.WaitOne()
            End Using
        End Sub

        Shared Sub OnWorkflowCompleted(ByVal sender As Object, ByVal e As WorkflowCompletedEventArgs)
            If Not e.OutputParameters("PurchaseOrderNumber") Is Nothing Then
                MsgBox("Purchase Order Number is: " & e.OutputParameters("PurchaseOrderNumber").ToString)
            End If
            WaitHandle.Set()
        End Sub

        Shared Sub OnWorkflowTerminated(ByVal sender As Object, ByVal e As WorkflowTerminatedEventArgs)
            Console.WriteLine(e.Exception.Message)
            WaitHandle.Set()
        End Sub

    End Class
End Module

