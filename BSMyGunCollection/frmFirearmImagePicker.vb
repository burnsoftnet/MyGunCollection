﻿Imports System.IO
'Imports System.Data.Odbc
Imports BSMyGunCollection.MGC
Imports BurnSoft.Applications.MGC
Imports BurnSoft.Applications.MGC.Firearms
Imports BurnSoft.Applications.MGC.Types

''' <summary>
''' Class FrmFirearmImagePicker.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class FrmFirearmImagePicker
    ''' <summary>
    ''' The pic array
    ''' </summary>
    Dim _picArray As ArrayList
    ''' <summary>
    ''' The firearm identifier array
    ''' </summary>
    Dim _firearmIdArray As ArrayList
    ''' <summary>
    ''' The firearm name array
    ''' </summary>
    Dim _firearmNameArray As ArrayList
    ''' <summary>
    ''' The left button index
    ''' </summary>
    Dim _leftbuttonIndex As Long
    ''' <summary>
    ''' The right button index
    ''' </summary>
    Dim _rightButtonIndex As Long
    ''' <summary>
    ''' The current index
    ''' </summary>
    Dim _currentIndex As Long
    ''' <summary>
    ''' The maximum items
    ''' </summary>
    Dim _maxItems As Long
    ''' <summary>
    ''' The error out
    ''' </summary>
    Dim _errOut As String

    ''' <summary>
    ''' Gets the picture. Get the image from the database based on the Picture ID
    ''' </summary>
    ''' <param name="picit">The pict.</param>
    Sub GetPicture(picit As Long)
        Try

            Dim b() As Byte = Pictures.GetPicture(DatabasePath, picit, _errOut)
            If (b.Length > 0) Then
                Dim stream As New MemoryStream(b, True)
                stream.Write(b, 0, b.Length)
                Dim bmp As Image = New Bitmap(stream)
                Dim imgSize As Size
                imgSize = Pictures.ProportionalSize(bmp.Size, PictureBox1.Size)
                Dim newimg As New Bitmap(imgSize.Width, imgSize.Height)
                Dim g As Graphics
                g = Graphics.FromImage(newimg)
                g.DrawImage(bmp, 0, 0, imgSize.Width, imgSize.Height)
                PictureBox1.Image = newimg
                PictureBox1.Refresh()
                Refresh()
                stream.Close()
            End If
        Catch ex As Exception
            Call LogError(Name,  "GetPicture", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Loads the arrays. Initialize the arrays and load them with information from the database
    '''  Load the Picture ID's in one Array, the Firearm ID in another array
    ''' and the Full Name in the last array
    ''' </summary>
    Sub LoadArrays()
        Try
            _picArray = New ArrayList
            _firearmIdArray = New ArrayList
            _firearmNameArray = New ArrayList

            Dim lst As List(Of PictureDisplayList) = PictureDisplay.GetList(DatabasePath, _errOut)

            For Each o As PictureDisplayList In lst
                _picArray.Add(o.Id)
                _firearmIdArray.Add(o.Cid)
                _firearmNameArray.Add(o.FullName)
                _maxItems += 1
            Next
        Catch ex As Exception
            Call LogError(Name, "LoadArrays", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Updates the indexes. Update the indexes for what to display now, and load the button for what was last and what is next
    ''' </summary>
    ''' <param name="indexClicked">The index clicked.</param>
    Sub UpdateIndexes(indexClicked As Long)
        If indexClicked = 0 Then
            _currentIndex = 0
            _leftbuttonIndex = 0
            btnLeft.Enabled = False
            _rightButtonIndex = 1
        ElseIf indexClicked >= (_maxItems - 1) Then
            btnRight.Enabled = False
            _currentIndex = indexClicked
            _leftbuttonIndex = _currentIndex - 1
        Else
            _currentIndex = indexClicked
            _rightButtonIndex = _currentIndex + 1
            _leftbuttonIndex = _currentIndex - 1
            btnLeft.Enabled = True
            btnRight.Enabled = True
        End If
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        Call GetPicture(_picArray(_currentIndex))
        txtName.Text = _firearmNameArray(_currentIndex)
    End Sub
    ''' <summary>
    ''' Handles the Disposed event of the frmFirearmImagePicker control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub frmFirearmImagePicker_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        Dim objVs As New ViewSizeSettings
        objVs.SaveViewPicture(Height, Width, Location.X, Location.Y)
    End Sub
    ''' <summary>
    ''' Handles the KeyDown event of the frmFirearmImagePicker control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="KeyEventArgs"/> instance containing the event data.</param>
    Private Sub frmFirearmImagePicker_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Right
                Call UpdateIndexes(_rightButtonIndex)
            Case Keys.Left
                Call UpdateIndexes(_leftbuttonIndex)
            Case Keys.Up
                Call UpdateIndexes(_rightButtonIndex)
            Case Keys.Down
                Call UpdateIndexes(_leftbuttonIndex)
        End Select
    End Sub
    ''' <summary>
    ''' Handles the KeyPress event of the frmFirearmImagePicker control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="KeyPressEventArgs"/> instance containing the event data.</param>
    Private Sub frmFirearmImagePicker_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        Select Case e.Handled
            Case Keys.Right
                Call UpdateIndexes(_rightButtonIndex)
            Case Keys.Left
                Call UpdateIndexes(_leftbuttonIndex)
            Case Keys.Up
                Call UpdateIndexes(_rightButtonIndex)
            Case Keys.Down
                Call UpdateIndexes(_leftbuttonIndex)
        End Select
    End Sub
    ''' <summary>
    ''' Handles the Load event of the frmFirearmImagePicker control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub frmFirearmImagePicker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            KeyPreview = True
            _maxItems = 0
            Dim objVs As New ViewSizeSettings
            objVs.LoadViewViewPicture(Height, Width, Location)
            Call LoadArrays()
            Call UpdateIndexes(0)
            Call GetPicture(_picArray(_currentIndex))
            Call SizeForm()
        Catch ex As Exception
            Call LogError(Name, "frmFirearmImagePicker_Load", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Click event of the btnRight control. when the right button ( > ) is clicked
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub btnRight_Click(sender As Object, e As EventArgs) Handles btnRight.Click
        Call UpdateIndexes(_rightButtonIndex)
    End Sub
    ''' <summary>
    ''' Handles the Click event of the btnLeft control. when the left button is clicked
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub btnLeft_Click(sender As Object, e As EventArgs) Handles btnLeft.Click
        Call UpdateIndexes(_leftbuttonIndex)
    End Sub
    ''' <summary>
    ''' Handles the Click event of the PictureBox1 control. Show the firearm details when the user click on the picture
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim frmNew As New frmViewCollectionDetails
        frmNew.GunId = _firearmIdArray(_currentIndex)
        frmNew.MdiParent = MdiParent
        frmNew.Show()
    End Sub
    ''' <summary>
    ''' Sizes the form. Resize the form and the components to fill the work space of the mdi parent.
    ''' </summary>
    Sub SizeForm()
        Dim workspaceWidth As Double = MdiParent.Size.Width - MDIParent1.Panel1.Size.Width - 30
        Dim workspaceHeight As Double = MdiParent.Size.Height - 145
        Width = workspaceWidth
        Height = workspaceHeight
        txtName.Width = workspaceWidth - 120
        btnLeft.Height = workspaceHeight
        btnRight.Height = workspaceHeight
        PictureBox1.Height = workspaceHeight - 70
        PictureBox1.Width = workspaceWidth - 40
        btnRight.Location = New Point(workspaceWidth - 40, btnLeft.Location.Y)
    End Sub
End Class