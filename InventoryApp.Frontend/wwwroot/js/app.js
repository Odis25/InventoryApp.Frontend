
// Распечатка таблицы оборудования или сотрудников
function Print() {

    const content = document.querySelector('.print-content .mud-table-container').innerHTML;

    let css = '<style type = "text/css">';
    css += `
    table
    {
        font-family: Arial;
        font-size: 0.9em;
        border: 1px solid #333;
        border-collapse: collapse;
        width: 100%;
    }
    table a
    {
        text-decoration: none;
    }
    table th svg
    {
        display: none;
    }
    table th
    {
        font-weight: bold;
    }
    table th, table td
    {
        padding: 5px;
        border: 1px solid #333;
    }`;
    css += '</style>';

    window.frames["print_frame"].document.write(css);
    window.frames["print_frame"].document.write(content);
    window.frames["print_frame"].document.close();
    window.frames["print_frame"].window.print();
}