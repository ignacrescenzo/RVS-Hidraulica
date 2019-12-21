var nombre = $("#nombre");
var email = $("#email");
var tipoMensaje = $("#tipoMensaje");
var mensaje = $("#mensaje");
var btnEnviar = $("#btnEnviar");

btnEnviar.click(function() {
    if (validar()) {
        var obj = {};
        obj.nombre = nombre.val();
        obj.email = email.val() === "" ? null : email.val();
        obj.tipoMensaje = tipoMensaje.val();
        obj.mensaje = mensaje.val();
        alertify.message("Cargando...");
        $.ajax({
            url: window.pathEnviarMensaje,
            data: JSON.stringify(obj),
            success: envioMensajeOk,
            type: "POST",
            error: envioMensajeError,
            dataType: "json",
            contentType: "application/json; charset=utf-8"
        });
    }
});


function envioMensajeOk() {
    alertify.success("Mensaje enviado correctamente!");
    nombre.val("");
    email.val("");
    tipoMensaje.val(0);
    mensaje.val("");
}
function envioMensajeError() {
    alertify.error("Ha ocurrido un error al enviar el mensaje. Inténtelo nuévamente.")
}

function validar() {
    return validarCampoObligatorio(nombre, "Debe ingresar su nombre") &&
        validarCampoObligatorio(tipoMensaje, "Debe ingresar el tipo de mensaje") &&
        validarCampoObligatorio(mensaje, "Debe ingresar un mensaje");
}


function validarCampoObligatorio(input, msg) {
    if (input.val() == "" && input.parent().find(".must").length === 0) {
        var div = $("<div class='must my-1'>");
        div.text(msg);
        div.css("color", "red");
        div.css("font-size", "10px");
        input.css("outline", "1px solid red");
        input.parent().append(div);
        return false;
    } else {
        if (input.val() != "") {
            input.parent().find(".must").remove();
            input.css("outline", "none");
            return true;
        }
    }
}
$(".carousel").slick({
    dots: true,
    infinite: true,
    speed: 500,
    fade: true,
    autoplay: true,
    cssEase: 'linear'
});

