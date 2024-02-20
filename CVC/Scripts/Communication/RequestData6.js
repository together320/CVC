function GetRealTimeMachineParameterValue(machineParameterData) {
    return new Promise(function (resolve, reject) {
        $.ajax({
            url: Q.resolveUrl('~/Request/GetRealTimeMachineParameterValue'),
            type: 'POST',
            dataType: 'json',
            data: { machineParameterData: machineParameterData },
            success: function (data) {
                resolve(data);
            },
            error: function (error) {
                reject(error);
            }
        });
    });
}

function AddUpdateDOF(parameterList) {
    return new Promise(function (resolve, reject) {
        $.ajax({
            url: Q.resolveUrl('~/Request/AddUpdateDOF'),
            type: 'POST',
            dataType: 'json',
            data: { parameterList: parameterList },
            success: function (data) {
                resolve(data);
            },
            error: function (error) {
                reject(error);
            }
        });
    });
}

function GetDropdownListfromPickListId(pickListId) {
    return new Promise(function (resolve, reject) {
        $.ajax({
            url: Q.resolveUrl('~/Request/GetDropdownListfromPickListId'),
            type: 'POST',
            dataType: 'json',
            data: { pickListId: pickListId },
            success: function (data) {
                resolve(data);
            },
            error: function (error) {
                reject(error);
            }
        });
    });
}

function getMachineParametersFromDisplayObject(displayObjectId) {
    return new Promise(function (resolve, reject) {
        $.ajax({
            url: Q.resolveUrl('~/Request/GetEFsFromDOId'),
            type: 'POST',
            dataType: 'json',
            data: { displayObjectId: displayObjectId },
            success: function (data) {
                resolve(data);
            },
            error: function (error) {
                reject(error);
            }
        });
    });
}

function getMachineRealTimeDataFromViewsId(viewsId) {
    return new Promise(function (resolve, reject) {
        $.ajax({
            url: Q.resolveUrl('~/Request/GetMachineRealTimeDataFromViewsId'),
            type: 'POST',
            dataType: 'json',
            data: { viewsId: viewsId },
            success: function (data) {
                resolve(data);
            },
            error: function (error) {
                reject(error);
            }
        });
    });
}

function getTableDataFromDisplayObject(displayObjectId) {
    return new Promise(function (resolve, reject) {
        $.ajax({
            url: Q.resolveUrl('~/Request/getTableDataFromDisplayObject'),
            type: 'POST',
            dataType: 'json',
            data: { displayObjectId: displayObjectId },
            success: function (data) {
                resolve(data);
            },
            error: function (error) {
                reject(error);
            }
        });
    });
}

function getAllDataTypesFromDisplayObject(displayObjectId) {
    return new Promise(function (resolve, reject) {
        $.ajax({
            url: Q.resolveUrl('~/Request/getAllDataTypesFromDisplayObject'),
            async: true,
            type: 'POST',
            dataType: 'json',
            data: { displayObjectId: displayObjectId },
            success: function (data) {
                resolve(data);
            },
            error: function (error) {
                reject(error);
            }
        });
    });
}


// demand a hand for delete
function GetCustomizeRealData(viewId) {
    return new Promise(function (resolve, reject) {
        $.ajax({
            url: Q.resolveUrl('/MachineSummaryMachine/GetCustomizePreviewDataAsync'),
            type: 'POST',
            async: true,
            dataType: 'json',
            data: { ViewId: viewId },
            success: function (data) {
                resolve(data);
            },
            error: function (err) {
                reject(err)
            }
        });
    });
}

function getDisplayObjectColorsByViewsId(viewsId) {
    return new Promise(function (resolve, reject) {
        $.ajax({
            url: Q.resolveUrl('~/Request/GetDisplayObjectColors'),
            type: 'POST',
            dataType: 'json',
            data: { ViewsId: viewsId },
            success: function (data) {
                resolve(data);
            },
            error: function (error) {
                reject(error);
            }
        });
    });
}

function getDisplayObjectByViewsId(viewsId) { // viewsId == displayobjectId

}

function saveColorRowByViewsId(viewsId, rowData) {
    return new Promise(function (resolve, reject) {
        $.ajax({
            url: Q.resolveUrl('~/Request/SaveDisplayObjectColor'),
            type: 'POST',
            dataType: 'json',
            data: {
                ViewsId: viewsId,
                RowData: JSON.stringify(rowData)
            },
            success: function (data) {
                resolve(data);
            },
            error: function (error) {
                reject(error);
            }
        });
    });
}
function deleteColorRow(colorId) {
    return new Promise(function (resolve, reject) {
        $.ajax({
            url: Q.resolveUrl('~/Request/DeleteDisplayObjectColor'),
            type: 'POST',
            dataType: 'json',
            data: { ColorId: colorId },
            success: function (data) {
                resolve(data);
            },
            error: function (error) {
                reject(error);
            }
        });
    });
}

function deleteRowFromDatatable(url, rowId) {
    return new Promise(function (resolve, reject) {
        $.ajax({
            url: Q.resolveUrl(url),
            type: 'POST',
            dataType: 'json',
            data: JSON.stringify({ EntityId: rowId }),
            contentType: "application/json; charset=utf-8",
            success: function (data) {
                resolve(data);
            },
            error: function (error) {
                reject(error);
            }
        });
    });
}

function addRowToDataTable(url, rowData) {
    return new Promise(function (resolve, reject) {
        $.ajax({
            url: Q.resolveUrl(url),
            type: 'POST',
            dataType: 'json',
            data: JSON.stringify({ Entity: rowData }),
            contentType: "application/json; charset=utf-8",
            success: function (data) {
                resolve(data);
            },
            error: function (error) {
                reject(error);
            }
        });
    });
}
function saveRowToDataTable(url, rowData, entityId) {
    return new Promise(function (resolve, reject) {
        $.ajax({
            url: Q.resolveUrl(url),
            type: 'POST',
            dataType: 'json',
            data: JSON.stringify({ EntityId: entityId, Entity: rowData }),
            contentType: "application/json; charset=utf-8",
            success: function (data) {
                resolve(data);
            },
            error: function (error) {
                reject(error);
            }
        });
    });
}

function GetSubTypeTableAndPrimarykey(viewsId) {
    return new Promise(function (resolve, reject) {
        $.ajax({
            url: Q.resolveUrl('~/Request/GetSubTypeTableAndPrimarykey'),
            type: 'POST',
            dataType: 'json',
            data: { ViewsId: viewsId },
            success: function (data) {
                resolve(data);
            },
            error: function (error) {
                reject(error);
            }
        });
    });
}

function GetSubTypeDataBySubEntityId(url, entityId) {
    return new Promise(function (resolve, reject) {
        $.ajax({
            url: Q.resolveUrl(url),
            type: 'POST',
            dataType: 'json',
            data: JSON.stringify({ EntityId: entityId }),
            contentType: "application/json; charset=utf-8",
            success: function (data) {
                resolve(data);
            },
            error: function (error) {
                reject(error);
            }
        });
    });
}