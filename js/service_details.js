$(document).ready(function() {
	var idclient = $.getURLParam("idClient");
	var idmaper = $.getURLParam("idMaper");
	$.ajax({
	    type: 'GET',
	    dataType: 'json',
	    url: 'http://projectmape.azurewebsites.net/api/Mapers/'+idmaper,
      	success: function (data) {
         	$(".form_container").append("<p class='title_page'>Nombre: <span class='sub-title'>"+data.Fullname+"</span></p><br><p class='title_page'>Tarifa: <span class='sub-title'>"+data.Cost+"</span></p><br><p class='title_page'>Dispone de: <span class='sub-title'>"+data.Items+"</span></p><br><p class='title_page date'>Fecha de la cita: </p><input data-provide='datepicker' id='datepicker'><br><p class='title_page date'>Hora de la cita: </p><select id='format'><option value='08:00'>08:00</option><option value='08:30'>08:30</option><option value='09:00'>09:00</option><option value='09:30'>09:30</option><option value='10:00'>10:00</option><option value='10:30'>10:30</option><option value='11:00'>11:00</option><option value='11:30'>11:30</option></select><br><i class='fas fa-check-circle menu_check'></i>");
         	$("#datepicker").datepicker({ dateFormat: 'dd/mm/yy' });
         	$("#menu_des").click(function(){
         		location.href = "mapers.html?id="+idclient;
         	});
         	$(".menu_check").click(function(){
         		console.log($("#datepicker").val());
         		var params = {
         			"IDClient":idclient,
         			"IDMaper":idmaper,
         			"DateD":$("#datepicker").val(),
         			"DateT":$("#format").val()
         		};
         		$.ajax({
         			data: params,
         			url: 'http://projectmape.azurewebsites.net/api/Dates/',
         			type: 'post',
				    success: function (response) {
			        	alert("Cita asignada con éxito");
    					location.href = "home.html?id="+idclient;
			        }
				});
         	});
    	}
	});
});
