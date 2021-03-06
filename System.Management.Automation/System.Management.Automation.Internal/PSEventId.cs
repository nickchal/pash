namespace System.Management.Automation.Internal
{
    using System;

    internal enum PSEventId
    {
        AnalyticTransferEventRunspacePool = 0x2f07,
        AppDomainUnhandledException = 0x8009,
        AppDomainUnhandledException_Analytic = 0x8007,
        AppName = 0x2f02,
        Command_Health = 0x1004,
        Command_Lifecycle = 0x1f01,
        ComputerName = 0x2f03,
        Engine_Health = 0x1005,
        Engine_Lifecycle = 0x1f02,
        Engine_Trace = 0x1f06,
        HostNameResolve = 0x1001,
        LoadingPSCustomShellAssembly = 0x8061,
        LoadingPSCustomShellType = 0x8062,
        OperationalTransferEventRunspacePool = 0x2004,
        Perftrack_ConsoleStartupStart = 0xa001,
        Perftrack_ConsoleStartupStop = 0xa002,
        Pipeline_Detail = 0x1007,
        Port = 0x2f01,
        Provider_Health = 0x1006,
        Provider_Lifecycle = 0x1f03,
        ReceivedRemotingFragment = 0x8063,
        ReportContext = 0x8053,
        ReportOperationComplete = 0x8054,
        RunspaceConstructor = 0x2001,
        RunspacePoolConstructor = 0x2002,
        RunspacePoolOpen = 0x2003,
        RunspaceStateChange = 0x2005,
        ScheduledJob_Complete = 0xd002,
        ScheduledJob_Error = 0xd003,
        ScheduledJob_Start = 0xd001,
        Scheme = 0x2f04,
        SchemeResolve = 0x1002,
        SentRemotingFragment = 0x8064,
        Serializer_DepthOverride = 0x7003,
        Serializer_EnumerationFailed = 0x7007,
        Serializer_MaxDepthWhenSerializing = 0x700a,
        Serializer_ModeOverride = 0x7004,
        Serializer_PropertyGetterFailed = 0x7006,
        Serializer_RehydrationFailure = 0x7002,
        Serializer_RehydrationSuccess = 0x7001,
        Serializer_ScriptPropertyWithoutRunspace = 0x7005,
        Serializer_SpecificPropertyMissing = 0x700c,
        Serializer_ToStringFailed = 0x7008,
        Serializer_XmlExceptionWhenDeserializing = 0x700b,
        ServerClientReceiveRequest = 0x8058,
        ServerCloseOperation = 0x8059,
        ServerCreateCommandSession = 0x8055,
        ServerCreateRemoteSession = 0x8052,
        ServerReceivedData = 0x8057,
        ServerSendData = 0x8051,
        ServerStopCommand = 0x8056,
        Settings = 0x1f04,
        ShellResolve = 0x1003,
        TestAnalytic = 0x2f05,
        TransportError = 0x8010,
        TransportError_Analytic = 0x8008,
        TransportReceivedData = 0x8003,
        TransportReceivedObject = 0x8001,
        TransportSendingData = 0x8002,
        URIRedirection = 0x8025,
        WSManCloseCommand = 0x8021,
        WSManCloseCommandCallbackReceived = 0x8022,
        WSManCloseShell = 0x8013,
        WSManCloseShellCallbackReceived = 0x8014,
        WSManConnectionInfoDump = 0x2f06,
        WSManCreateCommand = 0x8019,
        WSManCreateCommandCallbackReceived = 0x8020,
        WSManCreateShell = 0x8011,
        WSManCreateShellCallbackReceived = 0x8012,
        WSManPluginShutdown = 0x8065,
        WSManReceiveShellOutputEx = 0x8017,
        WSManReceiveShellOutputExCallbackReceived = 0x8018,
        WSManSendShellInputEx = 0x8015,
        WSManSendShellInputExCallbackReceived = 0x8016,
        WSManSignal = 0x8023,
        WSManSignalCallbackReceived = 0x8024
    }
}

