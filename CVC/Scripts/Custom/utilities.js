var moduleNames = {
    "Administration": ["Roles", "UserManagement", "ModuleAccess", "Language"],
    "MachineCustomization": ["PackageLine", "Machine", "MachineParameter", "Alarm", "Module", "DisplayObject", "TerminalType", "MasterTerminal", "MessageMaster", "ListDisplay", "FormDisplay", "ButtonDisplay", "RealTimeParameterDisplay", "LineChartDisplay", "PieChartDisplay", "TreeDisplay", "AttachmentDisplay", "AlarmDisplay", "NotificationDisplay", "ContainerDisplay", "PrimaryRelationship", "SecondaryRelationship", "ScreenViews", "DisplayObjectColor"],
    "PackSettings": [],
    "Configuration": [],
    "ExternalApplicationInterface": [],
    "Report": []
}

function getCVCServiceUrl(tableName) {
    var moduleName = null
    for (var key in moduleNames) {
        for (var i = 0; i < moduleNames[key]; i++) {
            if (moduleNames[key][i] == tableName) {
                moduleName = key;
                break;
            }
        }
    }
    if (tableName == "Roles")
        tableName = "Role";
    var serviceUrl = '~/services/Administration/' + tableName
    return serviceUrl;
}