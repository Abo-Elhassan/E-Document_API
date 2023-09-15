using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDocument_Data.Consts
{
    public abstract class ApplicationConsts
    {
        public static string? ConnectionString { get; private set; } = Environment.GetEnvironmentVariable("eDoc", EnvironmentVariableTarget.Machine);
        public static string? SecretKey { get; private set; } = Environment.GetEnvironmentVariable("eDoc_SK", EnvironmentVariableTarget.Machine);
        public static string? EmailPassword { get; private set; } = Environment.GetEnvironmentVariable("EP", EnvironmentVariableTarget.User);
        public static string ClientOrigin { get; private set; } = "https://localhost:4200";
        public static string ADPath { get; private set; } = "LDAP://spdc.com";
        public static string ADDomain { get; private set; } = "spdc.com";
    }
}
