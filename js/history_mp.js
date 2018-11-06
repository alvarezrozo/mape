$(document).ready(function() {
  $("#menu_back").click(function(){
    location.href = "home.html?id="+idmaper;
  });
	var idmaper = $.getURLParam("id");
	$.ajax({
	    type: 'GET',
	    dataType: 'json',
	    url: 'http://projectmape.azurewebsites.net/api/Dates/?id='+idmaper+'&parameter=Past',

      	success: function (data) {
			    if(data.length != 0){
      			for(i in data){
         			$(".submenu_container").append("<div class='menu_but'><div class='name_rat_container'><div class='name'><p class='map_name'>"+data[i].MaperName+"</p></div><div class='dates'><p class='map_date'>"+data[i].DateD+"</p></div></div><div class='money'><p class='map_name'>"+data[i].Cost+" $</p></div></div>");
            }
      		}else{
      			alert("No hay citas asignadas");
      			location.href = "home.html?id="+idmaper;
      		}
       		
    	}
	});
});