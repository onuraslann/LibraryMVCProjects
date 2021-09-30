$(function () {
    $("#tblBookTypes").DataTable();
    $("#tblBookTypes").on("click", ".btnBookTypeDelete", function () {
        var btn = $(this);
        bootbox.confirm("Kitap türünü silmek istediğinize eminmisiniz ? ", function (result) {
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
    $("#tblOperations").DataTable();
    $("#tblOperations").on("click", ".btnOperationDelete", function () {
        var btn = $(this);
        bootbox.confirm("İşlemi silmek istediğinize eminmisiniz ? ", function (result) {
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
    $("#tblStudent").DataTable()
    $("#tblStudent").on("click", ".btnStudentDelete", function () {
        var btn = $(this);
        bootbox.confirm("Öğrenciyi silmek istediğinize eminmisiniz ? ", function (result) {
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
    $("#tblWriters").dataTable()
    $("#tblWriters").on("click", ".btnWriterDelete", function () {
        var btn = $(this);
        bootbox.confirm("Yazarı silmek istediğinize eminmisiniz ? ", function (result) {
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
$(function () {
    $("#tblBook").DataTable()
    $("#tblBook").on("click", ".btnBookDelete", function () {
        var btn = $(this);
        bootbox.confirm("Kitabı silmek istediğinize eminmisiniz ? ", function (result) {
            if (result) {
                var id = btn.data("id");

                $.ajax({

                    type: "GET",
                    url: "/Book/Delete/" + id,
                    success: function () {

                        btn.parent().parent().remove();
                    }


                });
            }

        });
    });
})