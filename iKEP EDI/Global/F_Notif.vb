'Imports Microsoft.SqlServer.Management.IntegrationServices
'Imports System.Data.SqlClient
'Imports System.Collections.ObjectModel


Public Class F_Notif


    Sub SSISexecute(leProjet As String, lepackage As String, lesParam As List(Of SSISParam))
        'Try
        '    ' Connection to the database server where the packages are located
        '    Dim ssisConnection As New SqlConnection("Data Source=SQLC1;Initial Catalog=master;Integrated Security=SSPI;")

        '    ' SSIS server object with connection
        '    Dim ssisServer As New IntegrationServices(ssisConnection)

        '    ' The reference to the package which you want to execute
        '    Dim ssisPackage As PackageInfo = ssisServer.Catalogs("SSISDB").Folders("EDI").Projects(leProjet).Packages(lepackage)

        '    ' Add execution parameter to override the default asynchronized execution. If you leave this out the package is executed asynchronized
        '    Dim executionParameters As New Collection(Of PackageInfo.ExecutionValueParameterSet)
        '    Dim executionParameter As New PackageInfo.ExecutionValueParameterSet
        '    executionParameter.ObjectType = 50
        '    executionParameter.ParameterName = "SYNCHRONIZED"
        '    executionParameter.ParameterValue = 1
        '    executionParameters.Add(executionParameter)

        '    For Each a In lesParam
        '        Dim unParam As New PackageInfo.ExecutionValueParameterSet
        '        unParam.ObjectType = 30
        '        unParam.ParameterName = a.Nom
        '        unParam.ParameterValue = a.valeur
        '        executionParameters.Add(unParam)
        '    Next

        '    Me.tMSG.Text = "Execution"
        '    Application.DoEvents()

        '    ' Get the identifier of the execution to get the log
        '    Dim executionIdentifier As Long = ssisPackage.Execute(True, Nothing, executionParameters)

        '    ' Loop through the log and add the messages to the listbox
        '    For Each message As OperationMessage In ssisServer.Catalogs("SSISDB").Executions(executionIdentifier).Messages
        '        Me.tMSG.Text += Chr(10) + (message.MessageType.ToString() + ": " + message.Message)

        '        Me.tMSG.Refresh()
        '        Application.DoEvents()

        '    Next

        'Catch ex As Exception
        '    Me.tMSG.Text = (ex.Message)
        'End Try
    End Sub


    Private Sub F_SSISExec_Shown(sender As Object, e As EventArgs) Handles Me.Shown

    End Sub

    Private Sub F_SSISExec_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub
End Class