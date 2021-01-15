"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/bookingHub").build();

connection.on("ReceiveSeat", function (customer,show,id,name, row,col,level,status) {
    var eleshow = document.getElementById("inputshow").value;
    var elecustomer = document.getElementById("inputcustomer").value;
    if (elecustomer !== customer) {
        if (eleshow === show) {
            if (status === 1) {
                document.getElementById(`${row}${col}`).innerHTML = `<span class="checked${level}" id="ghe${id}" ></span>`;
            } else {
                document.getElementById(`${row}${col}`).innerHTML = `<Input type="checkbox" class="seat ghe${level}" id="ghe${id}" data-id="${id}" data-row="${row}" data-col="${col}" data-level="${level}" value="${name}"></Input><label for="ghe${id}"></label>`;
            }

        }
    }
});

connection.start().then(function () {
    console.log('ket noi thanh cong');
}).catch(function (err) {
   
});

$(document).on("change", ".seat", function (event) {
    var stt = $(this)[0].checked;
    var status = 0;
    if (stt) {
        status = 1;
    }
    var id = $(this).data('id');
    var row = $(this).data('row');
    var col = $(this).data('col');
    var level = $(this).data('level');
    var name = $(this).val();
    var show = document.getElementById("inputshow").value;
    var customer = document.getElementById("inputcustomer").value;
    connection.invoke("SelectSeat", customer, show, id, name, row, col, level, status).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
});
