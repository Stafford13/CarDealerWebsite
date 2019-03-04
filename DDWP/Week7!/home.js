$(document).ready(function () {

      loadWeather();

      // Add Button onclick handler
      $('#add-button').click(function (event) {

          $.ajax({
              type: 'POST',
              url: 'http://api.openweathermap.org/data/2.5/weather?q=London,uk&APPID=d783dbbd98c97a52a5540bb9376e69e2',
              data: JSON.stringify({
                  ZipCode: $('#add-zip-code').val(),
                  City: $('#add-city-name').val(),

              }),
              headers: {
                  'Accept': 'application/json',
                  'Content-Type': 'application/json'
              },
              'dataType': 'json',
              success: function(data, status) {
                  // clear errorMessages
                  $('#errorMessages').empty();
                 // Clear the form and reload the table
                  $('#add-zip-code').val('');
                  $('#add-city-name').val('');
                  loadWeather();
              },
              error: function() {
                  $('#errorMessages')
                     .append($('<li>')
                     .attr({class: 'list-group-item list-group-item-danger'})
                     .text('Error calling web service.  Please try again later.'));
              }
          });
      });
});

function loadWeather() {
    // we need to clear the previous content so we don't append to it
    clearContactTable();

    // grab the the tbody element that will hold the rows of contact information
    var contentRows = $('#contentRows');

    $.ajax ({
        type: 'GET',
        url: 'http://api.openweathermap.org/data/2.5/weather?q=London,uk&APPID=d783dbbd98c97a52a5540bb9376e69e2',
        success: function (data, status) {
            $.each(data, function (index, contact) {
                var zip = location.zipCode;
                var city = location.city;
                var id = location.locationId;

                var row = '<tr>';
                    row += '<td>' + zip + '</td>';
                    row += '<td>' + city + '</td>';
                    row += '<td onclick="showEditForm(' + id + ')"><a>Edit</a></td>';
                    row += '<td><a>Delete</a></td>';
                    row += '</tr>';
                contentRows.append(row);
            });
        },
        error: function() {
            $('#errorMessages')
                .append($('<li>')
                .attr({class: 'list-group-item list-group-item-danger'})
                .text('Error calling web service.  Please try again later.'));
        }
    });
}
