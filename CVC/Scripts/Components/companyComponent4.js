function company_getNameListTable(totalDataCompany, totalDataFieldFilter) {
    var str = "";
    str += `<div id="idCompanyNameList"><h3>The ID and Names of Company</h3>`;
    str +=
        `<table>` +
        `<thead>` +
        `    <tr>`;
    var formId = "formIdSelect";
    for (var filter of totalDataFieldFilter) {
        if (JSON.parse(filter.Need)[formId] == 1) {
            str += `<th>${filter.FieldName}</th>`;
        }
    }
    str +=
        `    </tr>` +
        `</thead>`+
        `<tbody>`;
    totalDataCompany.forEach(function (item) {
        str += `<tr>`;
        for (var filter of totalDataFieldFilter) {
            if (JSON.parse(filter.Need)[formId] == 1) {
                str += `<td>${item[filter.FieldName]}</td>`;
            }
        }
        str += `</tr>`;
    });
    str += `</tbody></table ></div>`;
    return str;
}


function company_getDetail(company, totalDataFieldFilter) {
    var formId = "formIdTable";
    var str = `<div id="idCompanyDetail"> <h3> Detail information of Company</h3>`;

    var filteredArray = totalDataFieldFilter.filter(filter => JSON.parse(filter.Need)[formId] == 1);

    filteredArray.forEach(item => {
        console.log(item.FieldName);
        str += `<div>${item.FieldName} : <input type="text" value="${company[item.FieldName]}"`;
        if (item.FieldName == 'ID') str += `readonly`;
        str += `> </div >`;
    });
    str +=
        `<div><button type="button" id="idSaveCompany" class="btn btn-success">` +
        `    Save Company` +
        `</button></div>`;
    str += `</div>`;
    return str;
}