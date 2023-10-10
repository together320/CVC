var moduleNames = {
    "Administration": ["Roles", "UserManagement", "ModuleAccess", "Language", "Users"],
    "MachineCustomization": ["PackageLine", "Machine", "MachineParameter", "Alarm", "Module", "DisplayObject", "TerminalType", "MasterTerminal", "MessageMaster", "ListDisplay", "FormDisplay", "ButtonDisplay", "RealTimeParameterDisplay", "LineChartDisplay", "PieChartDisplay", "TreeDisplay", "AttachmentDisplay", "AlarmDisplay", "NotificationDisplay", "ContainerDisplay", "PrimaryRelationship", "SecondaryRelationship", "ScreenViews", "DisplayObjectColor", "MachineRecipe"],
    "PackSettings": ["Bottle", "Pack", "Cotton", "Desiccant", "Cap"],
    "Configuration": ["Company", "Department"],
    "ExternalApplicationInterface": [],
    "Report": [],
    "Batch": ["Batch"]
}

function getCVCServiceUrl(tableName) {
    var moduleName = null
    for (var key in moduleNames) {
        for (var item of moduleNames[key]) {
            if (item == tableName) {
                moduleName = key;
                break;
            }
        }
        if (moduleName != null)
            break;
    }
    if (tableName == "Roles")
        tableName = "Role";
    else if (tableName == "Users")
        tableName = "User";
    var serviceUrl = '~/services/' + moduleName + '/' + tableName
    return serviceUrl;
}