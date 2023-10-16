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

function getHtmlTypeByDBType(columnType) {
    var inputType = "";
    switch (columnType) {
        case "bit":
            inputType = "checkbox";
            break;
        case "int":
        case "decimal":
        case "float":
        case "numeric":
        case "smallint":
            if (columnType.toLowerCase().indexOf('month') !== -1)
                inputType = "month";
            else if (columnType.toLowerCase().indexOf('week') !== -1)
                inputType = "week";
            inputType = "number";
            break;
        case "date":
            inputType = "date";
            break;
        case "datetime":
        case "smalldatetime":
            inputType = "datetime-local";
            break;
        default:
            if (columnType.toLowerCase().indexOf('phone') !== -1)
                inputType = "tel";
            else if (columnType.toLowerCase().indexOf('mail') !== -1)
                inputType = "tel";
            else if (columnType.toLowerCase().indexOf('url') !== -1)
                inputType = "url";
            else if (columnType.toLowerCase().indexOf('color') !== -1 || columnType.toLowerCase().indexOf('colour') !== -1)
                inputType = "color";
            else
                inputType = "text";
            break;
    }
    return inputType;
}