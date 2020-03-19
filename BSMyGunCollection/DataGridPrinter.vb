Imports System.Drawing.Printing
Imports System.Drawing
Imports System.Security.Principal
Imports System.Reflection

#Region "DataGridPrinter"
'\\ --[DataGridPrinter]----------------------------------------------
'\\ Provides a way to print a nicely formatted page from a data grid
'\\ control.
'\\ -----------------------------------------------------------------
Public Class DataGridPrinter
#Region "Private enumerated types"
    Public Enum CellTextHorizontalAlignment
        LeftAlign = 1
        CentreAlign = 2
        RightAlign = 3
    End Enum
    Public Enum CellTextVerticalAlignment
        TopAlign = 1
        MiddleAlign = 2
        BottomAlign = 3
    End Enum
#End Region
#Region "Private properties"
    '\\ Printing the report related
    Private WithEvents _GridPrintDocument As PrintDocument
    Private _DataGrid As DataGrid
    '\\ Print progress variables
    Private _CurrentPrintGridLine As Integer
    Private _CurrentPageDown As Integer
    Private _CurrentPageAcross As Integer = 1
    '\\ Fonts to use to do the printing...
    Private _PrintFont As New Font(System.Drawing.FontFamily.GenericSansSerif, 9)
    Private _HeaderFont As New Font(System.Drawing.FontFamily.GenericSansSerif, 12)
    Private _FooterFont As New Font(System.Drawing.FontFamily.GenericSansSerif, 10)
    Private _HeaderRectangle As Rectangle
    Private _FooterRectangle As Rectangle
    Private _PageContentRectangle As Rectangle
    Private _Rowheight As Double
    '\\ Column widths related
    Private _PagesAcross As Integer = 1
    Private _ColumnBounds As New ColumnBounds
    Private _Textlayout As System.Drawing.StringFormat
    Private _FooterHeightPercent As Integer = 3
    Private _HeaderHeightPercent As Integer = 7
    Private _InterSectionSpacingPercent As Integer = 2
    Private _CellGutter As Integer = 5
    '\\ Pens to draw the sections with
    Private _FooterPen As New Pen(Color.Green)
    Private _HeaderPen As New Pen(Color.RoyalBlue)
    Private _GridPen As New Pen(Color.Black)
    '\\ Brushes to fill the sections with
    Private _HeaderBrush As Brush = Brushes.White
    Private _FooterBrush As Brush = Brushes.White
    Private _ColumnHeaderBrush As Brush = Brushes.White
    Private _OddRowBrush As Brush = Brushes.White
    Private _EvenRowBrush As Brush = Brushes.White
    Private _HeaderText As String
    Private _LoggedInUsername As String
    Private _GridRowCount As Integer
    Private _GridColumnCount As Integer
#End Region
#Region "Public interface"
#Region "Properties"
#Region "PagesAcross"
    Public Property PagesAcross() As Integer
        Get
            Return _PagesAcross
        End Get
        Set(ByVal Value As Integer)
            If Value < 1 Then
                Throw New ArgumentOutOfRangeException("PagesAcross", "Must be one or more pages across")
            End If
            _PagesAcross = Value
        End Set
    End Property
#End Region
#Region "FooterHeightPercent"
    Public Property FooterHeightPercent() As Integer
        Get
            Return _FooterHeightPercent
        End Get
        Set(ByVal Value As Integer)
            If Value < 0 OrElse Value >= 30 Then
                Throw New ArgumentException("FooterHeightPercent must be between 0 and 30")
            End If
            _FooterHeightPercent = Value
        End Set
    End Property
#End Region
#Region "HeaderHeightPercent"
    Public Property HeaderHeightPercent() As Integer
        Get
            Return _HeaderHeightPercent
        End Get
        Set(ByVal Value As Integer)
            If Value < 0 OrElse Value >= 30 Then
                Throw New ArgumentException("HeaderHeightPercent must be between 0 and 30")
            End If
            _HeaderHeightPercent = Value
        End Set
    End Property
#End Region
#Region "InterSectionSpacingPercent"
    Public Property InterSectionSpacingPercent() As Integer
        Get
            Return _InterSectionSpacingPercent
        End Get
        Set(ByVal Value As Integer)
            If Value < 0 OrElse Value >= 20 Then
                Throw New ArgumentException("InterSectionSpacingPercent must be between 0 and 20")
            End If
            _InterSectionSpacingPercent = Value
        End Set
    End Property
#End Region

#Region "CellGutter"
    Public Property CellGutter() As Integer
        Get
            Return _CellGutter
        End Get
        Set(ByVal Value As Integer)
            If Value < 0 OrElse Value >= 10 Then
                Throw New ArgumentException("CellGutter must be between 0 and 10")
            End If
            _CellGutter = Value
        End Set
    End Property
#End Region

#Region "HeaderFont"
    Public Property HeaderFont() As Font
        Get
            Return _HeaderFont
        End Get
        Set(ByVal Value As Font)
            '\\ Possible font size validation here..
            _HeaderFont = Value
        End Set
    End Property
#End Region
#Region "PrintFont"
    Public Property PrintFont() As Font
        Get
            Return _PrintFont
        End Get
        Set(ByVal Value As Font)
            '\\ Possible font size validation here
            _PrintFont = Value
        End Set
    End Property
#End Region
#Region "FooterFont"
    Public Property FooterFont() As Font
        Get
            Return _FooterFont
        End Get
        Set(ByVal Value As Font)
            '\\ Possible font size validation here
            _FooterFont = Value
        End Set
    End Property
#End Region

#Region "HeaderText"
    Public Property HeaderText() As String
        Get
            Return _HeaderText
        End Get
        Set(ByVal Value As String)
            _HeaderText = Value
        End Set
    End Property
#End Region

#Region "HeaderPen"
    Public Property HeaderPen() As Pen
        Get
            Return _HeaderPen
        End Get
        Set(ByVal Value As Pen)
            _HeaderPen = Value
        End Set
    End Property
#End Region
#Region "FooterPen"
    Public Property FooterPen() As Pen
        Get
            Return _FooterPen
        End Get
        Set(ByVal Value As Pen)
            _FooterPen = Value
        End Set
    End Property
#End Region
#Region "GridPen"
    Public Property GridPen() As Pen
        Get
            Return _GridPen
        End Get
        Set(ByVal Value As Pen)
            _GridPen = Value
        End Set
    End Property
#End Region

#Region "HeaderBrush"
    Public Property HeaderBrush() As Brush
        Get
            Return _HeaderBrush
        End Get
        Set(ByVal Value As Brush)
            _HeaderBrush = Value
        End Set
    End Property
#End Region
#Region "FooterBrush"
    Public Property FooterBrush() As Brush
        Get
            Return _FooterBrush
        End Get
        Set(ByVal Value As Brush)
            _FooterBrush = Value
        End Set
    End Property
#End Region
#Region "ColumnHeaderBrush"
    Public Property ColumnHeaderBrush() As Brush
        Get
            Return _ColumnHeaderBrush
        End Get
        Set(ByVal Value As Brush)
            _ColumnHeaderBrush = Value
        End Set
    End Property
#End Region
#Region "OddRowBrush"
    Public Property OddRowBrush() As Brush
        Get
            Return _OddRowBrush
        End Get
        Set(ByVal Value As Brush)
            _OddRowBrush = Value
        End Set
    End Property
#End Region
#Region "EvenRowBrush"
    Public Property EvenRowBrush() As Brush
        Get
            Return _EvenRowBrush
        End Get
        Set(ByVal Value As Brush)
            _EvenRowBrush = Value
        End Set
    End Property
#End Region

#Region "PrintDocument"
    Public ReadOnly Property PrintDocument() As PrintDocument
        Get
            Return _GridPrintDocument
        End Get
    End Property
#End Region

#Region "DataGrid"
    Public WriteOnly Property DataGrid() As DataGrid
        Set(ByVal Value As DataGrid)
            _DataGrid = Value
        End Set
    End Property
#End Region

#End Region

#Region "Methods"

#Region "Shared methods"
    '\\ --[StripDomainFromFullUsername]------------------------------------------------
    '\\ Returns just the username bit from a username that includes a domain name
    '\\ e.g. "DEVELOPMENT\Duncan" -> "Duncan"
    '\\ (c) 2005 - Merrion Computing Ltd
    '\\ -------------------------------------------------------------------------------
    Public Shared Function StripDomainFromFullUsername(ByVal FullUsername As String) As String

        If FullUsername.IndexOf("\") = -1 Then
            Return FullUsername
        Else
            Dim sep() As Char = {Char.Parse("\")}
            Dim chaf() As String = FullUsername.Split(sep)
            Return (chaf(chaf.Length - 1))
        End If

    End Function
#End Region

#Region "Print"
    Public Sub Print()
        _GridPrintDocument.Print()
    End Sub
#End Region
#End Region


#End Region

#Region "_GridPrintDocument events"
    Private Sub _GridPrintDocument_BeginPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles _GridPrintDocument.BeginPrint

        '\\ Initialize the current page and current grid line variables
        _CurrentPrintGridLine = 1
        _CurrentPageDown = 1
        _CurrentPageAcross = 1

        If _Textlayout Is Nothing Then
            _Textlayout = New System.Drawing.StringFormat
            _Textlayout.Trimming = StringTrimming.EllipsisCharacter
        End If

    End Sub

    Private Sub _GridPrintDocument_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles _GridPrintDocument.PrintPage

        If _CurrentPageDown = 1 And _CurrentPageAcross = 1 Then
            ' _HeaderRectangle -  The top 10% of the page
            _HeaderRectangle = e.MarginBounds
            _HeaderRectangle.Height = CInt(e.MarginBounds.Height * _HeaderHeightPercent * 0.01)

            ' _FooterRectangle - the bottom 10% of the page
            _FooterRectangle = e.MarginBounds
            _FooterRectangle.Height = CInt(e.MarginBounds.Height * _FooterHeightPercent * 0.01)
            _FooterRectangle.Y += CInt(e.MarginBounds.Height * (1 - (0.01 * _FooterHeightPercent)))

            ' _PageContentRectangle - The middle 80% of the page
            _PageContentRectangle = e.MarginBounds
            _PageContentRectangle.Y += CInt(_HeaderRectangle.Height + e.MarginBounds.Height * (_InterSectionSpacingPercent * 0.01))
            _PageContentRectangle.Height = CInt(e.MarginBounds.Height * 0.8)

            _Rowheight = e.Graphics.MeasureString("a", _PrintFont).Height

            '\\ Create the _ColumnBounds array
            Dim nColumn As Integer
            Dim TotalWidth As Double

            If _DataGrid.DataSource Is Nothing Then
                '\\ Nothing in the grid to print
                Exit Sub
            End If

            Dim ColumnCount As Integer = GridColumnCount()

            For nColumn = 0 To ColumnCount - 1
                Dim rcLastCell As Rectangle = _DataGrid.GetCellBounds(0, nColumn)
                If rcLastCell.Width > 0 Then
                    TotalWidth += rcLastCell.Width
                End If
            Next

            _ColumnBounds.Clear()
            For nColumn = 0 To ColumnCount - 1
                '\\ Calculate the column start point
                Dim NextColumn As New ColumnBound
                If nColumn = 0 Then
                    NextColumn.Left = e.MarginBounds.Left
                Else
                    NextColumn.Left = _ColumnBounds.RightExtents
                End If
                '\\ Set this column's width
                Dim rcCell As Rectangle = _DataGrid.GetCellBounds(0, nColumn)
                If rcCell.Width > 0 Then
                    NextColumn.Width = (rcCell.Width / TotalWidth) * (e.MarginBounds.Width * PagesAcross)
                    If NextColumn.Width > e.MarginBounds.Width Then
                        NextColumn.Width = e.MarginBounds.Width
                    End If
                End If
                If _ColumnBounds.RightExtents + NextColumn.Width > e.MarginBounds.Width Then
                    _ColumnBounds.NextPage()
                    NextColumn.Left = e.MarginBounds.Left
                End If
                _ColumnBounds.Add(NextColumn)
            Next
            If _ColumnBounds.TotalPages > Me.PagesAcross Then
                Me.PagesAcross = _ColumnBounds.TotalPages
            End If
        End If

        '\\ Print the document header
        Call PrintHeader(e)

        '\\ Print as many grid lines as can fit
        Dim nextLine As Int32
        Call PrintGridHeaderLine(e)
        Dim StartOfpage As Integer = _CurrentPrintGridLine
        'For nextLine = _CurrentPrintGridLine To Min((_CurrentPrintGridLine + RowsPerPage(_PrintFont, e.Graphics)), CType(_DataGrid.DataSource, System.Data.DataTable).DefaultView.Count)
        For nextLine = _CurrentPrintGridLine To Min((_CurrentPrintGridLine + RowsPerPage(_PrintFont, e.Graphics)), CType(_DataGrid.DataSource, System.Data.DataTable).DefaultView.Count)
            Call PrintGridLine(e, nextLine)
        Next
        _CurrentPrintGridLine = nextLine

        '\\ Print the document footer
        Call PrintFooter(e)

        If _CurrentPageAcross = PagesAcross Then
            _CurrentPageAcross = 1
            _CurrentPageDown += 1
        Else
            _CurrentPageAcross += 1
            _CurrentPrintGridLine = StartOfpage
        End If

        '\\ If there are more lines to print, set the HasMorePages property to true
        If _CurrentPrintGridLine < GridRowCount() Then
            e.HasMorePages = True
        End If

    End Sub
#End Region

#Region "Private methods"
    Private Sub PrintHeader(ByVal e As System.Drawing.Printing.PrintPageEventArgs)

        If _HeaderRectangle.Height > 0 Then
            e.Graphics.FillRectangle(_HeaderBrush, _HeaderRectangle)
            e.Graphics.DrawRectangle(_HeaderPen, _HeaderRectangle)
            Call DrawCellString(_HeaderText, CellTextHorizontalAlignment.CentreAlign, CellTextVerticalAlignment.MiddleAlign, _HeaderRectangle, False, e.Graphics, _HeaderFont, _HeaderBrush)
        End If

    End Sub

    Private Sub PrintFooter(ByVal e As System.Drawing.Printing.PrintPageEventArgs)

        If _FooterRectangle.Height > 0 Then
            e.Graphics.FillRectangle(_FooterBrush, _FooterRectangle)
            e.Graphics.DrawRectangle(_FooterPen, _FooterRectangle)
            Call DrawCellString("Printed by " & _LoggedInUsername, CellTextHorizontalAlignment.LeftAlign, CellTextVerticalAlignment.MiddleAlign, _FooterRectangle, False, e.Graphics, _PrintFont, Brushes.White)
            Call DrawCellString(DateTime.Now.ToLongDateString, CellTextHorizontalAlignment.CentreAlign, CellTextVerticalAlignment.MiddleAlign, _FooterRectangle, False, e.Graphics, _PrintFont, Brushes.White)
            Call DrawCellString("Page " & (((_CurrentPageDown - 1) * PagesAcross) + _CurrentPageAcross).ToString, CellTextHorizontalAlignment.RightAlign, CellTextVerticalAlignment.MiddleAlign, _FooterRectangle, False, e.Graphics, _PrintFont, Brushes.White)
        End If

    End Sub

    Private Sub PrintGridLine(ByVal e As System.Drawing.Printing.PrintPageEventArgs, ByVal RowNumber As Integer)

        Dim RowFromTop As Integer = RowNumber + 1 - _CurrentPrintGridLine
        Dim Top As Double = _PageContentRectangle.Top + (RowFromTop * ((_CellGutter * 2) + _Rowheight))
        Dim Bottom As Double = Top + _Rowheight + (2 * _CellGutter)

        Top = RoundTo(Top, 2)
        Bottom = RoundTo(Bottom, 2)

        Dim Items() As Object = Nothing
        Try
            If TypeOf _DataGrid.DataSource Is DataTable Then
                Items = CType(_DataGrid.DataSource, System.Data.DataTable).DefaultView.Item(RowNumber - 1).Row.ItemArray
            ElseIf TypeOf _DataGrid.DataSource Is DataSet Then
                Items = CType(_DataGrid.DataSource, System.Data.DataSet).Tables(_DataGrid.DataMember).DefaultView.Item(RowNumber - 1).Row.ItemArray
            ElseIf TypeOf _DataGrid.DataSource Is DataView Then
                Items = CType(_DataGrid.DataSource, System.Data.DataView).Table.DefaultView.Item(RowNumber - 1).Row.ItemArray
            Else
                'Get the content for the current row ....
            End If

            Dim RowBrush As Brush
            If ((RowNumber Mod 2) = 0) Then
                RowBrush = _OddRowBrush
            Else
                RowBrush = _EvenRowBrush
            End If
            Dim nColumn As Integer
            For nColumn = 0 To Items.Length - 1
                If _ColumnBounds(nColumn).Page = _CurrentPageAcross Then
                    Dim rcCell As New Rectangle(CInt(_ColumnBounds(nColumn).Left), CInt(Top), CInt(_ColumnBounds(nColumn).Width), CInt(Bottom - Top))
                    If rcCell.Width > 0 Then
                        Dim Columntext As String = ""
                        Try
                            Columntext = Convert.ToString(Items(MappedColumnToBaseColumn(nColumn)))
                        Catch
                        End Try
                        Call DrawCellString(Columntext, CellTextHorizontalAlignment.CentreAlign, CellTextVerticalAlignment.MiddleAlign, rcCell, True, e.Graphics, _PrintFont, RowBrush)
                    End If
                End If
            Next
        Catch exIndex As Exception
            Trace.WriteLine(exIndex.ToString, Me.GetType.ToString)
        End Try

    End Sub

    Private Sub PrintGridHeaderLine(ByVal e As System.Drawing.Printing.PrintPageEventArgs)

        Dim Top As Double = _PageContentRectangle.Top
        Dim Bottom As Double = Top + _Rowheight + (2 * _CellGutter)

        Top = RoundTo(Top, 2)
        Bottom = RoundTo(Bottom, 2)

        Dim nColumn As Integer

        For nColumn = 0 To GridColumnCount() - 1
            If _ColumnBounds(nColumn).Page = _CurrentPageAcross Then
                Dim rcCell As New Rectangle(CInt(_ColumnBounds(nColumn).Left), CInt(Top), CInt(_ColumnBounds(nColumn).Width), CInt(Bottom - Top))
                If rcCell.Width > 0 Then
                    Call DrawCellString(GetColumnHeadingText(nColumn), CellTextHorizontalAlignment.CentreAlign, CellTextVerticalAlignment.MiddleAlign, rcCell, True, e.Graphics, _PrintFont, _ColumnHeaderBrush)
                End If
            End If
        Next


    End Sub

    Private Function RowsPerPage(ByVal GridLineFont As Font, ByVal e As Graphics) As Integer

        Return CInt((_PageContentRectangle.Height / ((_CellGutter * 2) + _Rowheight)) - 2)

    End Function

    Public Sub DrawCellString(ByVal s As String, _
                                    ByVal HorizontalAlignment As CellTextHorizontalAlignment, _
                                    ByVal VerticalAlignment As CellTextVerticalAlignment, _
                                    ByVal BoundingRect As Rectangle, _
                                    ByVal DrawRectangle As Boolean, _
                                    ByVal Target As Graphics, _
                                    ByVal PrintFont As Font, _
                                    ByVal FillColour As Brush)


        'Dim x As Single, y As Single

        If DrawRectangle Then
            Target.FillRectangle(FillColour, BoundingRect)
            Target.DrawRectangle(_GridPen, BoundingRect)
        End If

        '\\ Set the text alignment
        If HorizontalAlignment = CellTextHorizontalAlignment.LeftAlign Then
            _Textlayout.Alignment = StringAlignment.Near
        ElseIf HorizontalAlignment = CellTextHorizontalAlignment.RightAlign Then
            _Textlayout.Alignment = StringAlignment.Far
        Else
            _Textlayout.Alignment = StringAlignment.Center
        End If

        Dim BoundingRectF As New RectangleF(BoundingRect.X + _CellGutter, BoundingRect.Y + _CellGutter, BoundingRect.Width - (2 * _CellGutter), BoundingRect.Height - (2 * _CellGutter))

        Target.DrawString(s, PrintFont, System.Drawing.Brushes.Black, BoundingRectF, _Textlayout)

    End Sub

    '\\ --[RoundTo]-----------------------------------------------------------------------------
    '\\ Rounds the input number tot he nearest modulus of NearsetMultiple
    '\\ ----------------------------------------------------------------------------------------
    Private Function RoundTo(ByVal Input As Double, ByVal NearestMultiple As Integer) As Integer

        If ((Input Mod NearestMultiple) > (NearestMultiple / 2)) Then
            Return ((CInt(Input) \ NearestMultiple) * NearestMultiple) + NearestMultiple
        Else
            Return (CInt(Input) \ NearestMultiple) * NearestMultiple
        End If

    End Function

    '\\ --[Min]------------------------------------------------------------
    '\\ Returns the minimum of two numbers
    '\\ -------------------------------------------------------------------
    Private Function Min(ByVal a As Integer, ByVal b As Integer) As Integer
        If a < b Then
            Return a
        Else
            Return b
        End If
    End Function

    Private Function GridColumnCount() As Integer

        If _GridColumnCount = 0 Then
            If TypeOf _DataGrid.DataSource Is DataTable Then
                _GridColumnCount = CType(_DataGrid.DataSource, DataTable).Columns.Count
            ElseIf TypeOf _DataGrid.DataSource Is DataSet Then
                _GridColumnCount = CType(_DataGrid.DataSource, DataSet).Tables(_DataGrid.DataMember).Columns.Count
            ElseIf TypeOf _DataGrid.DataSource Is DataView Then
                _GridColumnCount = CType(_DataGrid.DataSource, DataView).Table.Columns.Count
            Else
                'Get the column count....
            End If
        End If
        Return _GridColumnCount

    End Function

    Private Function GridRowCount() As Integer

        If _GridRowCount = 0 Then
            If TypeOf _DataGrid.DataSource Is DataTable Then
                _GridRowCount = CType(_DataGrid.DataSource, DataTable).DefaultView.Count
            ElseIf TypeOf _DataGrid.DataSource Is DataSet Then
                _GridRowCount = CType(_DataGrid.DataSource, DataSet).Tables(_DataGrid.DataMember).DefaultView.Count
            ElseIf TypeOf _DataGrid.DataSource Is DataView Then
                _GridRowCount = CType(_DataGrid.DataSource, DataView).Table.DefaultView.Count
            Else
                'Get the column count....
            End If
        End If
        Return _GridRowCount

    End Function

    Private Function GetColumnHeadingText(ByVal Column As Integer) As String
        Dim sAns As String = ""
        If _DataGrid.TableStyles.Count > 0 Then
            'Return _DataGrid.TableStyles(_DataGrid.TableStyles.Count - 1).GridColumnStyles(Column).HeaderText
            sAns = _DataGrid.TableStyles(_DataGrid.TableStyles.Count - 1).GridColumnStyles(Column).HeaderText
        Else
            If TypeOf _DataGrid.DataSource Is DataTable Then
                'Return CType(_DataGrid.DataSource, DataTable).Columns(Column).Caption
                sAns = CType(_DataGrid.DataSource, DataTable).Columns(Column).Caption
            ElseIf TypeOf _DataGrid.DataSource Is DataSet Then
                'Return CType(_DataGrid.DataSource, DataSet).Tables(0).Columns(Column).Caption
                sAns = CType(_DataGrid.DataSource, DataSet).Tables(0).Columns(Column).Caption
            ElseIf TypeOf _DataGrid.DataSource Is DataView Then
                'Return CType(_DataGrid.DataSource, DataView).Table.Columns(Column).Caption
                sAns = CType(_DataGrid.DataSource, DataView).Table.Columns(Column).Caption
            End If
        End If
        Return sAns
    End Function

    Private Function MappedColumnToBaseColumn(ByVal MappedColumn As Integer) As Integer

        If _DataGrid.TableStyles.Count <= 1 Then
            Return MappedColumn
        Else
            '\\ Need to map from the column in the default to the column in the active map..
            Return _DataGrid.TableStyles(0).GridColumnStyles.IndexOf(_DataGrid.TableStyles(_DataGrid.TableStyles.Count - 1).GridColumnStyles(MappedColumn))
        End If

    End Function

#End Region

#Region "Public constructors"

    Public Sub New(ByVal Grid As DataGrid)
        '\\ Initialize the bits we need to use later
        _GridPrintDocument = New PrintDocument
        _DataGrid = Grid

        Dim LoggedInuser As New WindowsPrincipal(WindowsIdentity.GetCurrent())

        _LoggedInUsername = DataGridPrinter.StripDomainFromFullUsername(WindowsIdentity.GetCurrent.Name)

    End Sub
#End Region

End Class
#End Region

#Region "ColumnBound"
Public Class ColumnBound

#Region "Private properties"
    Private _Page As Integer = 1
    Private _Left As Double
    Private _Width As Double
#End Region

#Region "Public interface"
    Public Property Left() As Double
        Get
            Return _Left
        End Get
        Set(ByVal value As Double)
            If value < 0 Then
                Throw New ArgumentException("Left must be greater than zero")
            End If
            _Left = value
        End Set
    End Property

    Public Property Width() As Double
        Get
            Return _Width
        End Get
        Set(ByVal Value As Double)
            If Value < 0 Then
                Throw New ArgumentException("Width must be greater than zero")
            End If
            _Width = Value
        End Set
    End Property

    Public Property Page() As Integer
        Get
            Return _Page
        End Get
        Set(ByVal Value As Integer)
            If Value < 1 Then
                Throw New ArgumentOutOfRangeException("Page", "Must be greater than zero")
            End If
            _Page = Value
        End Set
    End Property
#End Region

End Class
#End Region
#Region "ColumnBounds"
'\\ Type safe collection of "ColumnBound" objects
Public Class ColumnBounds
    Inherits System.Collections.ArrayList

#Region "Private properties"
    Private _CurrentPage As Integer = 1
    Private _RightExtents As Integer '\\ How far right does this column set reach?
#End Region

#Region "ArrayList overrides"
    Public Overloads Function Add(ByVal ColumnBound As ColumnBound) As Integer
        If ColumnBound.Left + ColumnBound.Width > _RightExtents Then
            _RightExtents = CInt(ColumnBound.Left) + CInt(ColumnBound.Width)
        End If
        ColumnBound.Page = _CurrentPage
        Return MyBase.Add(ColumnBound)
    End Function

    Public Overloads Sub Clear()
        _CurrentPage = 1
        _RightExtents = 0
        MyBase.Clear()
    End Sub

    Public Sub NextPage()
        _CurrentPage += 1
        _RightExtents = 0
    End Sub

    Friend ReadOnly Property TotalPages() As Integer
        Get
            Return _CurrentPage
        End Get
    End Property

    Default Public Shadows Property Item(ByVal Index As Integer) As ColumnBound
        Get
            Return CType(MyBase.Item(Index), ColumnBound)
        End Get
        Set(ByVal Value As ColumnBound)
            MyBase.Item(Index) = Value
        End Set
    End Property
#End Region

#Region "Public interface"
    Public ReadOnly Property RightExtents() As Integer
        Get
            Return _RightExtents
        End Get
    End Property
#End Region

End Class
#End Region