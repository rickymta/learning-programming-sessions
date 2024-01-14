$(document).ready(function () {
  $("#register").click(function (e) {
    e.preventDefault();
    Swal.fire("Oopps!", "Email is already exists!", "error");
  });
});
