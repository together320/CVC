function form_getDragComponent(icon, form, id) {
    //console.log('make component');
    return `<a class="collapse-item dragFormOrigin" id=${id} draggable='true'>` +
        `<i class="${icon}"></i>` +
        `${form}` +
        `</a >`;
    //`<div class='col-xs-4 col-sm-4 col-md-4 col-lg-4 dragOrigin' style='background-color: #50c72d; border-radius: 8px;display: flex; justify-content: flex-center;padding-top:6px;' value='6 6' draggable='true'>` +
    //`<i style = 'color:#000000' class='fas fa-fw fa-plus'>drag</i>` +
    //`</div>` +
}

function form_getTableCloneComponent(formId, newId, data) {
    var str;

    if (formId.includes("Tables") == 1) {
        str =
            `<table class="forFix">            ` +
            `    <tr>           ` +
            `        <td>1</td> ` +
            `        <td>2</td> ` +
            `        <td>3</td> ` +
            `        <td>4</td> ` +
            `    </tr>          ` +
            `    <tr>           ` +
            `        <td>5</td> ` +
            `        <td>6</td> ` +
            `        <td>7</td> ` +
            `        <td>8</td> ` +
            `    </tr>          ` +
            `    <tr>           ` +
            `        <td>9</td> ` +
            `        <td>10</td>` +
            `        <td>11</td>` +
            `        <td>12</td>` +
            `    </tr>          ` +
            `    <tr>           ` +
            `        <td>13</td>` +
            `        <td>14</td>` +
            `        <td>15</td>` +
            `        <td>16</td>` +
            `    </tr>          ` +
            `    <tr>           ` +
            `        <td>17</td>` +
            `        <td>18</td>` +
            `        <td>19</td>` +
            `        <td>20</td>` +
            `    </tr>          ` +
            `</table>           `;
    } else if (formId.includes('Lists') == 1) {
        str =
            `<ul class="forFix">` +
            `    <li>Item 1</li>` +
            `    <li>Item 2` +
            `        <ul>` +
            `            <li>Subitem 2.1</li>` +
            `            <li>Subitem 2.2</li>` +
            `        </ul>` +
            `    </li>` +
            `    <li>Item 3</li>` +
            `</ul>`;
    } else {
        var classStr = formId.replace(/\d+$/, '');
        str = `<div class="${classStr} forCompany">` +
              `${formId}` + 
              `</div>`;
    }
    return str;
}
