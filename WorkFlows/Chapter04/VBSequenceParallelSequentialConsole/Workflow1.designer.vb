Imports System
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Collections
Imports System.Drawing
Imports System.Reflection
Imports System.Workflow.ComponentModel.Compiler
Imports System.Workflow.ComponentModel.Serialization
Imports System.Workflow.ComponentModel
Imports System.Workflow.ComponentModel.Design
Imports System.Workflow.Runtime
Imports System.Workflow.Activities
Imports System.Workflow.Activities.Rules

Partial Public class Workflow1

    'NOTE: The following procedure is required by the Workflow Designer
    'It can be modified using the Workflow Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Me.CanModifyActivities = True
        Me.sequenceActivity1 = New System.Workflow.Activities.SequenceActivity
        Me.Sequence1 = New System.Workflow.Activities.CodeActivity
        Me.Sequence2 = New System.Workflow.Activities.CodeActivity
        Me.parallelActivity1 = New System.Workflow.Activities.ParallelActivity
        Me.sequenceActivity2 = New System.Workflow.Activities.SequenceActivity
        Me.sequenceActivity3 = New System.Workflow.Activities.SequenceActivity
        Me.ParallelLeft = New System.Workflow.Activities.CodeActivity
        Me.ParallelRight = New System.Workflow.Activities.CodeActivity
        Me.SequenceDelay = New System.Workflow.Activities.DelayActivity
        Me.ParallelDelay = New System.Workflow.Activities.DelayActivity
        '
        'sequenceActivity1
        '
        Me.sequenceActivity1.Activities.Add(Me.Sequence1)
        Me.sequenceActivity1.Activities.Add(Me.Sequence2)
        Me.sequenceActivity1.Activities.Add(Me.SequenceDelay)
        Me.sequenceActivity1.Name = "sequenceActivity1"
        '
        'Sequence1
        '
        Me.Sequence1.Name = "Sequence1"
        AddHandler Me.Sequence1.ExecuteCode, AddressOf Me.codeActivity1_ExecuteCode
        '
        'Sequence2
        '
        Me.Sequence2.Name = "Sequence2"
        AddHandler Me.Sequence2.ExecuteCode, AddressOf Me.codeActivity2_ExecuteCode
        '
        'parallelActivity1
        '
        Me.parallelActivity1.Activities.Add(Me.sequenceActivity2)
        Me.parallelActivity1.Activities.Add(Me.sequenceActivity3)
        Me.parallelActivity1.Name = "parallelActivity1"
        '
        'sequenceActivity2
        '
        Me.sequenceActivity2.Activities.Add(Me.ParallelLeft)
        Me.sequenceActivity2.Name = "sequenceActivity2"
        '
        'sequenceActivity3
        '
        Me.sequenceActivity3.Activities.Add(Me.ParallelRight)
        Me.sequenceActivity3.Activities.Add(Me.ParallelDelay)
        Me.sequenceActivity3.Name = "sequenceActivity3"
        '
        'ParallelLeft
        '
        Me.ParallelLeft.Name = "ParallelLeft"
        AddHandler Me.ParallelLeft.ExecuteCode, AddressOf Me.codeActivity3_ExecuteCode
        '
        'ParallelRight
        '
        Me.ParallelRight.Name = "ParallelRight"
        AddHandler Me.ParallelRight.ExecuteCode, AddressOf Me.codeActivity4_ExecuteCode
        '
        'SequenceDelay
        '
        Me.SequenceDelay.Name = "SequenceDelay"
        Me.SequenceDelay.TimeoutDuration = System.TimeSpan.Parse("00:00:10")
        '
        'ParallelDelay
        '
        Me.ParallelDelay.Name = "ParallelDelay"
        Me.ParallelDelay.TimeoutDuration = System.TimeSpan.Parse("00:00:10")
        '
        'Workflow1
        '
        Me.Activities.Add(Me.sequenceActivity1)
        Me.Activities.Add(Me.parallelActivity1)
        Me.Name = "Workflow1"
        Me.CanModifyActivities = False

    End Sub
    Private WithEvents sequenceActivity1 As System.Workflow.Activities.SequenceActivity
    Private WithEvents Sequence2 As System.Workflow.Activities.CodeActivity
    Private WithEvents parallelActivity1 As System.Workflow.Activities.ParallelActivity
    Private WithEvents sequenceActivity2 As System.Workflow.Activities.SequenceActivity
    Private WithEvents ParallelLeft As System.Workflow.Activities.CodeActivity
    Private WithEvents sequenceActivity3 As System.Workflow.Activities.SequenceActivity
    Private WithEvents ParallelRight As System.Workflow.Activities.CodeActivity
    Private WithEvents SequenceDelay As System.Workflow.Activities.DelayActivity
    Private WithEvents ParallelDelay As System.Workflow.Activities.DelayActivity
    Private WithEvents Sequence1 As System.Workflow.Activities.CodeActivity

End Class
