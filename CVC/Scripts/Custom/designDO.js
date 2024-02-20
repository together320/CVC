var totalDataCompany;
var totalDataDisplay;
var totalDataFieldFilter, tempDataFieldFilter;
var do_editor;
var newChart;
var chart_labels = [];

// machineData
var isRTMachine = false;
var tableName = null;
var machineId = -1;
var moduleId = -1; // -1: undefined, >0 : defined

// DataTable
var columnList = [];
var selectedEntityId = -1;
var columnTypes = [];

// basicproperties
var basicDOStyle = {};

// TimeCounter
var timmer;

// ColorRange
var colorList = [];
var dotype;

var efRowHtml = `<p style="margin:0px;">EFnameToChange  </p> <input id="value-ef" type='text' required value=''/>`;


function connectToSocket() {
    var socket = $.connection.socketHub;
    socket.client.addNewMessageToPage = function (data, message) {
        var result = JSON.parse(data);
        switch (result.type) {
            case 'customizePreview':
                timmer = setTimeout(() => {
                    socket.server.send('customizePreview', '');
                }, 300);
                processCustomizePreview(result.data);
                break;
            default:
        }
        result = null;
    };

    $.connection.hub.start().done(function () {
        socket.server.send('customizePreview', '');
    });

    $.connection.hub.disconnected(function () {
        setTimeout(function () {
            $.connection.hub.start();
        }, 3000); // Restart connection after 3 seconds.
    });
}

function processCustomizePreview(dataList) { // datalist is just ViewFieldList
    if (dataList == null) {
        clearTimeout(timmer);
        return; g
    } else {
        var labels = [], datum = [], colors = [];
        dataList.forEach(element => {
            labels.push(element.ParameterName);
            if (element.Value == null)
                datum.push(0);
            else
                datum.push(parseFloat(element.value));
            // colors.push(element.)
        });
        updateChartByParameters(labels, datum);
    }
}

function calculateBackgroundColor(value) { // value is float
    for (var i = 0; i < colorList.length; i++) {
        if (value >= colorList[i].RangeFrom && value <= colorList[i].RangeTo) {
            return colorList[i].color;
        }
    }
    // Default color if no range matches
    return 'gray';
}


// $(function () {
//    $(".dragOrigin").draggable();
// });

$("#draggable").draggable();

function undoDoEdit() {
    Q.notifyWarning("Currently under Development.");
    if (undoStack.length > 1) {
        undoStack.pop(); // Remove the latest state from the stack
        $('.workSpace').html(undoStack[undoStack.length - 1]);
    }
}

function saveDO() {
    let dataTable = $("#do_element_table_" + $("#DisplayObjectId").val()).DataTable();
    var data = dataTable.row(dataTable.page.info().page).data();
    let numCols = dataTable.columns().nodes().length;

    let parameterList = [];

    for (var i = 0; i < numCols; i++) {
        let column = dataTable.column(i);
        if (column.visible()) {
            let parameter = {};
            let columnText = $(column.header()).text();

            for (var j = 0; j < efDataList.length; j++) {
                if (efDataList[j].ColumnName == columnText || efDataList[j].ParameterName == columnText) {
                    parameter["ViewsId"] = $("#DisplayObjectId").val();
                    parameter["ViewFieldName"] = efDataList[j].ParameterName;
                    parameter["MachineParameterId"] = efDataList[j].MachineParameterId;
                    parameter["StatusId"] = 1;
                    parameterList.push(parameter);
                    break;
                }
            }
        }
    }

    AddUpdateDOF(parameterList); // is not yet full-defined
}

function addDo() {
    columnList = [];
    console.log("add do function is called");
    var newId = `parent_do_element_${$("#DisplayObjectId").val()}`;

    var res;
    doType = $("#DisplayObjectType").val();
    let displayObjectId = parseInt($("#DisplayObjectId").val());


    GetSubTypeTableAndPrimarykey(displayObjectId).then(subData => {
        let serviceUrl = '~/services/MachineCustomization/' + subData.tableName + '/Retrieve';
        let entityId = subData.primaryKey;
        if (entityId == null) Q.notifyError("DisplayObjectType is undefined.");
        GetSubTypeDataBySubEntityId(serviceUrl, entityId).then(data => {
            // handle exceptions
            if ('message' in data) {
                Q.notifyError(data.message);
                return;
            }
            else if (data == null || data == {}) {
                Q.notifyError("There is no data.");
                return;
            }
            // save basic displayobject style (actually this is sub do type data e.g. one row of listdisplay table)
            basicDOStyle = data;

            if (doType == 1) { // DO is list format
                res = `<div style='width:90%; margin:0 auto; position:absolute; min-height:90%;'><table id='do_element_table_${$("#DisplayObjectId").val()}' class='displays table-striped table-bordered dt-responsive nowrap' width='100' cellspacing='0'></table></div>`;
            }
            else if (doType == 2 || doType == 3) { // DO is form format and buttondisplay
                res = `<div style='width:90%; margin:0 auto; position:absolute; min-height:90%;'><div id='do_element_${$("#DisplayObjectId").val()}' style='color:black;padding-top:40px;'></div><table id='do_element_table_${$("#DisplayObjectId").val()}' class='displays table-striped table-bordered dt-responsive nowrap' width='100' cellspacing='0'></table></div>`;
            }
            else if (doType == 4) { //Realtime parameter display
                res = `<div style='width:90%; margin:0 auto; position:absolute; min-height:90%;'><div id='do_element_${$("#DisplayObjectId").val()}' style='color:black;padding-top:40px;display:grid;gap:10px;    grid-template-columns: repeat(4, 1fr);'></div><table id='do_element_table_${$("#DisplayObjectId").val()}' class='displays table-striped table-bordered dt-responsive nowrap' width='100' cellspacing='0'></table></div>`;
            }
            else if (doType == 5 || doType == 6) {  //linechart display
                res = `<div style='width:90%; margin:0 auto; position:absolute; min-height:90%;'><canvas id='do_element_${$("#DisplayObjectId").val()}' style='display:block;width:100%;max-width:600px;' width='400' height='400'></canvas><table id='do_element_table_${$("#DisplayObjectId").val()}' class='displays table-striped table-bordered dt-responsive nowrap' width='100' cellspacing='0'></table></div>`;
            }
            else if (doType == 7) {
                res = `<div style='width:90%; margin:0 auto; position:absolute; min-height:90%;'><div id='do_element_${$("#DisplayObjectId").val()}' style='color:black;display:block;width:100%;max-width:600px;'></div><table id='do_element_table_${$("#DisplayObjectId").val()}' class='displays table-striped table-bordered dt-responsive nowrap' width='100' cellspacing='0'></table></div>`;
            }
            else if (doType == 9 || doType == 10) {
                res = `<div style='width:90%; margin:0 auto; position:absolute; min-height:90%;'><ul id='do_element_${$("#DisplayObjectId").val()}' style='color:black;display:block;width:100%;max-width:600px;' class='todo-list ui-sortable'></ul><table id='do_element_table_${$("#DisplayObjectId").val()}' class='displays table-striped table-bordered dt-responsive nowrap' width='100' cellspacing='0'></table></div>`;
            }

            var nodeCopy = $(res).attr('id', newId).addClass('clones').addClass('mainDO');
            nodeCopy.addClass('my-dragging-class');  // Apply the CSS class with reduced opacity
            $('.workSpace').append(nodeCopy);

            if ($("#DisplayObjectType").val() == 1) { //in case of table

                getTableDataFromDisplayObject($("#DisplayObjectId").val()).then(function (data) {   //fetches all fields form the database
                    getAllDataTypesFromDisplayObject($("#DisplayObjectId").val()).then(function (typeData) {
                        columnTypes = typeData;
                        $("#do_element_table_" + $("#DisplayObjectId").val()).empty();  //format table
                        var tableHeaders;
                        typeData.map(item => {        //prepare table headers
                            tableHeaders += "<th>" + item.ColumnName + "</th>";
                        })

                        $("#do_element_table_" + $("#DisplayObjectId").val()).append('<thead><tr>' + tableHeaders + '</tr></thead>');
                        $("#do_element_table_" + $("#DisplayObjectId").val()).append('<tfoot><tr>' + tableHeaders + '</tr></tfoot>');
                        // $('#do_element').dataTable(json);
                        var dataTableData = data.map(function (item) {
                            var row = [];
                            for (var key in item) {
                                row.push(item[key]);
                            }
                            return row;
                        });

                        console.log(dataTableData);
                        $("#do_element_table_" + $("#DisplayObjectId").val()).DataTable({   //make table
                            select: true,
                            data: dataTableData, // Replace yourDataArray with the fetched data from the server
                            columns: typeData.map(item => {        //prepare table headers
                                columnList.push(item.ColumnName);
                                return { title: item.ColumnName, visible: false };
                            }),
                            responsive: {
                                details: {
                                    type: 'column'
                                }
                            },
                            columnDefs: [{
                                className: 'control',
                                orderable: false,
                            }],
                            dom: 'Bfrtip',
                            altEditor: true,     // Enable altEditor
                            buttons: [],
                            initComplete: function () {
                                this.api()
                                    .columns()
                                    .every(function () {
                                        let column = this;
                                        let title = column.footer().textContent;

                                        // Create input element
                                        let input = document.createElement('input');
                                        input.placeholder = title;
                                        input.style.color = "black";
                                        column.footer().replaceChildren(input);

                                        // Event listener for user input
                                        input.addEventListener('keyup', () => {
                                            if (column.search() !== this.value) {
                                                column.search(input.value).draw();
                                            }
                                        });
                                    });
                            }
                        }).catch(function (error) {
                            console.log(error);
                            Q.notifyError("Data Base Connection is Error.");
                        });
                    });

                });
            }
            if ($("#DisplayObjectType").val() == 2) { //in case of form
                getTableDataFromDisplayObject($("#DisplayObjectId").val()).then(function (data) {
                    getAllDataTypesFromDisplayObject($("#DisplayObjectId").val()).then(function (typeData) {
                        columnTypes = typeData;
                        $("#do_element_" + $("#DisplayObjectId").val()).empty();
                        $("#do_element_table_" + $("#DisplayObjectId").val()).empty();
                        $("#do_element_table_" + $("#DisplayObjectId").val()).css('display', 'none');

                        var tableHeaders;
                        Object.keys(typeData).map(function (ColumnName) {        //prepare table headers
                            tableHeaders += "<th>" + ColumnName + "</th>";
                        })
                        $("#do_element_table_" + $("#DisplayObjectId").val()).append('<thead><tr>' + tableHeaders + '</tr></thead>');
                        // $('#do_element').dataTable(json);
                        var dataTableData = data.map(function (item) {
                            var row = [];
                            for (var key in item) {
                                row.push(item[key]);
                            }
                            return row;
                        });
                        $("#do_element_table_" + $("#DisplayObjectId").val()).DataTable({
                            select: true,
                            data: dataTableData, // Replace yourDataArray with the fetched data from the server
                            columns: Object.keys(data[0]).map(function (columnName) {
                                columnList.push(columnName);
                                return { title: columnName, visible: false };
                            }),
                            dom: 'Bfrtip',
                            altEditor: true,     // Enable altEditor
                            pageLength: 1,
                            buttons: [],
                            rowCallback: function (row, data, index) {      //this happens when we change current row, so here we have to change form display
                                let mainDoElement = $("#do_element_" + $("#DisplayObjectId").val());
                                mainDoElement.empty();

                                let dataTable = $("#do_element_table_" + $("#DisplayObjectId").val()).DataTable();
                                let numCols = dataTable.columns().nodes().length;
                                for (var i = 0; i < numCols; i++) {
                                    var inputType = getHtmlTypeByDBType(columnTypes[i].DataType);
                                    let column = dataTable.column(i);
                                    if (column.visible()) {
                                        mainDoElement.append("<div class='row' style='justify-content : center;'><div class='col-3'>" + $(column.header()).text() + " :</div><div class='col-3'><input value='" + data[i] + "' type='" + inputType + "' form-do-input='" + i + "'/></div></div>");
                                        var input = "[form-do-input=" + i + "]";
                                        $(input).keydown(function (event) {
                                            if (event.keyCode == 13) {
                                                var rowData = dataTable.row({ search: 'applied' }).data();
                                                var colindex = $(this).attr("form-do-input");
                                                rowData[parseInt(colindex)] = this.value;
                                                event.preventDefault();
                                                saveFormRow(rowData);
                                            }
                                        });
                                    }
                                }

                                mainDoElement.insertBefore($("#do_element_table_" + $("#DisplayObjectId").val()));
                            },
                        });

                    }).catch(function (error) {
                        console.log(error);
                        Q.notifyError("Data Base Connection is Error.");
                    });
                });
            }
            if ($("#DisplayObjectType").val() == 3 || $("#DisplayObjectType").val() == 4 || $("#DisplayObjectType").val() == 5
                || $("#DisplayObjectType").val() == 6 || $("#DisplayObjectType").val() == 7 || $("#DisplayObjectType").val() == 9
                || $("#DisplayObjectType").val() == 10) { //in case of button format
                $("#do_element_" + $("#DisplayObjectId").val()).empty();
                $("#do_element_table_" + $("#DisplayObjectId").val()).empty();

                var tableHeaders;
                for (var i = 0; i < efDataList.length; i++) {
                    tableHeaders += "<th>" + efDataList[i].ParameterName + "</th>";
                }
                $("#do_element_table_" + $("#DisplayObjectId").val()).append('<thead><tr>' + tableHeaders + '</tr></thead>');
                // $('#do_element').dataTable(json);
                var dataTableData = [];
                $("#do_element_table_" + $("#DisplayObjectId").val()).DataTable({
                    data: dataTableData, // Replace yourDataArray with the fetched data from the server
                    columns: efDataList.map(function (efData) {
                        return { title: efData.ParameterName, visible: false };
                    }),
                    "initComplete": function (settings, json) {
                        $("#do_element_table_" + $("#DisplayObjectId").val() + "_wrapper").css('display', 'none');
                        if ($("#DisplayObjectType").val() == 5 || $("#DisplayObjectType").val() == 6) { //chart view
                            var xValues = [];
                            var yValues = [];
                            var barColors = ["red", "green", "blue", "orange", "brown"];

                            newChart = new Chart($("#do_element_" + $("#DisplayObjectId").val()), {
                                type: $("#DisplayObjectType").val() == 5 ? "bar" : "pie",
                                data: {
                                    labels: xValues,
                                    datasets: [{
                                        backgroundColor: barColors,
                                        data: yValues
                                    }]
                                },
                                options: {
                                    legend: { display: false },
                                    title: {
                                        display: true,
                                        text: "Chart"
                                    }
                                }
                            });
                            updateChart();

                            // setInterval(updateChart, 1000);
                        }

                    }
                });
            }
        }).catch(error => {
            Q.notifyError("")
        });
    }).catch(error => {
        Q.notifyError("DisplayObject Basic Property is not found.");
    });

}

function dragEF(event) {                   //when dragging main display object
    event.dataTransfer.setData('dragging', 'no-clone');
    event.dataTransfer.setData('dropped-id', 'ef');
    event.dataTransfer.setData('columnName', $(event.target).attr('columnname'));
    event.dataTransfer.setData('pickListId', $(event.target).attr('pickListId'));

    if ($("#DisplayObjectType").val() == 3 || $("#DisplayObjectType").val() == 4 || $("#DisplayObjectType").val() == 5
        || $("#DisplayObjectType").val() == 6 || $("#DisplayObjectType").val() == 7 || $("#DisplayObjectType").val() == 9
        || $("#DisplayObjectType").val() == 10) { //if button, realtime format, then the columnName does not exist, so parameterName will use
        event.dataTransfer.setData('columnName', $(event.target).text());
    }
}

function dragGrid(event) {                   //when dragging grid system
    if ($("main").html().trim() === "") {
        rowCount = 0;
    }
    var value = $(event.target).prev().children(':first').val().trimEnd();
    if (value != "") {
        var newId = 'gridId' + ++rowCount + `_${$("#DisplayObjectId").val()}`;
        var res = row_GetRowCloneStrs(value, newId, value);
        var nodeCopy = $(res).attr('id', newId).addClass('clones');
        nodeCopy.addClass('my-dragging-class');  // Apply the CSS class with reduced opacity
        $('body').append(nodeCopy);
        event.dataTransfer.setData('dragging', 'no-clone');
        event.dataTransfer.setData('dropped-id', newId);
        event.dataTransfer.setDragImage(nodeCopy[0], 0, 0);
    }
}

function dragComponent(event, type) {            //when dragging sample components
    if ($("main").html().trim() === "") {
        rowCount = 0;
    }
    var res = "";
    var newId = 'componentId' + ++componentCount + `_${$("#DisplayObjectId").val()}`;
    if (type == 0) //textbox
        res = "<textarea style='color:black'>Sample textbox</textarea>";
    else if (type == 1) //label
        res = "<p style='color:black'>Sample label</p>";
    else if (type == 2)
        res = "<select style='color:black'></select>";
    else if (type == 3)
        res = "<input type='button' value='Sample button' style='color:black'/>";
    else if (type == 4)
        res = "<input type='button' value='Add' style='color:black' commonButton='4'/>";
    else if (type == 5)
        res = "<input type='button' value='Edit' style='color:black' commonButton='5'/>";
    else if (type == 6)
        res = "<input type='button' value='Delete' style='color:black' commonButton='6'/>";

    var nodeCopy = $(res).attr('id', newId).addClass('clones').addClass('component');
    //Q.notifyInfo($(nodeCopy).prop('outerHTML'));
    nodeCopy.addClass('my-dragging-class');  // Apply the CSS class with reduced opacity

    $('body').append(nodeCopy);
    event.dataTransfer.setData('dragging', 'no-clone');
    event.dataTransfer.setData('dropped-id', newId);
    event.dataTransfer.setDragImage(nodeCopy[0], 0, 0);
}

function dragClonedGrid(event) {
    event.dataTransfer.setData('dragging', 'clones');
    console.log($(event.target).attr('id'));
    event.dataTransfer.setData('dropped-id', $(event.target).attr('id'));
}

function toggleHeader(index) {
    let dataTable = $("#do_element_table_" + $("#DisplayObjectId").val()).DataTable();
    let column = dataTable.column(index);
    column.visible(!column.visible());

    if ($("#DisplayObjectType").val() == 1)
        return;

    undoStack.push($('.workSpace').html());

    let mainDoElement = $("#do_element_" + $("#DisplayObjectId").val());
    mainDoElement.empty();

    var data = dataTable.row(dataTable.page.info().page).data();
    let numCols = dataTable.columns().nodes().length;
    chart_labels = [];

    console.log(numCols);
    for (var i = 0; i < numCols; i++) {
        let column = dataTable.column(i);
        // console.log($(column.header()).text());
        if (column.visible()) {
            if ($("#DisplayObjectType").val() == 2) { // make the input forms  from datatable
                var htmlstr = "<div class='row' style='justify-content : center;'><div class='col-3'>" + $(column.header()).text() + " :</div><div class='col-3'><input type='' form-do-input='" + i + "' value='" + data[i] + "' /></div></div>";
                htmlstr = htmlstr.replace("type=''", "type='" + getHtmlTypeByDBType(columnTypes[i].DataType) + "'");
                mainDoElement.append(htmlstr);
                var input = "[form-do-input=" + i + "]";
                $(input).keydown(function (event) {
                    if (event.keyCode == 13) {
                        var rowData = dataTable.row({ search: 'applied' }).data();
                        var colindex = $(this).attr("form-do-input");
                        rowData[parseInt(colindex)] = this.value;
                        event.preventDefault();
                        saveFormRow(rowData);
                    }
                });
            }
            if ($("#DisplayObjectType").val() == 3) // button display
                mainDoElement.append(`<button type="button" class="btn btn-app btn-light"><i class="fa fa-play" style="display:block"></i><span style="display:block">${$(column.header()).text().substring(0, 5) + "..."}</span></button>`);
            if ($("#DisplayObjectType").val() == 4) // realtimeparameters
                mainDoElement.append(`<div class="card-box widget-flat text-white bg-blue" style="background-color:aqua;height:inherit; text-align:center;"><i class="fi-tag"></i><h3>333</h3><span>${$(column.header()).text()}</span></div>`);
            if ($("#DisplayObjectType").val() == 9) // alarm display
                mainDoElement.append(`<li style="padding: 5px 10px;"><div style="color:#f1556c; background-color:#fef0f2; border:#f9b3bd 1px solid; padding:10px; border-radius:4px; font-weight:normal;font-size:16px;">${$(column.header()).text()}</div></li>`);
            if ($("#DisplayObjectType").val() == 10) // notification display
                mainDoElement.append(`<li style="padding: 5px 10px;"><div style="color:#169F85; background-color:#b1f3e5; border:#75c7b6 1px solid; padding:10px; border-radius:4px; font-weight:normal;font-size:16px;">${$(column.header()).text()}</div></li>`);
            chart_labels.push($(column.header()).text());
        }
    }

    if ($("#DisplayObjectType").val() == 2)
        mainDoElement.insertBefore($("#do_element_table_" + $("#DisplayObjectId").val()));

    if ($("#DisplayObjectType").val() == 7) { //tree view                            
        tree_nodes = [];
        for (var i = 0; i < chart_labels.length; i++) {
            tree_nodes.push({ text: chart_labels[i] });
        }
        console.log(tree_nodes);
        $("#do_element_" + $("#DisplayObjectId").val()).treeview({ data: [{ text: $("#DisplayObjectName").val(), nodes: tree_nodes }] });
    }

    addSearchInputInFooter();
}

function updateChart() { //
    var newData = [];
    newChart.data.labels = chart_labels;
    for (var i = 0; i < chart_labels.length; i++)
        newData.push(Math.random() * 100);
    newChart.data.datasets[0].data = newData;
    if (colorList != null || colorList.length > 0) {
        // newChart.data.datasets[0].backgroundColor = getChartColorArray(newData);
    }
    console.log("chart" + newChart);
    newChart.update();
}

function updateChartByParameters(labels, dataList) {//function updateChart(labels, dataList, colors) { 
    var dataTable = $('#do_element_table_' + $("#DisplayObjectId").val()).DataTable();
    var columnNames = [];
    dataTable.columns().header().each(function (header, index) {
        columnNames.push($(header).text());
    });

    for (var i = 0; i < columnNames.length; i++) { // under the prepise that elements of columNames and labels are the same in content but the deference in sequence
        values.push(0);
        for (var j = 0; j < labels.length - 1; j++) {
            if (labels[j] == null) continue;
            if (columnNames[i] == labels[j]) {
                values[i] = dataList[j];
                break;
            }
        }
    }
    newChart.data.datasets[0].data = values;
    if (colorList != null || colorList.length > 0) {
        // newChart.data.datasets[0].backgroundColor = getChartColorArray(values);
    }
    newChart.update();
}

$(function () {
    $(document).on("drop", ".component", function (event) {
        var isClone = event.originalEvent.dataTransfer.getData('dragging');
        var droppedId = event.originalEvent.dataTransfer.getData('dropped-id');
        if (droppedId.includes('ef')) {
            var pickListId = event.originalEvent.dataTransfer.getData('pickListId');
            var columnName = event.originalEvent.dataTransfer.getData('columnName');

            if (pickListId == "-1") {
                console.log("picklist id is -1, so setting value");
                $(event.target).text(columnName);
                $(event.target).val(columnName);
            }
            else {
                GetDropdownListfromPickListId(pickListId).then(function (data) {
                    $(event.target).empty();
                    data.forEach(function (item) {
                        var newOption = $('<option>', {
                            value: item,
                            text: item
                        });
                        $(event.target).append(newOption);
                    });
                });
            }
        }
        event.preventDefault();
    });

    $(document).on("drop", ".workSpace", function (event) {
        var droppedId = event.originalEvent.dataTransfer.getData('dropped-id');
        var nodeCopy = $("#" + droppedId);
        if (droppedId.includes('componentId') == 1) {
            undoStack.push($('.workSpace').html());
            $(this).append(nodeCopy);
            var commontype = $("#" + droppedId).attr('commonbutton');
            nodeCopy.css({
                "position": "absolute",
                "left": event.clientX - $(".workSpace").offset().left,
                "top": event.clientY - $(".workSpace").offset().top
            });
            let dataTable = $('#do_element_table_' + $("#DisplayObjectId").val()).DataTable();
            if (commontype == '4') { //Add
                nodeCopy.click(function (e) {
                    $('#modal-add-EF').modal();
                    $('#EF-row-Content').empty();
                    setEditRowModal(columnList, 'Add');
                });
            } else if (commontype == '5') { //Edit
                if ($("#DisplayObjectType").val() == 1) {
                    nodeCopy.click(function (e) {
                        $('#modal-add-EF').modal();
                        var row = dataTable.row('.selected').data();
                        $('#EF-row-Content').empty();
                        selectedEntityId = row[0];
                        setEditRowModal(columnList, 'Save', row);
                    });
                } else if ($("#DisplayObjectType").val() == 2) {
                    Q.notifyInfo("Edit on InputField.");
                    // nodeCopy.click(function (e) {
                    //     $('#modal-add-EF').modal();
                    //     var row = dataTable.row({ search: 'applied' }).data();
                    //     $('#EF-row-Content').empty();
                    //     selectedEntityId = row[0];
                    //     setEditRowModal(columnList, 'Save', row);
                    // });
                }
            } else if (commontype == '6') { // Delete
                if ($("#DisplayObjectType").val() == 1) {
                    nodeCopy.click(function (e) {
                        if (tableName == null || tableName == "") {
                            Q.notifyWarning("Entity Value Table is undifined.");
                            return;
                        }
                        var row = dataTable.row('.selected').data();
                        if (row == null || row == 'undefined' || row.length == 0) {
                            Q.notifyWarning("No Row is Selected.");
                            return;
                        }
                        let serviceUrl = getCVCServiceUrl(tableName) + '/Delete';
                        showLoader();
                        deleteRowFromDatatable(serviceUrl, row[0])
                            .then(deleteResult => {
                                console.log('ef row delete result = ' + deleteResult);
                                dataTable.rows('.selected').remove().draw();
                                Q.notifyInfo("Row Deletion is Successful.");
                                refreshDataTableAfterDeletion();
                                hideLoader();
                            }).catch(error => {
                                Q.notifyError(tableName + ' table connection is faild.');
                                hideLoader();
                            });// row is array, index = 0: identity
                    });
                } else if ($("#DisplayObjectType").val() == 2) {
                    nodeCopy.click(function (e) {
                        if (tableName == null || tableName == "") {
                            Q.notifyWarning("Entity Field Value Table is undifined.");
                            return;
                        }
                        let row = dataTable.row({ search: 'applied' }).data();
                        if (row == null || row == 'undefined' || row.length == 0) {
                            Q.notifyWarning("No Row is Selected.");
                            return;
                        }
                        let serviceUrl = getCVCServiceUrl(tableName) + '/Delete';
                        showLoader();
                        deleteRowFromDatatable(serviceUrl, row[0])
                            .then(deleteResult => {
                                console.log('ef row delete result = ' + deleteResult);
                                Q.notifyInfo("Row Deletion is Successful.");
                                dataTable.rows('applied').remove().draw();
                                hideLoader();
                            }).catch(error => {
                                Q.notifyError(tableName + ' table connection is faild.' + error);
                                hideLoader();
                            });// row is array, index = 0: identity
                    });
                }
            }
        }
    });

    $(document).on("drop", ".mainDO", function (event) {
        console.log("dropped onto the parent do element");
        var isClone = event.originalEvent.dataTransfer.getData('dragging');
        var droppedId = event.originalEvent.dataTransfer.getData('dropped-id');
        if (droppedId.includes('ef')) {     //if EF is dropped to the grid
            var columnName = event.originalEvent.dataTransfer.getData('columnName');    //get the column name
            var dataTable = $('#do_element_table_' + $("#DisplayObjectId").val()).DataTable();
            let columnIndex = dataTable.columns().header().map(c => $(c).text()).indexOf(columnName);   //get column index from the table
            console.log('columnName :', columnName, 'columnIndex :', columnIndex);
            toggleHeader(columnIndex);  //toggle column, if visible then hidden, if hidden then visible
            if (isRTMachine == true) {
                var isShow = false; // when there is at least one ef shown, isshow is true
                $.each(dataTable.columns().header(), function (index, column) {
                    if (dataTable.column(index).visible()) {
                        isShow = true;
                        return false;  // This will break out of the $.each loop
                    }
                });
                if (isShow) {
                    if (machineId == -1) {
                        Q.notifyWarning("Machine is undifined.");
                        return;
                    } else if (moduleId == -1) {
                        Q.notifyWarning("Module is undifined.");
                        return;
                    }
                    var viewsId = $("#DisplayObjectId").val();
                    showLoader();
                    GetCustomizeRealData(viewsId)     // save the Http Cache
                        .then(data => { // machineData
                            processCustomizePreview(data);
                            hideLoader();
                            // setTimeout(() => {
                            connectToSocket();   // read periodically the data based on cache
                            // }, 3000);
                        }).catch(error => {
                            Q.notifyError("DataBase Connection Faild.");
                            hideLoader();
                        });
                } else {
                    // clearTimeout(timmer);
                }
            }
            return;
        }
        var nodeCopy = $("#" + droppedId);
        var nodeValue = nodeCopy.is('input, select, textarea') ? nodeCopy.val() : nodeCopy.text();
        if (droppedId.includes('componentId') == 1) {
            undoStack.push($('.workSpace').html());

            $(this).append(nodeCopy);
        }

        if (droppedId.includes('do_element') == 1) {
            undoStack.push($('.workSpace').html());

            $(this).append(nodeCopy);
        }
    });

    $(document).on("click", ".removeButton", function () {      //when click xremove button
        undoStack.push($('.workSpace').html());

        $(this).parent().parent().remove();
    });
    ///Clear all
    $("#idDeleteMain").on("click", function (event) {       //delete all button
        undoStack.push($('.workSpace').html());

        $("main").empty();
        rowCount = 0;
    });

    $(".workSpace").on("dragover", function (event) {
        event.preventDefault();
    });

    $('.workSpace').on("drop", function (event) {
        var isClone = event.originalEvent.dataTransfer.getData('dragging');
        var droppedId = event.originalEvent.dataTransfer.getData('dropped-id');
        if (droppedId != "" && droppedId.includes("formId") == 0) {
            var nodeCopy = $("#" + droppedId);
            var nodeValue = nodeCopy.is('input, select, textarea') ? nodeCopy.val() : nodeCopy.text();

            undoStack.push($('.workSpace').html());

            $(this).append(nodeCopy);
        } else {
        }
    });

    $(document).on('click', '#do_element_table_' + $("#DisplayObjectId").val() + ', tbody tr', function (e) {
        let classList = e.currentTarget.classList;
        var table = $("#do_element_table_" + $("#DisplayObjectId").val()).DataTable();
        if (classList.contains('selected')) {
            classList.remove('selected');
        }
        else {
            table.rows('.selected').nodes().each((row) => row.classList.remove('selected'));
            classList.add('selected');
        }
    });

    $(document).on('click', '#modal-add-EF #add-EF-row', function () {
        var dataobj = {};
        var addArr = [];
        var k = 1;
        if ($(this).text() == "Save")
            dataobj[columnList[0]] = selectedEntityId;
        $('#EF-row-Content').find('input').each(function () {
            var val = $(this).val();
            if (val == "null")
                val = null;
            if (columnList[k].toLowerCase() == "createat" || columnList[k].toLowerCase() == "updateat" ||
                columnList[k].toLowerCase() == "createby" || columnList[k].toLowerCase() == "updateby" ||
                columnList[k].toLowerCase() == "createddate" || columnList[k].toLowerCase() == "updateddate")
                dataobj[columnList[k]] = '';
            else
                dataobj[columnList[k]] = val;
            addArr.push(val);
            k++;
        });
        let serviceUrl = getCVCServiceUrl(tableName);
        showLoader();
        if ($(this).text() == "Add") {
            serviceUrl += '/Create';
            addRowToDataTable(serviceUrl, dataobj)
                .then(data => {
                    var addRow = [];
                    addRow.push(data.EntityId);
                    addArr.map(item => addRow.push(item));
                    addNewRow(addRow);
                    Q.notifySuccess("Entity Value Addition is Successful.");
                    hideLoader();
                }).catch(error => {
                    Q.notifyError("DataBase Connection is Faild");
                    hideLoader();
                });
        } else if ($(this).text() == "Save") {
            serviceUrl += '/Update';
            saveRowToDataTable(serviceUrl, dataobj, selectedEntityId)
                .then(data => {
                    var addRow = [];
                    addArr.map(item => addRow.push(item));
                    saveEditRow(addRow);
                    Q.notifySuccess("Entity Value Addition is Successful.");
                    hideLoader();
                }).catch(error => {
                    Q.notifyError("DataBase Connection is Faild");
                    hideLoader();
                });
        }
    });
});

function saveFormRow(rowData,) {
    var dataobj = {};
    var sendArr = [];
    var k = 0;
    selectedEntityId = rowData[0];
    for (var k = 0; k < rowData.length; k++) {
        if (rowData[k] == "null")
            rowData[k] = null;
        // if (k == 0) continue;
        dataobj[columnList[k]] = rowData[k];
        sendArr.push(rowData[k]);
    }
    let serviceUrl = getCVCServiceUrl(tableName);
    showLoader();
    serviceUrl += '/Update';
    saveRowToDataTable(serviceUrl, dataobj, selectedEntityId)
        .then(data => {
            var addRow = [];
            sendArr.map(item => addRow.push(item));
            saveEditRow(addRow);
            Q.notifySuccess("Entity Value Addition is Successful.");
            hideLoader();
        }).catch(error => {
            Q.notifyError("DataBase Connection is Faild");
            hideLoader();
        });
}

function addNewRow(addData) {
    let dataTable = $("#do_element_table_" + $("#DisplayObjectId").val()).DataTable();
    dataTable.row
        .add(addData)
        .draw(false);
}

function saveEditRow(editData) {
    let dataTable = $("#do_element_table_" + $("#DisplayObjectId").val()).DataTable();
    dataTable.row(0).data(editData).draw();
}

function addSearchInputInFooter() {
    let dataTable = $("#do_element_table_" + $("#DisplayObjectId").val()).DataTable();
    if (dataTable.children('tfoot').length)
        return;
    var tfoot = $('<tfoot></tfoot>');
    var footer = $('<tr></tr>');
    tfoot.append(footer);
    dataTable.append(tfoot);

    dataTable.api().columns().every(function () {
        var column = this;
        if (column.visible()) {
            var input = $("<input type='text' style='width:100%;color:black;'>");
            input.keyup(function () {
                if (column.search() !== this.value) {
                    column.search(this.value).draw();
                }
            });
            var th = $('<th></th>');
            th.append(input);
            $(footer).append(th);
        }
    });
}

function setEditRowModal(columnList, buttonName, row = []) {
    var k = 0;
    var efRealRowHtml = '';
    for (var colname of columnList) {
        if (k > 0) {
            var inputType = getHtmlTypeByDBType(columnTypes[k].DataType);
            if (buttonName == "Add")
                efRealRowHtml = efRowHtml.replace("EFnameToChange", colname).replace("type='text'", "type='" + inputType + "'");
            else if ((buttonName == "Save"))
                efRealRowHtml = efRowHtml.replace("EFnameToChange", colname).replace("value=''", "value='" + row[k] + "'").replace("type='text'", "type='" + inputType + "'");
            if (columnList[k].toLowerCase() == "createat" || columnList[k].toLowerCase() == "updateat" ||
                columnList[k].toLowerCase() == "createby" || columnList[k].toLowerCase() == "updateby" ||
                columnList[k].toLowerCase() == "createddate" || columnList[k].toLowerCase() == "updateddate") {
                efRealRowHtml.replace('<input', '<input disabled');
            }
            $('#EF-row-Content').append(efRealRowHtml);
        }
        k++;
    }
    $('#modal-add-EF #add-EF-row').html(buttonName);
}

function refreshDataTableAfterDeletion() {
    let dataTable = $("#do_element_table_" + $("#DisplayObjectId").val()).DataTable();
    var data = dataTable.row(dataTable.page.info().page).data();
    let numCols = dataTable.columns().nodes().length;

    console.log(numCols);
    for (var i = 0; i < numCols; i++) {
        let column = dataTable.column(i);
        if (column.visible()) {
            var htmlstr = "<div class='row' style='justify-content : center;'><div class='col-3'>" + $(column.header()).text() + " :</div><div class='col-3'><input type='' form-do-input='" + i + "' value='" + data[i] + "' /></div></div>";
            htmlstr = htmlstr.replace("type=''", "type='" + getHtmlTypeByDBType(columnTypes[i].DataType) + "'");
            mainDoElement.append(htmlstr);
            var input = "[form-do-input=" + i + "]";
            $(input).keydown(function (event) {
                if (event.keyCode == 13) {
                    var rowData = dataTable.row({ search: 'applied' }).data();
                    var colindex = $(this).attr("form-do-input");
                    rowData[parseInt(colindex)] = this.value;
                    event.preventDefault();
                    saveFormRow(rowData);
                }
            });
        }
    }
    return true;
}

// basic properties mapping to each do
function getDisplayObjectBasicProperties() {
    var viewsId = $("#DisplayObjectId").val();

}