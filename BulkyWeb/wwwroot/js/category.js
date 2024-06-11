
function Delete(id) {
    Swal.fire({
        title: "Are you sure?",
        text: "You won't be able to revert this!",
        icon: "warning",
        showCancelButton: true,
        confirmButtonColor: "#3085d6",
        cancelButtonColor: "#d33",
        confirmButtonText: "Yes, delete it!"
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                url: `/Admin/Category/DeleteConfirmed?id=${id}`,
                type: 'POST',
                success: function (data) {
                    toastr.success(data.message);
                    location.reload();
                },
                error: function(xhr, status, error) {
                    toastr.error("An error occurred: " + error);
                }
            });
        }
    });
}
