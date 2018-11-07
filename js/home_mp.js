$(document).ready(function() {
  var idmaper = $.getURLParam("id");

  $.ajax({
      type: 'GET',
      dataType: 'json',
      url: 'http://projectmape.azurewebsites.net/api/Dates/?id='+idmaper+'&parameter=Espera',
      success: function (data) {
        if(data.length != 0){
          var cont = 0;
          for(i in data){
            cont++;
          }
          $(".number_not").append(cont);
        }else{
          $(".number_not").append("0");
        }   
      }
  });

  $("#menu_user").click(function(){
    location.href = "user_mp.html?id="+idmaper;
  });
  $( "#service" ).click(function() {
    location.href="requests.html?id="+idmaper;
  });

  $( "#history" ).click(function() {
    location.href="history_mp.html?id="+idmaper;
  });

  $( "#dates" ).click(function() {
    location.href="dates_mp.html?id="+idmaper;
  });

  $( "#rating" ).click(function() {
    location.href="rating_mp.html?id="+idmaper;
  });
});
