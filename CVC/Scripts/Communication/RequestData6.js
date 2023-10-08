﻿function GetRealTimeMachineParameterValue(machineParameterData) {
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


// demand a hand for delete
function GetCustomizeRealData(machineId, viewId) {
    console.log("GetCustomizeRealdata called");
    return new Promise(function (resolve, reject) {
        $.ajax({
            url: Q.resolveUrl('/MachineSummaryMachine/GetCustomizePreviewDataAsync'),
            type: 'POST',
            async: true,
            dataType: 'json',
            data: {
                MachineID: machineId,
                ViewId: viewId
            },
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
                console.log("deleting DOcolor is succeed!!!");
                console.log(data);
                resolve(data);
            },
            error: function (error) {
                reject(error);
            }
        });
    });
}
