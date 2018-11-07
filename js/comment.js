$(document).ready(function() {
	var idclient = $.getURLParam("idClient");
	var idmaper = $.getURLParam("idMaper");
   $("#menu_des").click(function(){
      location.href = "mapers.html?id="+idclient;
   });
	$.ajax({
	    type: 'GET',
	    dataType: 'json',
	    url: 'http://projectmape.azurewebsites.net/api/Mapers/'+idmaper,
      	success: function (data) {
            
    	}
	});
});
