function modal_getButton(btnValue, modalType, id) {
    var str = 
        `<a type="button" class="collapse-item" data-toggle="modal" data-target="#${id}">` +
        `${btnValue}` +
        `</a>`;
    return str;
}

function modal_getModal(modalTitle, modalType, id, data) {
    var str = "";
    str += 
        `<div class="modal" id="${id}" tabindex="-1" >`+
        `   <div class="modal-dialog">`+
        `       <div class="modal-content">`;

    //Modal Header
    str +=
        `<div class="modal-header">` +
        `    <h4 class="modal-title">${modalTitle}</h4>` +
        `    <button type="button" class="close" data-dismiss="modal">&times;</button>` +
        `</div>`;

    //Modal body
    str += `<div class="modal-body">`;
    if (modalType == "checkbox") {
        console.log('~~~', data);
        str +=
            `<form>` +
            `    <select id="selectMappingType" name="gender">` +
            `        <option value="listMapping" selected>listMapping</option>` +
            `        <option value="detailMapping">detailMapping</option>` +
            `    </select>` +
            `</form>`;

        str += `<hr>`;
        data.forEach(function (item) {
            var temp = JSON.parse(item["Need"]);
            var chked = temp["formIdSelect"] != 2 ? "checked" : "";
            str +=
                `<div class="form-check">` +
                `    <input class="form-check-input" type="checkbox" value="" id="${id}${item["FieldName"]}" ${chked}>` +
                `        <label class="form-check-label" for="${id}${item["FieldName"]}">` +
                `            ${item["FieldName"]}` +
                `        </label>` +
                `</div>`;
        });
    } else if (modalType == "select") {
        str +=
            `<select id="${id}Select" class="form-control">` +
            `    <option value="option1">Option 1</option>` +
            `    <option value="option2">Option 2</option>` +
            `    <option value="option3">Option 3</option>` +
            `</select>`;
    } else if (modalType == "table") {
        str +=
            `<table class="table">` +
            `    <thead>` +
            `        <tr>` +
            `            <th>Firstname</th>` +
            `            <th>Lastname</th>` +
            `        </tr>` +
            `    </thead>` +
            `    <tbody contenteditable="true">` +
            `        <tr>` +
            `            <td>John</td>` +
            `            <td>Doe</td>` +
            `        </tr>` +
            `    </tbody>` +
            `</table>`;
    } else if (modalType == "saveFormat") {
        str +=
            `write the format name : <input class="text"> </input>`;
    }
    str += `</div>`;

    //Modal footer
    str +=
        `<div class="modal-footer">` +
        `    <button type="button" class="btn btn-danger" data-dismiss="modal">Close</button>` +
        `    <button type="button" class="btn btn-primary"> Save changes</button>` +
        `</div>`;
    str +=
        `        </div>` +
        `    </div>` +
        `</div>`;
    return str;
}
