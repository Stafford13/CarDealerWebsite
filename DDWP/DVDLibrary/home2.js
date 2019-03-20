$(document).ready(function () {

      LoadAllDVDLibrary();

});

$('#CreateDvd').on('click', function() {
  clearDVDTable();

  $.ajax ({
    type: 'POST',
    url: 'http://localhost:8080/dvd',
    success: function(data, status) {
      $('#errorMessages').empty();

    },
    error: function(data, status) {

    },
  })
});

$('#Search').on('click', function() {
  $.ajax ({
    type: 'GET',
    url: 'http://localhost:8080/dvd',
    success: function(data, status) {

    },
    error: function(data, status) {

    },
  })
});

$('#edit').on('click', function() {
  $.ajax ({
    type: 'PUT',
    url: 'http://localhost:8080/dvd'+id,
    success: function(data, status) {

    },
    error: function(data, status) {

    },
  })
});

$('#delete').on('click', function() {
  $.ajax ({
    type: 'DELETE',
    url: 'http://localhost:8080/dvd'+id,
    success: function(data, status) {

    },
    error: function(data, status) {

    },
  })
});


// $(document).on('click', '#makePurchase', function (){
//   var total = $('#totalMoneyDisplay').val();
//   var num = $('#itemDisplay').val().substring(0, 1);
//   alert(total+', '+ num);
//   $.ajax({

function LoadAllDVDLibrary() {
clearDVDTable();
var contentRows = $('#contentRows');

  $.ajax ({
    type:'GET',
    url:'http://localhost:8080/dvds/',
    success: function(data, status) {
      $.each(data, function (index, item) {
        var id = item.dvdId;
        var title = item.title;
        var year = item.RealeaseYear;
        var director = item.director;
        var rating = item.rating;

        var row = '<tr>';
            row += '<td>' + title + '</td>';
            row += '<td>' + year + '</td>';
            row += '<td>' + director + '</td>';
            row += '<td>' + rating + '</td>';
            row += '<td onclick="showEditForm(' + id + ')"><a>Edit</a> | onlclick="showDeleteForm(' + id + ')"<a>Delete</a></td>';
            row += '</tr>';
        contentRows.append(row);

        //$('#itemNumber'+id).text(id);
        // $('#itemName'+id).text(title);
        // $('#itemPrice'+id).text(year);
        // $('#itemQuantity'+id).text(director);
        // $('#itemRating'+id).text(rating);
      })
    },
    error: function() {
      $('#errorMessages')
        .append($('<li>')
        .attr({class: 'list-group-item list-group-item-danger'})
        .text('Error calling web service.  Please try again later.'));
    }
  }),

}
