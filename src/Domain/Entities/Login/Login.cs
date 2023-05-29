using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiEcommerceWeb.Domain.Entities.Login;

public class Login
{
    public int OrganizationId { get; set; }

    public string OrganizationName { get; set; }

    public string AuthToken { get; set; }

    public string Name { get; set; }

    public string LogonName { get; set; }

    public string Email { get; set; } = string.Empty;

    public bool IsValid { get; set; }

    public string Picture { get; set; } = null;

    public string OrganizationPicture { get; set; } = null;

    public string OrganizationPicture2 { get; set; } = null;

    public bool OrganizationUseElectronicDocument { get; set; } = false;
}
