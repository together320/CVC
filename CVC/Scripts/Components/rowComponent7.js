var row_Drag =  "<div class='row' style='padding:1px;'>" +
                            "<div class='col-xs-1 col-sm-1 col-md-1 col-lg-1'>" +
                            "</div>" +
                            "<div class='col-xs-6 col-sm-6 col-md-6 col-lg-6'>" +
                            "<input type = 'text' value='6 6' style='width:100%' readonly/>" +
                            "</div>" +
                            "<div class='col-xs-4 col-sm-4 col-md-4 col-lg-4 dragOrigin' style='background-color: #50c72d; border-radius: 8px;display: flex; justify-content: flex-center;padding-top:6px;' value='6 6' draggable='true'>" +
                            "<i style = 'color:#000000' class='fas fa-fw fa-plus'>drag</i>" +
                            "</div>" +
                            "</div>";
function row_GetRowStrs(param) 
{
    return row_Drag.Replace("6 6/g", param);
}

var row_Element =  "<div class='row' style='padding:1px;'>" +
                            "<div class='col-xs-1 col-sm-1 col-md-1 col-lg-1'>" +
                            "</div>" +
                            "<div class='col-xs-6 col-sm-6 col-md-6 col-lg-6'>" +
                            "<input type = 'text' value='6 6' style='width:100%' />" +
                            "</div>" +
                            "<div class='col-xs-4 col-sm-4 col-md-4 col-lg-4 dragOrigin' style='background-color: #50c72d; border-radius: 8px;' value='6 6' draggable='true'>" +
                            "<i style = 'color:#000000' class='fas fa-fw fa-plus'>drag</i>" +
                            "</div>" +
                            "</div>";
function row_GetRowCloneStrs(param, id, value)
{
    console.log('param = ' + param);
    console.log('i = ' + id);
    console.log('param = ' + value);
    //str = `<div class='row workSpace clones rowcontainer' draggable='true' id='${id}' value='${value}'>`;
    ////console.log('str = ' + str);
    //var numbers = param.split(' ');

    //numbers.forEach(function (number) {
    //    //console.log(number);
    //    str += `<div class='col-${number} rowContainerElement'> </div>`;
    //});
    //str += "</div>";

    str = `<div class="workSpace clones" style="border:1px solid black;margin:5px;" draggable="true" value="${value}" ondragstart='dragClonedGrid(event);'>`;
    str += `<div style="display: flex; justify-content: space-between;">`;
    /*str += `<button class="dragButton">+drag</button>`;*/
    var number = id.match(/\d+$/)[0];
    str += `<div class="circleNumber">${number}</div>`;
    str += `<button class="removeButton">Xremove</button>`;
    str += `</div >`;
    str += `<div class="row" style="margin:5px;">`;
    var numbers = param.split(' ').filter(item => item !== "");;
    numbers.forEach(function (number) {
        str += `<div class='col-${number} rowContainerElement' style="overflow: auto;"> </div>`;
    });
    str += `</div>`;
    str += `</div>`;

    console.log('str = ' + str);
    return str;
}