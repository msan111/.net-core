$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": { url: '/admin/product/getall',
            dataSrc: 'data'},
        "columns": [
            { data: 'title', "width": "25%"},
            { data: 'isbn', "width": "15%"},
            { data: 'listPrice', "width": "10%"},
            { data: 'author', "width": "20%"},
            { data: 'category.name', "width": "15%"},
            { 
                data: 'id',
                "render": function (data) {
                    return `<div class="w-75 btn-group" role="group">
                            <a href="/admin/product/edit?id=${data}" class="btn btn-primary mx-2">
                                <i class="bi bi-pencil-square"></i> Edit
                            </a>
                            <a href="/admin/product/details?id=${data}" class="btn btn-secondary mx-2">
                                <i class="bi bi-trash3"></i> Details
                            </a>
                        </div>`
                },
                "width": "25%"
            }
        ]
    });
}
