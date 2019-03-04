$(document).ready(function () {

    loadContacts();

});

function loadContacts() {
  clearContactTable();
  var contentRows = $('#contentRows');

  $.ajax({
    type: 'GET',
    url: 'http://lvh.me:8080/contacts',
    success: function(data, status) {
       $.each(data, function(index, contact) {
         var name = contact.firstName + ' ' + contact.lastName;
         var company = contact.company;
         var id = contact.contactId;

         var row = '<tr>';
             row += '<td>' + name + '</td>';
             row += '<td>' + company + '</td>';
             row += '<td><a>Edit</a></td>';
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

function clearContactTable() {
    $('#contentRows').empty();
  }
