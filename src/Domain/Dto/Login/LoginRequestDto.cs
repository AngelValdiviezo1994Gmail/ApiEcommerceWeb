using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiEcommerceWeb.Domain.Dto.Login;

public class LoginRequestDto
{
    public int OrganizationId { get; set; }
    public string LogonName { get; set; }
    public string Password { get; set; }
}