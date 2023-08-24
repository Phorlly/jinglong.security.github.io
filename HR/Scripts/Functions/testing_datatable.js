$(document).ready(function () {
    $('#example').dataTable({
        ajax: {
            url: "https://jsonplaceholder.typicode.com/todos",
            dataSrc: ""
        },
        columns: [
            {
                data: "id",
            },
            {
                data: "title",
            },
            {
                data: "completed",
                render: function (data) {
                    return data ? 'Yes' : 'No';
                }
            },
            {
                data: "id",
                render: function (data) {
                    return "<button class='btn btn-info btn-sm'>Edit</button>"
                }
            }
        ]
    })
})