﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports Microsoft.VisualBasic.ApplicationServices

Namespace My
    
    'NOTE: This file is auto-generated; do not modify it directly.  To make changes,
    ' or if you encounter build errors in this file, go to the Project Designer
    ' (go to Project Properties or double-click the My Project node in
    ' Solution Explorer), and make changes on the Application tab.
    '
    Partial Friend Class MyApplication
        
        <DebuggerStepThrough()>  _
        Public Sub New()
            MyBase.New(AuthenticationMode.Windows)
            Me.IsSingleInstance = false
            Me.EnableVisualStyles = true
            Me.SaveMySettingsOnExit = true
            Me.ShutDownStyle = ShutdownMode.AfterAllFormsClose
        End Sub
        
        <DebuggerStepThrough()>  _
        Protected Overrides Sub OnCreateMainForm()
            Me.MainForm = BSMyGunCollection.MDIParent1
        End Sub
        
        <DebuggerStepThrough()>  _
        Protected Overrides Sub OnCreateSplashScreen()
            Me.SplashScreen = BSMyGunCollection.SplashScreen1
        End Sub
    End Class
End Namespace
