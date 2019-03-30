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
                        '<div class=col-lg-12 fields><div class=col-md-3><h4>' + year + ' ' + make + ' ' + model + '</h4><img src=/images/Car1.jpg alt=Oohh shiny style=width:175px;height:100px; /></div><div class=col-md-3><br/><p>' + body + '</p><p>' + trans + '</p><p>' + color + '</p></div ><div class=col-md-3><br/><p>' + interior + ' </p><p>' + mileage + '</p><p>V' + vin + '</p></div><div class=col-md-3><br/><p>' + msrp + '</p><p>' + price +'</p><a href=~/Home/Details class=button1>details</a></div></div> '
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