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
function GetCustomizeRealdata(machineId, viewId) {
    console.log("GetCustomizeRealdata called");
    return new Promise(function (resolve, reject) {
        $.ajax({
            url: Q.resolveUrl('/MachineSummaryMachine/GetCustomizePreviewDataAsync'),
            type: 'GET',
            async: true,
            dataType: 'json',
            data: {
                MachineId: machineId,
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
