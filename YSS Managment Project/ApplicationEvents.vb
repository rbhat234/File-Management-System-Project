﻿Imports System.Collections.ObjectModel
Namespace My

    ' 
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication
        Protected Overrides Function OnInitialize(ByVal commandLineArgs As System.Collections.ObjectModel.ReadOnlyCollection(Of String)) As Boolean
            'set the time display to 500 milliseconds (5 seconds)
            Me.MinimumSplashScreenDisplayTime = 5000
            Return MyBase.OnInitialize(commandLineArgs)
        End Function
    End Class


End Namespace
