using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ApiEcommerceWeb.Application.Features.Autenticacion.Dto;

public class LoginResponse
{

    [JsonPropertyName("organizationId")]
    public string OrganizationId { get; set; }

    [JsonPropertyName("organizationName")]
    public string OrganizationName { get; set; }

    [JsonPropertyName("authToken")]
    public string AuthToken { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("logonName")]
    public string LogonName { get; set; }

    [JsonPropertyName("email")]
    public string Email { get; set; } = string.Empty;

    [JsonPropertyName("isValid")]
    public bool IsValid { get; set; }

    [JsonPropertyName("picture")]
    public string Picture { get; set; } = null;

    [JsonPropertyName("organizationPicture")]
    public string OrganizationPicture { get; set; } = null;

    [JsonPropertyName("organizationPicture2")]
    public string OrganizationPicture2 { get; set; } = null;

    [JsonPropertyName("organizationUseElectronicDocument")]
    public bool OrganizationUseElectronicDocument { get; set; } = false;
}
