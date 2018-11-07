$(document).ready(function() {
	var idclient = $.getURLParam("id");
  $("#menu_back").click(function(){
    location.href = "home.html?id="+idclient;
  });
	$.ajax({
	    type: 'GET',
	    dataType: 'json',
	    url: 'http://projectmape.azurewebsites.net/api/Mapers/',
      	success: function (data) {
      		
          console.log(data);
       		for(i in data){
         		$(".submenu_container").append("<a href='service_details.html?idClient="+idclient+"&idMaper="+data[i].IDUser+"'><div class='menu_but' id='id_maper_"+data[i].IDUser+"'><div class='name_rat_container'><div class='name'><p class='map_name'>"+data[i].Name+" "+data[i].Fullname+"</p></div><div class='rating'><p class='map_name'>Calificación global: "+data[i].Rating+"</p></div></div><div class='money'><p class='map_name'>"+data[i].Cost+"$</p></div></div></a>");
      		}	
    	}
	});
});
