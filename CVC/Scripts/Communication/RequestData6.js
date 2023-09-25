function AddUpdateDOF(parameterList){
    return new Promise(function (resolve, reject) {
        $.ajax({
            url: Q.resolveUrl('~/Request/AddUpdateDOF'),
            type: 'POST',
            dataType: 'json',
            data: {parameterList : parameterList},
            success: function (data) {
                resolve(data);
            },
            error: function (error) {
                reject(error);
            }
        });
    });
}
function getMachineParametersFromDisplayObject(displayObjectId){
    return new Promise(function (resolve, reject) {
        $.ajax({
            url: Q.resolveUrl('~/Request/GetEFsFromDOId'),
            type: 'POST',
            dataType: 'json',
            data: {displayObjectId : displayObjectId},
            success: function (data) {
                resolve(data);
            },
            error: function (error) {
                reject(error);
            }
        });
    });
}

function getTableDataFromDisplayObject(displayObjectId){
    return new Promise(function (resolve, reject) {
        $.ajax({
            url: Q.resolveUrl('~/Request/getTableDataFromDisplayObject'),
            type: 'POST',
            dataType: 'json',
            data: {displayObjectId : displayObjectId},
            success: function (data) {
                resolve(data);
            },
            error: function (error) {
                reject(error);
            }
        });
    });
}