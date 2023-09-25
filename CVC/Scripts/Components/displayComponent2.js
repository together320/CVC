function display_getAllDisplayNames(totalDataDisplay, displayName) {
    var str = ``;
    totalDataDisplay.forEach(function (item) {
        if (displayName == "" || item["DisplayName"] == displayName) {
            str += `<a class="collapse-item" value='${item["DisplayName"]}'>`;
            str += `${item["DisplayName"]}`;
            str += `</a>`;
        }
    });
    return str;
}

function display_showDisplayWithNames(totalDataDisplay, nameId) {
    var str;

    if (formId.includes("Tables") == 1) {
        str =
            `<table>            ` +
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
            `<ul>` +
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
        str = `<div>` +
            `${formId}` +
            `</div>`;
    }
    return str;
}
