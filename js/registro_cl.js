$(document).ready(function() {
	$(".menu_check").click(function(){
      if($("#userName").val() != "" && $("#name").val() != "" && $("#fullName").val() != "" && $("#password").val() != "" && $("#mail").val() != "" && $("#address").val() != "" && $("#phone").val() != "" && $("#implements").val() != "" && $("#city").val() != ""){
         if($("#password").val() == $("#pss").val()){
            var params = {
               "Username": $("#userName").val(),
               "Name": $("#name").val(),
               "Fullname": $("#fullName").val(),
               "Password": $("#password").val(),
               "Email": $("#mail").val(),
               "Address": $("#address").val(),
               "Phone": $("#phone").val(),
               "Items": $("#implements").val(),
               "City": $("#city").val()
            };
            $.ajax({
                  data: params,
                  url: 'http://projectmape.azurewebsites.net/api/Users/',
                  type: 'post',
                  success: function (response) {
                     alert("Usuario creado con éxito");
                     location.href = "index.html";
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

    