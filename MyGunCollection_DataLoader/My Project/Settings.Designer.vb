﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.296
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System.CodeDom.Compiler
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Configuration
Imports System.Runtime.CompilerServices

Namespace My
    
    <CompilerGenerated(),  _
     GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0"),  _
     EditorBrowsable(EditorBrowsableState.Advanced)>  _
    Partial Friend NotInheritable Class MySettings
        Inherits ApplicationSettingsBase
        
        Private Shared defaultInstance As MySettings = CType(Synchronized(New MySettings()),MySettings)
        
#Region "My.Settings Auto-Save Functionality"
#If _MyType = "WindowsForms" Then
    Private Shared addedHandler As Boolean

    Private Shared addedHandlerLockObject As New Object

    <DebuggerNonUserCode(), EditorBrowsable(EditorBrowsableState.Advanced)> _
    Private Shared Sub AutoSaveSettings(ByVal sender As Object, ByVal e As EventArgs)
        If Application.SaveMySettingsOnExit Then
            Settings.Save()
        End If
    End Sub
#End If
#End Region
        
        Public Shared ReadOnly Property [Default]() As MySettings
            Get
                
#If _MyType = "WindowsForms" Then
               If Not addedHandler Then
                    SyncLock addedHandlerLockObject
                        If Not addedHandler Then
                            AddHandler Application.Shutdown, AddressOf AutoSaveSettings
                            addedHandler = True
                        End If
                    End SyncLock
                End If
#End If
                Return defaultInstance
            End Get
        End Property
        
        <ApplicationScopedSetting(),  _
         DebuggerNonUserCode(),  _
         SpecialSetting(SpecialSetting.WebServiceUrl),  _
         DefaultSettingValue("http://www.burnsoft.net/services/bsmgc.asmx")>  _
        Public ReadOnly Property MyGunCollection_DataLoader_Database_Updates_My_x0020_Gun_x0020_Collection_x0020_Database_x0020_Update() As String
            Get
                Return CType(Me("MyGunCollection_DataLoader_Database_Updates_My_x0020_Gun_x0020_Collection_x0020_Database_x0020_Update"),String)
            End Get
        End Property
        
        <ApplicationScopedSetting(),  _
         DebuggerNonUserCode(),  _
         DefaultSettingValue("http://www.burnsoft.net/services/bsmgc.asmx")>  _
        Public ReadOnly Property MyGunCollection_DataLoader_Database_Updates() As String
            Get
                Return CType(Me("MyGunCollection_DataLoader_Database_Updates"),String)
            End Get
        End Property
    End Class
End Namespace

Namespace My
    
    <HideModuleName(),  _
     DebuggerNonUserCode(),  _
     CompilerGenerated()>  _
    Friend Module MySettingsProperty
        
        <HelpKeyword("My.Settings")>  _
        Friend ReadOnly Property Settings() As MySettings
            Get
                Return MySettings.Default
            End Get
        End Property
    End Module
End Namespace
