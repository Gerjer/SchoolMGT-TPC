Imports System.Data.SqlClient
Imports DevExpress.XtraGrid
Imports DevExpress.XtraEditors
Public Class Class1
    Private _comboPageSize As ComboBoxEdit
    Private _labelDisplay As LabelControl
    Private _gridControl As gridcontrol
    Private _dtSource As DataTable
    Private _recNo As Integer
    Private _currentPage As Integer
    Private _pageSize As Integer
    Private _maxRec As Integer
    Private _pageCount As Integer
    '    Private conn As New SqlConnection("Data Source=CAMS-DEVELOPER1;Initial Catalog=AdventureWorks2008R2;User ID=sa;password=Cams@2013")
    '  Private com As New SqlCommand("select * from Person.Address", conn)

    Public Property PageCount As Integer
        Get
            Return _pageCount
        End Get
        Set(ByVal Value As Integer)
            _pageCount = Value
        End Set
    End Property

    Public Property MaxRec As Integer
        Get
            Return _maxRec
        End Get
        Set(ByVal Value As Integer)
            _maxRec = Value
        End Set
    End Property

    Public Property PageSize As Integer
        Get
            Return _pageSize
        End Get
        Set(ByVal Value As Integer)
            _pageSize = Value
        End Set
    End Property

    Public Property CurrentPage As Integer
        Get
            Return _currentPage
        End Get
        Set(ByVal Value As Integer)
            _currentPage = Value
        End Set
    End Property

    Public Property RecNo As Integer
        Get
            Return _recNo
        End Get
        Set(ByVal Value As Integer)
            _recNo = Value
        End Set
    End Property

    Public Property dtSource As DataTable
        Get
            Return _dtSource
        End Get
        Set(ByVal Value As DataTable)
            _dtSource = Value
        End Set
    End Property

    Public Property GridControl As gridcontrol
        Get
            Return _gridControl
        End Get
        Set(ByVal Value As gridcontrol)
            _gridControl = Value
        End Set
    End Property

    Public Property LabelDisplay As LabelControl
        Get
            Return _labelDisplay
        End Get
        Set(ByVal Value As LabelControl)
            _labelDisplay = Value
        End Set
    End Property

    Public Property ComboPageSize As ComboBoxEdit
        Get
            Return _comboPageSize
        End Get
        Set(ByVal Value As ComboBoxEdit)
            _comboPageSize = Value
        End Set
    End Property

    'Public Function GetData() As DataTable
    '    Dim dt As New DataTable
    '    conn.Open()
    '    dt.Load(com.ExecuteReader)
    '    conn.Close()
    '    Return dt
    'End Function
    Public Sub LoadPage()

        Try
            Dim i As Integer
            Dim startRec As Integer = RecNo
            Dim endRec As Integer
            Dim dtTemp As DataTable
            'Duplicate or clone the source table to create the temporary table.
            dtTemp = dtSource.Clone
            If CurrentPage = PageCount Then
                endRec = MaxRec
            Else
                endRec = PageSize * CurrentPage
            End If
            'Copy the rows from the source table to fill the temporary table.
            For i = startRec To endRec - 1
                If i < dtSource.Rows.Count Then
                    dtTemp.ImportRow(dtSource.Rows(i))
                    RecNo = RecNo + 1
                End If
            Next
            GridControl.DataSource = dtTemp
            DisplayPageInfo()
        Catch ex As Exception

        End Try


    End Sub
    Private Sub DisplayPageInfo()
        LabelDisplay.Text = "Page " & CurrentPage.ToString & "/ " & PageCount.ToString
    End Sub
    Public Sub LastPage()
        CurrentPage = PageCount
        RecNo = PageSize * (CurrentPage - 1)
        LoadPage()
    End Sub
    Public Sub FirstPage()
        If CurrentPage = 1 Then
            Exit Sub
        End If
        CurrentPage = 1
        RecNo = 0
        LoadPage()
    End Sub
    Public Sub PreviousPage()

        If CurrentPage = PageCount Then
            RecNo = PageSize * (CurrentPage - 2) '-2
            Exit Sub
        End If
        CurrentPage = CurrentPage - 1
        If CurrentPage < 1 Then
            CurrentPage = 1
        Else
            RecNo = PageSize * (CurrentPage - 1)
        End If
        LoadPage()

    End Sub
    Public Sub NextPage()
        If CurrentPage = PageCount Then
            Exit Sub
        End If
        CurrentPage = CurrentPage + 1
        If CurrentPage > PageCount Then
            CurrentPage = PageCount
            If RecNo = MaxRec Then
            End If
        End If
        LoadPage()
    End Sub
    Public Sub Innitial(ByVal GridControlData As GridControl, ByVal LabelDisplyPage As LabelControl, ByVal DropPageSize As ComboBoxEdit)
        Dim Grid As GridControl = DirectCast(GridControlData, GridControl)

        If Grid.DataSource IsNot Nothing Then

            GridControl = GridControlData
            LabelDisplay = LabelDisplyPage
            ComboPageSize = DropPageSize
            PageSize = ComboPageSize.Text
            dtSource = Grid.DataSource 'GridControlData.DataSource 'GetData()

            If MaxRec = 0 Then
                MaxRec = dtSource.Rows.Count
            End If

            PageCount = MaxRec \ PageSize
                If (MaxRec Mod PageSize) > 0 Then
                    PageCount = PageCount - 1
                End If
                CurrentPage = 1
                RecNo = 0
                LoadPage()
            End If
    End Sub
End Class
