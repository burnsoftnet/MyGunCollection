Imports System.Drawing.Printing
Imports System.Security.Principal
' ReSharper disable once UnusedParameter.Local

#Region "DataGridPrinter"
''' <summary>
''' Provides a way to print a nicely formatted page from a data grid control
''' </summary>
Public Class DataGridPrinter
#Region "Private enumerated types"
    ''' <summary>
    ''' Enum CellTextHorizontalAlignment
    ''' </summary>
    Public Enum CellTextHorizontalAlignment
        LeftAlign = 1
        CentreAlign = 2
        RightAlign = 3
    End Enum
    ''' <summary>
    ''' Enum CellTextVerticalAlignment
    ''' </summary>
    Public Enum CellTextVerticalAlignment
' ReSharper disable once UnusedMember.Global
        TopAlign = 1
        MiddleAlign = 2
        BottomAlign = 3
    End Enum
#End Region
#Region "Private properties"
    ''' <summary>
    ''' The grid print document
    ''' </summary>
    Private WithEvents _gridPrintDocument As PrintDocument
    ''' <summary>
    ''' The data grid
    ''' </summary>
    Private _dataGrid As DataGrid
    ''' <summary>
    ''' The current print grid line
    ''' </summary>
    Private _currentPrintGridLine As Integer
    ''' <summary>
    ''' The current page down
    ''' </summary>
    Private _currentPageDown As Integer
    ''' <summary>
    ''' The current page across
    ''' </summary>
    Private _currentPageAcross As Integer = 1
    ''' <summary>
    ''' Fonts to use to do the printing... 
    ''' </summary>
    Private _printFont As New Font(FontFamily.GenericSansSerif, 9)
    ''' <summary>
    ''' The header font
    ''' </summary>
    Private _headerFont As New Font(FontFamily.GenericSansSerif, 12)
    ''' <summary>
    ''' The footer font
    ''' </summary>
    Private _footerFont As New Font(FontFamily.GenericSansSerif, 10)
    ''' <summary>
    ''' The header rectangle
    ''' </summary>
    Private _headerRectangle As Rectangle
    ''' <summary>
    ''' The footer rectangle
    ''' </summary>
    Private _footerRectangle As Rectangle
    ''' <summary>
    ''' The page content rectangle
    ''' </summary>
    Private _pageContentRectangle As Rectangle
    ''' <summary>
    ''' The row height
    ''' </summary>
    Private _rowheight As Double
    ''' <summary>
    ''' Column widths related 
    ''' </summary>
    Private _pagesAcross As Integer = 1
    ' ReSharper disable once FieldCanBeMadeReadOnly.Local    
    ''' <summary>
    ''' The column bounds
    ''' </summary>
    Private _columnBounds As New ColumnBounds
    ''' <summary>
    ''' The text layout
    ''' </summary>
    Private _textlayout As StringFormat
    ''' <summary>
    ''' The footer height percent
    ''' </summary>
    Private _footerHeightPercent As Integer = 3
    ''' <summary>
    ''' The header height percent
    ''' </summary>
    Private _headerHeightPercent As Integer = 7
    ''' <summary>
    ''' The inter section spacing percent
    ''' </summary>
    Private _interSectionSpacingPercent As Integer = 2
    ''' <summary>
    ''' The cell gutter
    ''' </summary>
    Private _cellGutter As Integer = 5
    ''' <summary>
    ''' Pens to draw the sections with
    ''' </summary>
    Private _footerPen As New Pen(Color.Green)
    ''' <summary>
    ''' The header pen
    ''' </summary>
    Private _headerPen As New Pen(Color.RoyalBlue)
    ''' <summary>
    ''' The grid pen
    ''' </summary>
    Private _gridPen As New Pen(Color.Black)
    ''' <summary>
    ''' Brushes to fill the sections with
    ''' </summary>
    Private _headerBrush As Brush = Brushes.White
    ''' <summary>
    ''' The footer brush
    ''' </summary>
    Private _footerBrush As Brush = Brushes.White
    ''' <summary>
    ''' The column header brush
    ''' </summary>
    Private _columnHeaderBrush As Brush = Brushes.White
    ''' <summary>
    ''' The odd row brush
    ''' </summary>
    Private _oddRowBrush As Brush = Brushes.White
    ''' <summary>
    ''' The even row brush
    ''' </summary>
    Private _evenRowBrush As Brush = Brushes.White
    ''' <summary>
    ''' The header text
    ''' </summary>
    Private _headerText As String
    ''' <summary>
    ''' The logged in username
    ''' </summary>
' ReSharper disable once FieldCanBeMadeReadOnly.Local
    Private _loggedInUsername As String
    ''' <summary>
    ''' The grid row count
    ''' </summary>
    Private _gridRowCount As Integer
    ''' <summary>
    ''' The grid column count
    ''' </summary>
    Private _gridColumnCount As Integer
#End Region
#Region "Public interface"
#Region "Properties"
#Region "PagesAcross"
    ''' <summary>
    ''' Gets or sets the pages across.
    ''' </summary>
    ''' <value>The pages across.</value>
    ''' <exception cref="ArgumentOutOfRangeException">PagesAcross - Must be one or more pages across</exception>
    Public Property PagesAcross() As Integer
        Get
            Return _pagesAcross
        End Get
        Set(ByVal value As Integer)
            If value < 1 Then
                Throw New ArgumentOutOfRangeException($"PagesAcross", $"Must be one or more pages across")
            End If
            _pagesAcross = value
        End Set
    End Property
#End Region
#Region "FooterHeightPercent"
    ''' <summary>
    ''' Gets or sets the footer height percent.
    ''' </summary>
    ''' <value>The footer height percent.</value>
    ''' <exception cref="ArgumentException">FooterHeightPercent must be between 0 and 30</exception>
    Public Property FooterHeightPercent() As Integer
        Get
            Return _footerHeightPercent
        End Get
        Set(ByVal value As Integer)
            If value < 0 OrElse value >= 30 Then
                Throw New ArgumentException("FooterHeightPercent must be between 0 and 30")
            End If
            _footerHeightPercent = value
        End Set
    End Property
#End Region
#Region "HeaderHeightPercent"
    ''' <summary>
    ''' Gets or sets the header height percent.
    ''' </summary>
    ''' <value>The header height percent.</value>
    ''' <exception cref="ArgumentException">HeaderHeightPercent must be between 0 and 30</exception>
    Public Property HeaderHeightPercent() As Integer
        Get
            Return _headerHeightPercent
        End Get
        Set(ByVal value As Integer)
            If value < 0 OrElse value >= 30 Then
                Throw New ArgumentException("HeaderHeightPercent must be between 0 and 30")
            End If
            _headerHeightPercent = value
        End Set
    End Property
#End Region
#Region "InterSectionSpacingPercent"
    ''' <summary>
    ''' Gets or sets the inter section spacing percent.
    ''' </summary>
    ''' <value>The inter section spacing percent.</value>
    ''' <exception cref="ArgumentException">InterSectionSpacingPercent must be between 0 and 20</exception>
    Public Property InterSectionSpacingPercent() As Integer
        Get
            Return _interSectionSpacingPercent
        End Get
        Set(ByVal value As Integer)
            If value < 0 OrElse value >= 20 Then
                Throw New ArgumentException("InterSectionSpacingPercent must be between 0 and 20")
            End If
            _interSectionSpacingPercent = value
        End Set
    End Property
#End Region

#Region "CellGutter"
    ''' <summary>
    ''' Gets or sets the cell gutter.
    ''' </summary>
    ''' <value>The cell gutter.</value>
    ''' <exception cref="ArgumentException">CellGutter must be between 0 and 10</exception>
    Public Property CellGutter() As Integer
        Get
            Return _cellGutter
        End Get
        Set(ByVal value As Integer)
            If value < 0 OrElse value >= 10 Then
                Throw New ArgumentException("CellGutter must be between 0 and 10")
            End If
            _cellGutter = value
        End Set
    End Property
#End Region

#Region "HeaderFont"
    ''' <summary>
    ''' Gets or sets the header font.
    ''' </summary>
    ''' <value>The header font.</value>
    Public Property HeaderFont() As Font
        Get
            Return _headerFont
        End Get
        Set(ByVal value As Font)
            '\\ Possible font size validation here..
            _headerFont = value
        End Set
    End Property
#End Region
#Region "PrintFont"
    ''' <summary>
    ''' Gets or sets the print font.
    ''' </summary>
    ''' <value>The print font.</value>
    Public Property PrintFont() As Font
        Get
            Return _printFont
        End Get
        Set(ByVal value As Font)
            '\\ Possible font size validation here
            _printFont = value
        End Set
    End Property
#End Region
#Region "FooterFont"
    ''' <summary>
    ''' Gets or sets the footer font.
    ''' </summary>
    ''' <value>The footer font.</value>
    Public Property FooterFont() As Font
        Get
            Return _footerFont
        End Get
        Set(ByVal value As Font)
            '\\ Possible font size validation here
            _footerFont = value
        End Set
    End Property
#End Region

#Region "HeaderText"
    ''' <summary>
    ''' Gets or sets the header text.
    ''' </summary>
    ''' <value>The header text.</value>
    Public Property HeaderText() As String
        Get
            Return _headerText
        End Get
        Set(ByVal value As String)
            _headerText = value
        End Set
    End Property
#End Region

#Region "HeaderPen"
    ''' <summary>
    ''' Gets or sets the header pen.
    ''' </summary>
    ''' <value>The header pen.</value>
    Public Property HeaderPen() As Pen
        Get
            Return _headerPen
        End Get
        Set(ByVal value As Pen)
            _headerPen = value
        End Set
    End Property
#End Region
#Region "FooterPen"
    ''' <summary>
    ''' Gets or sets the footer pen.
    ''' </summary>
    ''' <value>The footer pen.</value>
    Public Property FooterPen() As Pen
        Get
            Return _footerPen
        End Get
        Set(ByVal value As Pen)
            _footerPen = value
        End Set
    End Property
#End Region
#Region "GridPen"
    ''' <summary>
    ''' Gets or sets the grid pen.
    ''' </summary>
    ''' <value>The grid pen.</value>
    Public Property GridPen() As Pen
        Get
            Return _gridPen
        End Get
        Set(ByVal value As Pen)
            _gridPen = value
        End Set
    End Property
#End Region

#Region "HeaderBrush"
    ''' <summary>
    ''' Gets or sets the header brush.
    ''' </summary>
    ''' <value>The header brush.</value>
    Public Property HeaderBrush() As Brush
        Get
            Return _headerBrush
        End Get
        Set(ByVal value As Brush)
            _headerBrush = value
        End Set
    End Property
#End Region
#Region "FooterBrush"
    ''' <summary>
    ''' Gets or sets the footer brush.
    ''' </summary>
    ''' <value>The footer brush.</value>
    Public Property FooterBrush() As Brush
        Get
            Return _footerBrush
        End Get
        Set(ByVal value As Brush)
            _footerBrush = value
        End Set
    End Property
#End Region
#Region "ColumnHeaderBrush"
    ''' <summary>
    ''' Gets or sets the column header brush.
    ''' </summary>
    ''' <value>The column header brush.</value>
    Public Property ColumnHeaderBrush() As Brush
        Get
            Return _columnHeaderBrush
        End Get
        Set(ByVal value As Brush)
            _columnHeaderBrush = value
        End Set
    End Property
#End Region
#Region "OddRowBrush"
    ''' <summary>
    ''' Gets or sets the odd row brush.
    ''' </summary>
    ''' <value>The odd row brush.</value>
    Public Property OddRowBrush() As Brush
        Get
            Return _oddRowBrush
        End Get
        Set(ByVal value As Brush)
            _oddRowBrush = value
        End Set
    End Property
#End Region
#Region "EvenRowBrush"
    ''' <summary>
    ''' Gets or sets the even row brush.
    ''' </summary>
    ''' <value>The even row brush.</value>
    Public Property EvenRowBrush() As Brush
        Get
            Return _evenRowBrush
        End Get
        Set(ByVal value As Brush)
            _evenRowBrush = value
        End Set
    End Property
#End Region

#Region "PrintDocument"
    ''' <summary>
    ''' Gets the print document.
    ''' </summary>
    ''' <value>The print document.</value>
    Public ReadOnly Property PrintDocument() As PrintDocument
        Get
            Return _gridPrintDocument
        End Get
    End Property
#End Region

#Region "DataGrid"
    ''' <summary>
    ''' Sets the data grid.
    ''' </summary>
    ''' <value>The data grid.</value>
    Public WriteOnly Property DataGrid() As DataGrid
        Set(ByVal value As DataGrid)
            _dataGrid = value
        End Set
    End Property
#End Region

#End Region

#Region "Methods"

#Region "Shared methods"
    '\\ --[StripDomainFromFullUsername]------------------------------------------------
    '\\ Returns just the username bit from a user name that includes a domain name
    '\\ e.g. "DEVELOPMENT\Duncan" -> "Duncan"
    '\\ (c) 2005 - Merrion Computing Ltd
    '\\ -------------------------------------------------------------------------------
    Public Shared Function StripDomainFromFullUsername(ByVal fullUsername As String) As String

' ReSharper disable once VBStringIndexOfIsCultureSpecific.1
        If fullUsername.IndexOf("\") = -1 Then
            Return fullUsername
        Else
            Dim sep() As Char = {Char.Parse("\")}
            Dim chaf() As String = fullUsername.Split(sep)
            Return (chaf(chaf.Length - 1))
        End If

    End Function
#End Region

#Region "Print"
    ''' <summary>
    ''' Prints this instance.
    ''' </summary>
    Public Sub Print()
        _gridPrintDocument.Print()
    End Sub
#End Region
#End Region


#End Region

#Region "_GridPrintDocument events"
    ''' <summary>
    ''' Handles the BeginPrint event of the _GridPrintDocument control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="PrintEventArgs"/> instance containing the event data.</param>
    Private Sub _GridPrintDocument_BeginPrint(ByVal sender As Object, ByVal e As PrintEventArgs) Handles _gridPrintDocument.BeginPrint

        '\\ Initialize the current page and current grid line variables
        _currentPrintGridLine = 1
        _currentPageDown = 1
        _currentPageAcross = 1

        If _textlayout Is Nothing Then
            _textlayout = New StringFormat
            _textlayout.Trimming = StringTrimming.EllipsisCharacter
        End If

    End Sub
    ''' <summary>
    ''' Handles the PrintPage event of the _GridPrintDocument control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="PrintPageEventArgs"/> instance containing the event data.</param>
    Private Sub _GridPrintDocument_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs) Handles _gridPrintDocument.PrintPage

        If _currentPageDown = 1 And _currentPageAcross = 1 Then
            ' _HeaderRectangle -  The top 10% of the page
            _headerRectangle = e.MarginBounds
            _headerRectangle.Height = CInt(e.MarginBounds.Height * _headerHeightPercent * 0.01)

            ' _FooterRectangle - the bottom 10% of the page
            _footerRectangle = e.MarginBounds
            _footerRectangle.Height = CInt(e.MarginBounds.Height * _footerHeightPercent * 0.01)
            _footerRectangle.Y += CInt(e.MarginBounds.Height * (1 - (0.01 * _footerHeightPercent)))

            ' _PageContentRectangle - The middle 80% of the page
            _pageContentRectangle = e.MarginBounds
            _pageContentRectangle.Y += CInt(_headerRectangle.Height + e.MarginBounds.Height * (_interSectionSpacingPercent * 0.01))
            _pageContentRectangle.Height = CInt(e.MarginBounds.Height * 0.8)

            _rowheight = e.Graphics.MeasureString("a", _printFont).Height

            '\\ Create the _ColumnBounds array
            Dim nColumn As Integer
            Dim totalWidth As Double

            If _dataGrid.DataSource Is Nothing Then
                '\\ Nothing in the grid to print
                Exit Sub
            End If

            Dim columnCount As Integer = GridColumnCount()

            For nColumn = 0 To columnCount - 1
                Dim rcLastCell As Rectangle = _dataGrid.GetCellBounds(0, nColumn)
                If rcLastCell.Width > 0 Then
                    totalWidth += rcLastCell.Width
                End If
            Next

            _columnBounds.Clear()
            For nColumn = 0 To columnCount - 1
                '\\ Calculate the column start point
                Dim nextColumn As New ColumnBound
                If nColumn = 0 Then
                    nextColumn.Left = e.MarginBounds.Left
                Else
                    nextColumn.Left = _columnBounds.RightExtents
                End If
                '\\ Set this column's width
                Dim rcCell As Rectangle = _dataGrid.GetCellBounds(0, nColumn)
                If rcCell.Width > 0 Then
                    nextColumn.Width = (rcCell.Width / totalWidth) * (e.MarginBounds.Width * PagesAcross)
                    If nextColumn.Width > e.MarginBounds.Width Then
                        nextColumn.Width = e.MarginBounds.Width
                    End If
                End If
                If _columnBounds.RightExtents + nextColumn.Width > e.MarginBounds.Width Then
                    _columnBounds.NextPage()
                    nextColumn.Left = e.MarginBounds.Left
                End If
                _columnBounds.Add(nextColumn)
            Next
            If _columnBounds.TotalPages > PagesAcross Then
                PagesAcross = _columnBounds.TotalPages
            End If
        End If

        '\\ Print the document header
        Call PrintHeader(e)

        '\\ Print as many grid lines as can fit
        Dim nextLine As Int32
        Call PrintGridHeaderLine(e)
        Dim startOfpage As Integer = _currentPrintGridLine
        'For nextLine = _CurrentPrintGridLine To Min((_CurrentPrintGridLine + RowsPerPage(_PrintFont, e.Graphics)), CType(_DataGrid.DataSource, System.Data.DataTable).DefaultView.Count)
        For nextLine = _currentPrintGridLine To Min((_currentPrintGridLine + RowsPerPage(_printFont, e.Graphics)), CType(_dataGrid.DataSource, DataTable).DefaultView.Count)
            Call PrintGridLine(e, nextLine)
        Next
        _currentPrintGridLine = nextLine

        '\\ Print the document footer
        Call PrintFooter(e)

        If _currentPageAcross = PagesAcross Then
            _currentPageAcross = 1
            _currentPageDown += 1
        Else
            _currentPageAcross += 1
            _currentPrintGridLine = startOfpage
        End If

        '\\ If there are more lines to print, set the HasMorePages property to true
        If _currentPrintGridLine < GridRowCount() Then
            e.HasMorePages = True
        End If

    End Sub
#End Region

#Region "Private methods"
    ''' <summary>
    ''' Prints the header.
    ''' </summary>
    ''' <param name="e">The <see cref="PrintPageEventArgs"/> instance containing the event data.</param>
    Private Sub PrintHeader(ByVal e As PrintPageEventArgs)

        If _headerRectangle.Height > 0 Then
            e.Graphics.FillRectangle(_headerBrush, _headerRectangle)
            e.Graphics.DrawRectangle(_headerPen, _headerRectangle)
            Call DrawCellString(_headerText, CellTextHorizontalAlignment.CentreAlign, CellTextVerticalAlignment.MiddleAlign, _headerRectangle, False, e.Graphics, _headerFont, _headerBrush)
        End If

    End Sub
    ''' <summary>
    ''' Prints the footer.
    ''' </summary>
    ''' <param name="e">The <see cref="PrintPageEventArgs"/> instance containing the event data.</param>
    Private Sub PrintFooter(ByVal e As PrintPageEventArgs)

        If _footerRectangle.Height > 0 Then
            e.Graphics.FillRectangle(_footerBrush, _footerRectangle)
            e.Graphics.DrawRectangle(_footerPen, _footerRectangle)
            Call DrawCellString("Printed by " & _loggedInUsername, CellTextHorizontalAlignment.LeftAlign, CellTextVerticalAlignment.MiddleAlign, _footerRectangle, False, e.Graphics, _printFont, Brushes.White)
            Call DrawCellString(DateTime.Now.ToLongDateString, CellTextHorizontalAlignment.CentreAlign, CellTextVerticalAlignment.MiddleAlign, _footerRectangle, False, e.Graphics, _printFont, Brushes.White)
            Call DrawCellString("Page " & (((_currentPageDown - 1) * PagesAcross) + _currentPageAcross).ToString, CellTextHorizontalAlignment.RightAlign, CellTextVerticalAlignment.MiddleAlign, _footerRectangle, False, e.Graphics, _printFont, Brushes.White)
        End If

    End Sub
    ''' <summary>
    ''' Prints the grid line.
    ''' </summary>
    ''' <param name="e">The <see cref="PrintPageEventArgs"/> instance containing the event data.</param>
    ''' <param name="rowNumber">The row number.</param>
    Private Sub PrintGridLine(ByVal e As PrintPageEventArgs, ByVal rowNumber As Integer)

        Dim rowFromTop As Integer = rowNumber + 1 - _currentPrintGridLine
        Dim top As Double = _pageContentRectangle.Top + (rowFromTop * ((_cellGutter * 2) + _rowheight))
        Dim bottom As Double = top + _rowheight + (2 * _cellGutter)

        top = RoundTo(top, 2)
        bottom = RoundTo(bottom, 2)

        Dim items() As Object = Nothing
        Try
            If TypeOf _dataGrid.DataSource Is DataTable Then
                items = CType(_dataGrid.DataSource, DataTable).DefaultView.Item(rowNumber - 1).Row.ItemArray
            ElseIf TypeOf _dataGrid.DataSource Is DataSet Then
                items = CType(_dataGrid.DataSource, DataSet).Tables(_dataGrid.DataMember).DefaultView.Item(rowNumber - 1).Row.ItemArray
            ElseIf TypeOf _dataGrid.DataSource Is DataView Then
                items = CType(_dataGrid.DataSource, DataView).Table.DefaultView.Item(rowNumber - 1).Row.ItemArray
            Else
                'Get the content for the current row ....
            End If

            Dim rowBrush As Brush
            If ((rowNumber Mod 2) = 0) Then
                rowBrush = _oddRowBrush
            Else
                rowBrush = _evenRowBrush
            End If
            Dim nColumn As Integer
            For nColumn = 0 To items.Length - 1
                If _columnBounds(nColumn).Page = _currentPageAcross Then
                    Dim rcCell As New Rectangle(CInt(_columnBounds(nColumn).Left), CInt(top), CInt(_columnBounds(nColumn).Width), CInt(bottom - top))
                    If rcCell.Width > 0 Then
                        Dim columntext As String = ""
                        Try
                            columntext = Convert.ToString(items(MappedColumnToBaseColumn(nColumn)))
                        Catch
                        End Try
                        Call DrawCellString(columntext, CellTextHorizontalAlignment.CentreAlign, CellTextVerticalAlignment.MiddleAlign, rcCell, True, e.Graphics, _printFont, rowBrush)
                    End If
                End If
            Next
        Catch exIndex As Exception
            Trace.WriteLine(exIndex.ToString, Me.GetType.ToString)
        End Try

    End Sub
    ''' <summary>
    ''' Prints the grid header line.
    ''' </summary>
    ''' <param name="e">The <see cref="PrintPageEventArgs"/> instance containing the event data.</param>
    Private Sub PrintGridHeaderLine(ByVal e As PrintPageEventArgs)

        Dim top As Double = _pageContentRectangle.Top
        Dim bottom As Double = top + _rowheight + (2 * _cellGutter)

        top = RoundTo(top, 2)
        bottom = RoundTo(bottom, 2)

        Dim nColumn As Integer

        For nColumn = 0 To GridColumnCount() - 1
            If _columnBounds(nColumn).Page = _currentPageAcross Then
                Dim rcCell As New Rectangle(CInt(_columnBounds(nColumn).Left), CInt(top), CInt(_columnBounds(nColumn).Width), CInt(bottom - top))
                If rcCell.Width > 0 Then
                    Call DrawCellString(GetColumnHeadingText(nColumn), CellTextHorizontalAlignment.CentreAlign, CellTextVerticalAlignment.MiddleAlign, rcCell, True, e.Graphics, _printFont, _columnHeaderBrush)
                End If
            End If
        Next


    End Sub
    ''' <summary>
    ''' Rows the per page.
    ''' </summary>
    ''' <param name="gridLineFont">The grid line font.</param>
    ''' <param name="e">The e.</param>
    ''' <returns>System.Int32.</returns>
    Private Function RowsPerPage(ByVal gridLineFont As Font, ByVal e As Graphics) As Integer

        Return CInt((_pageContentRectangle.Height / ((_cellGutter * 2) + _rowheight)) - 2)

    End Function
    ''' <summary>
    ''' Draws the cell string.
    ''' </summary>
    ''' <param name="s">The s.</param>
    ''' <param name="horizontalAlignment">The horizontal alignment.</param>
    ''' <param name="verticalAlignment">The vertical alignment.</param>
    ''' <param name="boundingRect">The bounding rect.</param>
    ''' <param name="drawRectangle">if set to <c>true</c> [draw rectangle].</param>
    ''' <param name="target">The target.</param>
    ''' <param name="printFont">The print font.</param>
    ''' <param name="fillColour">The fill colour.</param>
' ReSharper disable once ParameterHidesMember
' ReSharper disable once ParameterHidesMember
    Public Sub DrawCellString(ByVal s As String, _
                                    ByVal horizontalAlignment As CellTextHorizontalAlignment, _
                                    ByVal verticalAlignment As CellTextVerticalAlignment, _
                                    ByVal boundingRect As Rectangle, _
                                    ByVal drawRectangle As Boolean, _
                                    ByVal target As Graphics, _
                                    ByVal printFont As Font, _
                                    ByVal fillColour As Brush)


        'Dim x As Single, y As Single

        If drawRectangle Then
            target.FillRectangle(fillColour, boundingRect)
            target.DrawRectangle(_gridPen, boundingRect)
        End If

        '\\ Set the text alignment
        If horizontalAlignment = CellTextHorizontalAlignment.LeftAlign Then
            _textlayout.Alignment = StringAlignment.Near
        ElseIf horizontalAlignment = CellTextHorizontalAlignment.RightAlign Then
            _textlayout.Alignment = StringAlignment.Far
        Else
            _textlayout.Alignment = StringAlignment.Center
        End If

        Dim boundingRectF As New RectangleF(boundingRect.X + _cellGutter, boundingRect.Y + _cellGutter, boundingRect.Width - (2 * _cellGutter), boundingRect.Height - (2 * _cellGutter))

        target.DrawString(s, printFont, Brushes.Black, boundingRectF, _textlayout)

    End Sub

    '\\ --[RoundTo]-----------------------------------------------------------------------------
    '\\ Rounds the input number tot he nearest modulus of Nearest Multiple
    '\\ ----------------------------------------------------------------------------------------
    Private Function RoundTo(ByVal input As Double, ByVal nearestMultiple As Integer) As Integer

        If ((input Mod nearestMultiple) > (nearestMultiple / 2)) Then
            Return ((CInt(input) \ nearestMultiple) * nearestMultiple) + nearestMultiple
        Else
            Return (CInt(input) \ nearestMultiple) * nearestMultiple
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
    ''' <summary>
    ''' Grids the column count.
    ''' </summary>
    ''' <returns>System.Int32.</returns>
    Private Function GridColumnCount() As Integer

        If _gridColumnCount = 0 Then
            If TypeOf _dataGrid.DataSource Is DataTable Then
                _gridColumnCount = CType(_dataGrid.DataSource, DataTable).Columns.Count
            ElseIf TypeOf _dataGrid.DataSource Is DataSet Then
                _gridColumnCount = CType(_dataGrid.DataSource, DataSet).Tables(_dataGrid.DataMember).Columns.Count
            ElseIf TypeOf _dataGrid.DataSource Is DataView Then
                _gridColumnCount = CType(_dataGrid.DataSource, DataView).Table.Columns.Count
            Else
                'Get the column count....
            End If
        End If
        Return _gridColumnCount

    End Function
    ''' <summary>
    ''' Grids the row count.
    ''' </summary>
    ''' <returns>System.Int32.</returns>
    Private Function GridRowCount() As Integer

        If _gridRowCount = 0 Then
            If TypeOf _dataGrid.DataSource Is DataTable Then
                _gridRowCount = CType(_dataGrid.DataSource, DataTable).DefaultView.Count
            ElseIf TypeOf _dataGrid.DataSource Is DataSet Then
                _gridRowCount = CType(_dataGrid.DataSource, DataSet).Tables(_dataGrid.DataMember).DefaultView.Count
            ElseIf TypeOf _dataGrid.DataSource Is DataView Then
                _gridRowCount = CType(_dataGrid.DataSource, DataView).Table.DefaultView.Count
            Else
                'Get the column count....
            End If
        End If
        Return _gridRowCount

    End Function
    ''' <summary>
    ''' Gets the column heading text.
    ''' </summary>
    ''' <param name="column">The column.</param>
    ''' <returns>System.String.</returns>
    Private Function GetColumnHeadingText(ByVal column As Integer) As String
        Dim sAns As String = ""
        If _dataGrid.TableStyles.Count > 0 Then
            'Return _DataGrid.TableStyles(_DataGrid.TableStyles.Count - 1).GridColumnStyles(Column).HeaderText
            sAns = _dataGrid.TableStyles(_dataGrid.TableStyles.Count - 1).GridColumnStyles(column).HeaderText
        Else
            If TypeOf _dataGrid.DataSource Is DataTable Then
                'Return CType(_DataGrid.DataSource, DataTable).Columns(Column).Caption
                sAns = CType(_dataGrid.DataSource, DataTable).Columns(column).Caption
            ElseIf TypeOf _dataGrid.DataSource Is DataSet Then
                'Return CType(_DataGrid.DataSource, DataSet).Tables(0).Columns(Column).Caption
                sAns = CType(_dataGrid.DataSource, DataSet).Tables(0).Columns(column).Caption
            ElseIf TypeOf _dataGrid.DataSource Is DataView Then
                'Return CType(_DataGrid.DataSource, DataView).Table.Columns(Column).Caption
                sAns = CType(_dataGrid.DataSource, DataView).Table.Columns(column).Caption
            End If
        End If
        Return sAns
    End Function
    ''' <summary>
    ''' Mapped the column to base column.
    ''' </summary>
    ''' <param name="mappedColumn">The mapped column.</param>
    ''' <returns>System.Int32.</returns>
    Private Function MappedColumnToBaseColumn(ByVal mappedColumn As Integer) As Integer

        If _dataGrid.TableStyles.Count <= 1 Then
            Return mappedColumn
        Else
            '\\ Need to map from the column in the default to the column in the active map..
            Return _dataGrid.TableStyles(0).GridColumnStyles.IndexOf(_dataGrid.TableStyles(_dataGrid.TableStyles.Count - 1).GridColumnStyles(mappedColumn))
        End If

    End Function

#End Region

#Region "Public constructors"
    ''' <summary>
    ''' Initializes a new instance of the <see cref="DataGridPrinter"/> class.
    ''' </summary>
    ''' <param name="grid">The grid.</param>
    Public Sub New(ByVal grid As DataGrid)
        '\\ Initialize the bits we need to use later
        _gridPrintDocument = New PrintDocument
        _dataGrid = grid

        _loggedInUsername = StripDomainFromFullUsername(WindowsIdentity.GetCurrent.Name)

    End Sub
#End Region

End Class
#End Region

#Region "ColumnBound"
''' <summary>
''' Class ColumnBound.
''' </summary>
Public Class ColumnBound

#Region "Private properties"
    ''' <summary>
    ''' The page
    ''' </summary>
    Private _page As Integer = 1
    ''' <summary>
    ''' The left
    ''' </summary>
    Private _left As Double
    ''' <summary>
    ''' The width
    ''' </summary>
    Private _width As Double
#End Region

#Region "Public interface"
    ''' <summary>
    ''' Gets or sets the left.
    ''' </summary>
    ''' <value>The left.</value>
    ''' <exception cref="ArgumentException">Left must be greater than zero</exception>
    Public Property Left() As Double
        Get
            Return _left
        End Get
        Set(ByVal value As Double)
            If value < 0 Then
                Throw New ArgumentException("Left must be greater than zero")
            End If
            _left = value
        End Set
    End Property
    ''' <summary>
    ''' Gets or sets the width.
    ''' </summary>
    ''' <value>The width.</value>
    ''' <exception cref="ArgumentException">Width must be greater than zero</exception>
    Public Property Width() As Double
        Get
            Return _width
        End Get
        Set(ByVal value As Double)
            If value < 0 Then
                Throw New ArgumentException("Width must be greater than zero")
            End If
            _width = value
        End Set
    End Property
    ''' <summary>
    ''' Gets or sets the page.
    ''' </summary>
    ''' <value>The page.</value>
    ''' <exception cref="ArgumentOutOfRangeException">Page - Must be greater than zero</exception>
    Public Property Page() As Integer
        Get
            Return _page
        End Get
        Set(ByVal value As Integer)
            If value < 1 Then
                Throw New ArgumentOutOfRangeException($"Page", $"Must be greater than zero")
            End If
            _page = value
        End Set
    End Property
#End Region

End Class
#End Region
#Region "ColumnBounds"
'\\ Type safe collection of "ColumnBound" objects
Public Class ColumnBounds
    Inherits ArrayList

#Region "Private properties"
    ''' <summary>
    ''' The current page
    ''' </summary>
    Private _currentPage As Integer = 1
    ''' <summary>
    ''' The right extents
    ''' </summary>
    Private _rightExtents As Integer '\\ How far right does this column set reach?
#End Region

#Region "ArrayList overrides"
    ''' <summary>
    ''' Adds the specified column bound.
    ''' </summary>
    ''' <param name="columnBound">The column bound.</param>
    ''' <returns>System.Int32.</returns>
    Public Overloads Function Add(ByVal columnBound As ColumnBound) As Integer
        If columnBound.Left + columnBound.Width > _rightExtents Then
            _rightExtents = CInt(columnBound.Left) + CInt(columnBound.Width)
        End If
        columnBound.Page = _currentPage
        Return MyBase.Add(columnBound)
    End Function
    ''' <summary>
    ''' Removes all elements from the <see cref="T:System.Collections.ArrayList" />.
    ''' </summary>
    Public Overloads Sub Clear()
        _currentPage = 1
        _rightExtents = 0
        MyBase.Clear()
    End Sub
    ''' <summary>
    ''' Next the page.
    ''' </summary>
    Public Sub NextPage()
        _currentPage += 1
        _rightExtents = 0
    End Sub
    ''' <summary>
    ''' Gets the total pages.
    ''' </summary>
    ''' <value>The total pages.</value>
    Friend ReadOnly Property TotalPages() As Integer
        Get
            Return _currentPage
        End Get
    End Property
    ''' <summary>
    ''' Gets or sets the element at the specified index.
    ''' </summary>
    ''' <param name="index">The index.</param>
    ''' <value>The item.</value>
    Default Public Shadows Property Item(ByVal index As Integer) As ColumnBound
        Get
            Return CType(MyBase.Item(index), ColumnBound)
        End Get
        Set(ByVal value As ColumnBound)
            MyBase.Item(index) = value
        End Set
    End Property
#End Region

#Region "Public interface"
    ''' <summary>
    ''' Gets the right extents.
    ''' </summary>
    ''' <value>The right extents.</value>
    Public ReadOnly Property RightExtents() As Integer
        Get
            Return _rightExtents
        End Get
    End Property
#End Region

End Class
#End Region