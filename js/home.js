$(document).ready(function() {
	var iduser = $.getURLParam("id");

  $( "#menu_user" ).click(function() {
    location.href="user.html?id="+iduser;
  });

  $( "#service" ).click(function() {
    location.href="mapers.html?id="+iduser;
  });

  $( "#history" ).click(function() {
    location.href="history.html?id="+iduser;
  });

  $( "#dates" ).click(function() {
    location.href="dates.html?id="+iduser;
  });

  $( "#rating" ).click(function() {
    location.href="rating.html?id="+iduser;
  });
});
