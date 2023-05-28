using System.Text.Json.Serialization;

namespace ApiEcommerceWeb.Application.Features.Clientes.Dto
{
    public class ClientesResponseType
    {
        [JsonPropertyName("mensajeRespuesta")]
        public string MensajeRespuesta { get; set; }
    }
}
