$(document).ready(function() {
   var idmaper = $.getURLParam("id");

   $.ajax({
      type: 'GET',
      dataType: 'json',
      url: 'http://projectmape.azurewebsites.net/api/Mapers/'+idmaper,
      success: function (data) {
         $("#userName").val(data.Username);
         $("#name").val(data.Name);
         $("#fullName").val(data.Fullname);
         $("#password").val(data.Password);
         $("#mail").val(data.Email);
         $("#address").val(data.Address);
         $("#phone").val(data.Phone);
         $("#cost").val(data.Cost);
         $("#pss").val(data.Password);
         $("#implements").val(data.Items);
         $("#city").val(data.City);

      }
   });

	$(".menu_check").click(function(){
      if($("#userName").val() != "" && $("#name").val() != "" && $("#cost").val() != "" && $("#fullName").val() != "" && $("#password").val() != "" && $("#mail").val() != "" && $("#address").val() != "" && $("#phone").val() != "" && $("#implements").val() != "" && $("#city").val() != ""){
         if($("#password").val() == $("#pss").val()){
            var params = {
               "IDUser": idmaper,
               "Username": $("#userName").val(),
               "Name": $("#name").val(),
               "Fullname": $("#fullName").val(),
               "Password": $("#password").val(),
               "Email": $("#mail").val(),
               "Address": $("#address").val(),
               "Phone": $("#phone").val(),
               "Cost": $("#cost").val(),
               "Items": $("#implements").val(),
               "City": $("#city").val()
            };
            $.ajax({
                  data: params,
                  url: 'http://projectmape.azurewebsites.net/api/Mapers/',
                  type: 'put',
                  success: function (response) {
                     alert("Usuario actualizado con éxito");
                     location.href = "home_mp.html?id="+idmaper;
                 }
            });
         }else{
            alert("Verifique que la confirmación de la contraseña coincida con la el campo contraseña");
         }
      }else{
         alert("Verifique que no haya ningún campo vacio");
      }
   });
});

    