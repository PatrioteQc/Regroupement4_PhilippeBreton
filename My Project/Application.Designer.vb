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


Namespace My
    
    'REMARQUE : Ce fichier étant généré automatiquement, ne le modifiez pas directement.  Pour apporter des modifications,
    ' ou si vous rencontrez des erreurs de build dans ce fichier, accédez au Concepteur de projets
    ' (allez dans les propriétés du projet ou double-cliquez sur le nœud My Project dans
    ' l'Explorateur de solutions), puis apportez vos modifications sous l'onglet Application.
    '
    Partial Friend Class MyApplication
        
        <Global.System.Diagnostics.DebuggerStepThroughAttribute()>  _
        Public Sub New()
            MyBase.New(Global.Microsoft.VisualBasic.ApplicationServices.AuthenticationMode.Windows)
            Me.IsSingleInstance = false
            Me.EnableVisualStyles = true
            Me.SaveMySettingsOnExit = true
            Me.ShutDownStyle = Global.Microsoft.VisualBasic.ApplicationServices.ShutdownMode.AfterMainFormCloses
        End Sub
        
        <Global.System.Diagnostics.DebuggerStepThroughAttribute()>  _
        Protected Overrides Sub OnCreateMainForm()
            Me.MainForm = Global.VideoGEsti.Form1
        End Sub
    End Class
End Namespace
