Imports Aspose.Tasks.Saving

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace WorkingWithProjects.Miscellaneous
    Public Class ReadTableDataFromProjectFile
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName)

            ' ExStart:ReadTableDataFromProjectFile
            Dim project As New Project(dataDir & Convert.ToString("ReadTableData.mpp"))

            ' Access table
            Dim task1 As Table = project.Tables.ToList()(0)
            Console.WriteLine("Table Fields Count" + task1.TableFields.Count.ToString())

            ' Display all table fields information
            For Each tblField As TableField In task1.TableFields
                Console.WriteLine("Field width: " & tblField.Width.ToString())
                Console.WriteLine("Field Title: " & tblField.Title)
                Console.WriteLine("Field Title Alignment: " & tblField.AlignTitle.ToString())
                Console.WriteLine("Field Align Data: " & tblField.AlignData.ToString())
            Next
            ' ExEnd:ReadTableDataFromProjectFile
        End Sub
    End Class
End Namespace