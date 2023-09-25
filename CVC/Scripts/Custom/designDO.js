var totalDataCompany;
var totalDataDisplay;
var totalDataFieldFilter, tempDataFieldFilter;
var do_editor;
var newChart;
var chart_labels = [];

$(document).ready(function () {
});

var formCount = 0; var initFormCount = 0;
var rowCount = 0; var componentCount = 0;

var do_element;
// $(function () {
//    $(".dragOrigin").draggable();
// });

$("#draggable").draggable();

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

    AddUpdateDOF(parameterList).then(function (data) {
    });
}

function dragDO(event) {                   //when dragging main display object
    var newId = `parent_do_element_${$("#DisplayObjectId").val()}`;

    var res;
    var doType = $("#DisplayObjectType").val();
    if (doType == 1) { // DO is list format
        res = `<div style='width:90%; margin:0 auto;'><table id='do_element_table_${$("#DisplayObjectId").val()}' class='displays table-striped table-bordered dt-responsive nowrap' width='100' cellspacing='0'></table></div>`;
    }
    else if (doType == 2 || doType == 3) { // DO is form format
        res = `<div style='width:90%; margin:0 auto;'><div id='do_element_${$("#DisplayObjectId").val()}' style='color:black;padding-top:40px;'></div><table id='do_element_table_${$("#DisplayObjectId").val()}' class='displays table-striped table-bordered dt-responsive nowrap' width='100' cellspacing='0'></table></div>`;
    }
    else if (doType == 4) { //Realtime parameter display
        res = `<div style='width:90%; margin:0 auto;'><div id='do_element_${$("#DisplayObjectId").val()}' style='color:black;padding-top:40px;display:grid;gap:10px;    grid-template-columns: repeat(4, 1fr);'></div><table id='do_element_table_${$("#DisplayObjectId").val()}' class='displays table-striped table-bordered dt-responsive nowrap' width='100' cellspacing='0'></table></div>`;
    }
    else if (doType == 5 || doType == 6) {  //linechart display
        res = `<div style='width:90%; margin:0 auto;'><canvas id='do_element_${$("#DisplayObjectId").val()}' style='display:block;width:100%;max-width:600px;' width='400' height='400'></canvas><table id='do_element_table_${$("#DisplayObjectId").val()}' class='displays table-striped table-bordered dt-responsive nowrap' width='100' cellspacing='0'></table></div>`;
    }
    var nodeCopy = $(res).attr('id', newId).addClass('clones');
    nodeCopy.addClass('my-dragging-class');  // Apply the CSS class with reduced opacity
    $('body').append(nodeCopy);
    event.dataTransfer.setData('dragging', 'no-clone');
    event.dataTransfer.setData('dropped-id', newId);
    event.dataTransfer.setData('type', $("#DisplayObjectType").val());
    event.dataTransfer.setDragImage(nodeCopy[0], 0, 0);
}

function dragEF(event) {                   //when dragging main display object
    event.dataTransfer.setData('dragging', 'no-clone');
    event.dataTransfer.setData('dropped-id', 'ef');
    event.dataTransfer.setData('columnName', $(event.target).attr('columnname'));

    if ($("#DisplayObjectType").val() == 3 || $("#DisplayObjectType").val() == 4 || $("#DisplayObjectType").val() == 5
        || $("#DisplayObjectType").val() == 6) { //if button, realtime format, then the columnName does not exist, so parameterName will use
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

    var nodeCopy = $(res).attr('id', newId).addClass('clones');
    //alert($(nodeCopy).prop('outerHTML'));
    nodeCopy.addClass('my-dragging-class');  // Apply the CSS class with reduced opacity
    //$(nodeCopy).draggable({
    //    handle: ".dragButton"
    //});
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

function toggleHeader(index) { // search, if exist empty, else insert
    let dataTable = $("#do_element_table_" + $("#DisplayObjectId").val()).DataTable();
    let column = dataTable.column(index);
    column.visible(!column.visible());

    if ($("#DisplayObjectType").val() == 1)
        return;

    let mainDoElement = $("#do_element_" + $("#DisplayObjectId").val());
    mainDoElement.empty();

    var data = dataTable.row(dataTable.page.info().page).data();
    let numCols = dataTable.columns().nodes().length;
    chart_labels = [];

    console.log(numCols);
    for (var i = 0; i < numCols; i++) {
        let column = dataTable.column(i);
        console.log($(column.header()).text());
        if (column.visible()) {
            if ($("#DisplayObjectType").val() == 2)
                mainDoElement.append(`<div class='row' style='justify-content : center;'><div class='col-3'>${$(column.header()).text()} :</div><div class='col-3'>${data[i]}</div></div>`);
            if ($("#DisplayObjectType").val() == 3)
                mainDoElement.append(`<button type="button" class="btn btn-app btn-light"><i class="fa fa-play" style="display:block"></i><span style="display:block">${$(column.header()).text().substring(0, 5) + "..."}</span></button>`);
            if ($("#DisplayObjectType").val() == 4)
                mainDoElement.append(`<div class="card-box widget-flat text-white bg-blue" style="background-color:aqua;height:inherit"><i class="fi-tag"></i><span>${$(column.header()).text().substring(0, 5) + "..."}</span></div>`);
            console.log("inserting to chart_label");
            chart_labels.push($(column.header()).text());
        }
    }

    if ($("#DisplayObjectType").val() == 2)
        mainDoElement.insertBefore($("#do_element_table_" + $("#DisplayObjectId").val()));
}

function updateChart() {
    var newData = [];
    newChart.data.labels = chart_labels;
    for (var i = 0; i < chart_labels.length; i++)
        newData.push(Math.random() * 100);
    newChart.data.datasets[0].data = newData;
    newChart.update();
}

$(function () {
    $(document).on("drop", ".rowContainerElement", function (event) {
        var isClone = event.originalEvent.dataTransfer.getData('dragging');
        var droppedId = event.originalEvent.dataTransfer.getData('dropped-id');
        if (droppedId.includes('ef')) {
            var columnName = event.originalEvent.dataTransfer.getData('columnName');
            var dataTable = $('#do_element_table_' + $("#DisplayObjectId").val()).DataTable();
            let columnIndex = dataTable.columns().header().map(c => $(c).text()).indexOf(columnName);
            toggleHeader(columnIndex);
            return;
        }
        var nodeCopy = $("#" + droppedId);
        var nodeValue = nodeCopy.is('input, select, textarea') ? nodeCopy.val() : nodeCopy.text();
        if (droppedId.includes('componentId') == 1) {
            $(this).append(nodeCopy);
        }
        if (droppedId.includes('do_element') == 1) {
            $(this).append(nodeCopy);
            if ($("#DisplayObjectType").val() == 1) { //in case of table
                getTableDataFromDisplayObject($("#DisplayObjectId").val()).then(function (data) {
                    $("#do_element_table_" + $("#DisplayObjectId").val()).empty();
                    var tableHeaders;
                    Object.keys(data[0]).map(function (columnName) {
                        tableHeaders += "<th>" + columnName + "</th>";
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
                        data: dataTableData, // Replace yourDataArray with the fetched data from the server
                        columns: Object.keys(data[0]).map(function (columnName) {
                            return { title: columnName, visible: false };
                        }),
                        dom: 'Bfrtip',
                        altEditor: true,     // Enable altEditor
                        buttons: [{
                            text: 'Add',
                            name: 'add',
                            action: function (e, dt, node, config) {
                                alert('New button clicked');
                            }
                        },
                        {
                            text: 'Edit',
                            name: 'edit',
                            action: function (e, dt, node, config) {
                                alert('Edit button clicked');
                            }
                        },
                        {
                            text: 'Delete',
                            name: 'delete',
                            action: function (e, dt, node, config) {
                                alert('Delete button clicked');
                            }
                        }],
                    });
                });
            }
            if ($("#DisplayObjectType").val() == 2) { //in case of form
                getTableDataFromDisplayObject($("#DisplayObjectId").val()).then(function (data) {
                    $("#do_element_" + $("#DisplayObjectId").val()).empty();
                    $("#do_element_table_" + $("#DisplayObjectId").val()).empty();
                    $("#do_element_table_" + $("#DisplayObjectId").val()).css('display', 'none');

                    var tableHeaders;
                    Object.keys(data[0]).map(function (columnName) {
                        tableHeaders += "<th>" + columnName + "</th>";
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
                        data: dataTableData, // Replace yourDataArray with the fetched data from the server
                        columns: Object.keys(data[0]).map(function (columnName) {
                            return { title: columnName, visible: false };
                        }),
                        dom: 'Bfrtip',
                        altEditor: true,     // Enable altEditor
                        buttons: [{
                            text: 'Add',
                            name: 'add',
                            action: function (e, dt, node, config) {
                                alert('New button clicked');
                            }
                        },
                        {
                            text: 'Edit',
                            name: 'edit',
                            action: function (e, dt, node, config) {
                                alert('Edit button clicked');
                            }
                        },
                        {
                            text: 'Delete',
                            name: 'delete',
                            action: function (e, dt, node, config) {
                                alert('Delete button clicked');
                            }
                        }],
                        pageLength: 1,
                        rowCallback: function (row, data, index) {
                            let mainDoElement = $("#do_element_" + $("#DisplayObjectId").val());
                            mainDoElement.empty();

                            let dataTable = $("#do_element_table_" + $("#DisplayObjectId").val()).DataTable();
                            let numCols = dataTable.columns().nodes().length;
                            for (var i = 0; i < numCols; i++) {
                                let column = dataTable.column(i);
                                if (column.visible()) {
                                    mainDoElement.append(`<div class='row' style='justify-content : center;'><div class='col-3'>${$(column.header()).text()} :</div><div class='col-3'>${data[i]}</div></div>`);
                                }
                            }

                            mainDoElement.insertBefore($("#do_element_table_" + $("#DisplayObjectId").val()));
                        }
                    });
                });
            }
            if ($("#DisplayObjectType").val() == 3 || $("#DisplayObjectType").val() == 4 || $("#DisplayObjectType").val() == 5
                || $("#DisplayObjectType").val() == 6) { //in case of button format
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
                        if ($("#DisplayObjectType").val() == 5 || $("#DisplayObjectType").val() == 6) {
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

                            setInterval(updateChart, 1000);
                        }
                    }
                });
            }
        }
    });

    $(document).on("click", ".removeButton", function () {      //when click xremove button
        $(this).parent().parent().remove();
    });
    ///Clear all
    $("#idDeleteMain").on("click", function (event) {       //delete all button
        $("main").empty();
        rowCount = 0;
    });

    $(".workSpace").on("dragover", function (event) {
        event.preventDefault();
    });

    $('.workSpace').on("drop", function (event) {
        console.log("inserting");
        var isClone = event.originalEvent.dataTransfer.getData('dragging');
        var droppedId = event.originalEvent.dataTransfer.getData('dropped-id');
        if (droppedId != "" && droppedId.includes("formId") == 0) {
            var nodeCopy = $("#" + droppedId);
            var nodeValue = nodeCopy.is('input, select, textarea') ? nodeCopy.val() : nodeCopy.text();
            $(this).append(nodeCopy);
        } else {
        }
    });
});