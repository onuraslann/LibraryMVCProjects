$(function () {

    $("#tblBookTypes").on("click", ".btnBookTypeDelete", function () {
        var btn = $(this);
        bootbox.confirm("Markayı silmek istediğinize eminmisiniz ? ", function (result) {
            if (result) {
                var id = btn.data("id");

                $.ajax({

                    type: "GET",
                    url: "/BookType/Delete/" + id,
                    success: function () {

                        btn.parent().parent().remove();
                    }


                });
            }

        });
    });
})
$(function () {

    $("#tblOperations").on("click", ".btnOperationDelete", function () {
        var btn = $(this);
        bootbox.confirm("Markayı silmek istediğinize eminmisiniz ? ", function (result) {
            if (result) {
                var id = btn.data("id");

                $.ajax({

                    type: "GET",
                    url: "/Operation/Delete/" + id,
                    success: function () {

                        btn.parent().parent().remove();
                    }


                });
            }

        });
    });
})
$(function () {

    $("#tblStudent").on("click", ".btnStudentDelete", function () {
        var btn = $(this);
        bootbox.confirm("Markayı silmek istediğinize eminmisiniz ? ", function (result) {
            if (result) {
                var id = btn.data("id");

                $.ajax({

                    type: "GET",
                    url: "/Student/Delete/" + id,
                    success: function () {

                        btn.parent().parent().remove();
                    }


                });
            }

        });
    });
})
$(function () {

    $("#tblWriters").on("click", ".btnWriterDelete", function () {
        var btn = $(this);
        bootbox.confirm("Markayı silmek istediğinize eminmisiniz ? ", function (result) {
            if (result) {
                var id = btn.data("id");

                $.ajax({

                    type: "GET",
                    url: "/Writer/Delete/" + id,
                    success: function () {

                        btn.parent().parent().remove();
                    }


                });
            }

        });
    });
})