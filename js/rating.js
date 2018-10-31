$(document).ready(function() {
	var idclient = $.getURLParam("id");
	$.ajax({
	    type: 'GET',
	    dataType: 'json',
	    url: 'http://projectmape.azurewebsites.net/api/UsersComments/?id='+idclient,
      success: function (data) {
  			if(data.length != 0){
          var prom = 0;
          var cont = 0;
    			for(i in data){
            prom += data[i].Value;
            cont++;
       		 $(".submenu_container").append("<div class='menu_but'><div class='name_rat_container'><p class='map_name'>"+data[i].Comment+"</p></div><div class='score'><p class='value'>Calificación: "+data[i].Value+"</p></div></div>");  
          }
          prom /= cont;
          $(".global_container").append("<p class='global_text'>Puntaje global "+ Math.round(prom*10)/10 +"</p>");
        }else{
    			alert("Usted no tiene comentarios");
    			location.href = "home.html?id="+idclient;
    		}		
    	}
	});
});