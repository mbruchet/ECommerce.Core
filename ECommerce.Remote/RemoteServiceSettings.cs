namespace ECommerce.Remote
{
    public class RemoteServiceSettings
    {
        public bool IsLocal {get; set;}
        public string Uri {get;set;}
        public AuthenticationSettings Authentication { get; set; }
    }

    public class AuthenticationSettings
    {
        public AuthenticationTypeEnum AuthenticationType { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }

    public enum AuthenticationTypeEnum
    {
        Basic,
        Ntlm,
        Jwt,
        OAuth2,
        None
    }
}
