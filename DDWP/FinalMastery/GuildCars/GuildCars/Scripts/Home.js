
    $("#search-button").click(function (event) {
        SearchVehicles();
    });


    function SearchVehicles() {
        $('#results').text("");
        var searchInput = {
            MinYear: $("#minYear").val(),
            MaxYear: $("#maxYear").val(),
            MinPrice: $("#minPrice").val(),
            MaxPrice: $("#maxPrice").val(),
            MakeModel: $("#make-model-input").val()
        }

        $.ajax({
            url: 'http://localhost:63501/api/inventoryapi/SearchNewVehicles',
            type: 'post',
            dataType: 'json',
            contentType: 'application/json',
            success: function (data) {
                $.each(data, function (index, item) {
                    var row = '<div class="border row" style="margin-bottom: 15px;">';

                    row += '<div class="col-md-3">';
                    row += '<h6>' + item.Year + ' ' + item.Make + ' ' + item.Model + '</h6>';
                    row += '<img src="../Images/Inventory-' + item.CarId + '.jpg" style="width: 200px; height: auto;">';
                    row += '</div>';

                    row += '<div class="col-md-3">';
                    row += 'Body Type: ' + item.Style + '<br/>';
                    row += 'Trans: ' + item.Transmission + '<br/>';
                    row += 'Color: ' + item.Color + '<br/>';
                    row += '</div>';


                    row += '<div class="col-md-3">';
                    row += 'Interior: ' + item.Interior + '<br/>';
                    row += 'Mileage: ' + item.Mileage + '<br/>';
                    row += 'VIN #: ' + item.Vin + '<br/>';
                    row += '</div>';


                    row += '<div class="col-md-3">';
                    row += 'Sale Price: $' + item.SalePrice + '<br/>';
                    row += 'MSRP: $' + item.MSRP + '<br/>';
                    row += '<a href="http://localhost:63501/Inventory/Details/' + item.CarId + '" class = "btn btn-dark">Details</a>';
                    row += '</div>';
                    row += '</div>';
                    $('#results').append(row);
                });
            },
            data: JSON.stringify(searchInput)
        });
    }



    $('#searchButton').on('click', function () {
        $('#errorList').empty();

        var searchType = $('#searchButton').val();
        //alert(searchType);
        var isError = false;
        var term = $('#searchTerm').val();
        var minPrice = $('#minPrice').val();
        var maxPrice = $('#maxPrice').val();
        var minYear = $('#minYear').val();
        var maxYear = $('#maxYear').val();

        //alert(term + minPrice + maxPrice + minYear + maxYear)
        if (term == "") {
            term = 'hamster';
        } if (minPrice == "") {
            minPrice = 0;
        } if (maxPrice == "") {
            maxPrice == 999999999;
        } if (minPrice < 0 || maxPrice < 0) {
            $('#errorList').append("<li>Prices must be positive.</li>");
            isError = true;
        } if (minPrice >= maxPrice) {
            $('#errorList').append("<li>Min Price must be lower than Max Price.</li>");
            isError = true;
        } if (minYear > maxYear) {
            $('#errorList').append("<li>Min Year must be lower than Max Year.</li>");
            isError = true;
        } if (isError == false) {
            $('#searchResults').empty();
            $.ajax({
                type: 'GET',
                url: 'http://localhost:63501/api/inventory/search/' + searchType + '/' + term + '/' + minPrice + '/' + maxPrice + '/' + minYear + '/' + maxYear,
                success: function (data) {
                    $.each(data, function (index, item) {
                        var id = item.VehicleId;
                        var year = item.Year;
                        var make = item.Make.MakeName;
                        var model = item.Model.ModelName;
                        var body = item.Body;
                        var trans = item.Transmission;
                        var color = item.ExColor;
                        var interior = item.IntColor;
                        var mileage = item.Mileage;
                        var vin = item.VIN;
                        var price = item.Price;
                        var msrp = item.MSRP;

                        $('#searchResults').append(
                            '<div class=col-lg-12 fields><div class=col-md-3><h4>' + year + ' ' + make + ' ' + model + '</h4><img src=/images/Car1.jpg alt=Oohh shiny style=width:175px;height:100px; /></div><div class=col-md-3><br/><p>' + body + '</p><p>' + trans + '</p><p>' + color + '</p></div ><div class=col-md-3><br/><p>' + interior + ' </p><p>' + mileage + '</p><p>V' + vin + '</p></div><div class=col-md-3><br/><p>' + msrp + '</p><p>' + price + '</p><a href=~/Home/Details class=button1>details</a></div></div> '
                        )
                    })
                    if (data.length == 0) {
                        alert("No Results Found With Selected Parameters.");
                    }
                    else {
                        //alert("Data Length: " + data.length)
                    }
                },
                error: function (xHR) {
                    alert(JSON.stringify(xHR.responseJSON));
                }
            });
        }
    });



    $('#new-link').on('click', function () {
        $('#addFormDiv').show();
    }):

    $('#add-button').on('click', function () {
        $.ajax({
            type: 'POST',
            url: 'http://localhost.me:63501/api/user',
            data: JSON.stringify({
                firstName: $('#add-first-name').val(),
                lastName: $('#add-last-name').val(),
                email: $('#add-email').val(),
                role: $('#add-role').val()
            }),
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },
            'dataType': 'json',
            success: function (data, status) {
                // clear errorMessages
                $('#errorMessages').empty();
                // Clear the form and reload the table
                $('#add-first-name').val('');
                $('#add-last-name').val('');
                $('#add-email').val('');
                $('#add-role').val('');
                loadContacts();
            },
            error: function () {
                $('#errorMessages')
                    .append($('<li>')
                        .attr({ class: 'list-group-item list-group-item-danger' })
                        .text('Error calling web service.  Please try again later.'));
            }
        });
    });

    $('#edit-button').click(function (event) {
        $.ajax({
            type: 'PUT',
            url: 'http://lvh.me:63501/api/user/' + $('#edit-user-id').val(),
            data: JSON.stringify({
                userId: $('#edit-user-id').val(),
                firstName: $('#edit-first-name').val(),
                lastName: $('#edit-last-name').val(),
                email: $('#edit-email').val(),
                role: $('#edit-role').val()
            }),
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },
            'dataType': 'json',
            success: function () {
                // clear errorMessages
                $('#errorMessages').empty();
                hideEditForm();
                loadContacts();
            },
            error: function () {
                $('#errorMessages')
                    .append($('<li>')
                        .attr({ class: 'list-group-item list-group-item-danger' })
                        .text('Error calling web service.  Please try again later.'));
            }
        })
    });
});

function loadContacts() {
    // we need to clear the previous content so we don't append to it
    clearUserTable();

    // grab the the tbody element that will hold the rows of user information
    var contentRows = $('#contentRows');

    $.ajax({
        type: 'GET',
        url: 'http://lvh.me:63501/apu/user',
        success: function (data, status) {
            $.each(data, function (index, user) {
                var name1 = user.firstName;
                var name2 = user.lastName;
                var email = user.email;
                var role = user.role;
                var id = user.userId;

                var row = '<tr>';
                row += '<td>' + name1 + '</td>';
                row += '<td>' + name2 + '</td>';
                row += '<td>' + email + '</td>';
                row += '<td>' + role + '</td>';
                row += '<td><a onclick="showEditForm(' + id + ')">Edit</a></td>';
                row += '<td><a onclick="deleteContact(' + id + ')">Delete</a></td>';
                row += '</tr>';
                contentRows.append(row);
            });
        },
        error: function () {
            $('#errorMessages')
                .append($('<li>')
                    .attr({ class: 'list-group-item list-group-item-danger' })
                    .text('Error calling web service.  Please try again later.'));
        }
    });
}

function clearUserTable() {
    $('#contentRows').empty();
}

function showEditForm(userId) {
    // clear errorMessages
    $('#errorMessages').empty();
    // get the user details from the server and then fill and show the
    // form on success
    $.ajax({
        type: 'GET',
        url: 'http://lvh.me:63501/apu/user' + userId,
        success: function (data, status) {
            $('#edit-first-name').val(data.firstName);
            $('#edit-last-name').val(data.lastName);
            $('#edit-email').val(data.email);
            $('#edit-role').val(data.role);
            $('#edit-user-id').val(data.userId);
        },
        error: function () {
            $('#errorMessages')
                .append($('<li>')
                    .attr({ class: 'list-group-item list-group-item-danger' })
                    .text('Error calling web service.  Please try again later.'));
        }
    });
    $('#userTableDiv').hide();
    $('#editFormDiv').show();
}

function hideEditForm() {
    // clear errorMessages
    $('#errorMessages').empty();
    // clear the form and then hide it
    $('#edit-first-name').val('');
    $('#edit-last-name').val('');
    $('#edit-email').val('');
    $('#edit-role').val('');
    $('#editFormDiv').hide();
    $('#userTableDiv').show();
}

function deleteContact(userId) {
    $.ajax({
        type: 'DELETE',
        url: "http://localhost:63501/apu/user" + userId,
        success: function (status) {
            loadContacts();
        }
    });
}