$(document).ready(function() {
  $("#menu_back").click(function(){
    location.href = "home_mp.html?id="+idmaper;
  });
	var idmaper = $.getURLParam("id");
	$.ajax({
	    type: 'GET',
	    dataType: 'json',
	    url: 'http://projectmape.azurewebsites.net/api/Dates/?id='+idmaper+'&parameter=Espera',
      success: function (data) {
          if(data.length != 0){
      			for(i in data){
         			$(".submenu_container").append("<div class='menu_but'><div class='name_rat_container'><div class='name'><p class='map_name'>"+data[i].MaperName+"</p></div><div class='dates'><p class='map_date'>"+data[i].DateD+"</p></div></div><div class='icos'><i class='ico_sub fas fa-times-circle not' id='dn_"+data[i].IDDate+"'></i><i class='ico_sub fas fa-check-circle yes' id='dy_"+data[i].IDDate+"'></i></div></div>");
            }

            $(".not").click(function() {
              var elementID = $(this).attr("id");
              var elementDef = elementID.split("_"); 
              var idDate = elementDef[1];
              var paramsR = {
                "IDDate":idDate,
                "Status":"Rechazada"
                };
              $.ajax({
                    type: 'PUT',
                    data: paramsR,
                    url: 'http://projectmape.azurewebsites.net/api/Dates/',
                    success: function (response) {
                      alert("Cita rechazada con éxito");
                      location.href = "home_mp.html?id="+idmaper;
                    }
              });
            });

            $(".yes").click(function() {
              var elementID = $(this).attr("id");
              var elementDef = elementID.split("_"); 
              var idDate = elementDef[1];
              var paramsA = {
                "IDDate":idDate,
                "Status":"Aceptada"
                };
              $.ajax({
                    type: 'PUT',
                    data: paramsA,
                    url: 'http://projectmape.azurewebsites.net/api/Dates/',
                    success: function (response) {
                      alert("Cita aceptada con éxito");
                      location.href = "home_mp.html?id="+idmaper;
                    }
              });
            });
      		}else{
      			alert("No hay solicitud asignadas");
      			location.href = "home.html?id="+idmaper;
      		}
       		
    	}
	});
});