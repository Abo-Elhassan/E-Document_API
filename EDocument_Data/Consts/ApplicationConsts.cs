using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDocument_Data.Consts
{
    public abstract class ApplicationConsts
    {
        public static string? ConnectionString { get; private set; } = Environment.GetEnvironmentVariable("E-Doc", EnvironmentVariableTarget.User);
        public static string? SecretKey { get; private set; } =  Environment.GetEnvironmentVariable("E-Doc_SK", EnvironmentVariableTarget.User);
        public static string? EmailPassword { get; private set; } = Environment.GetEnvironmentVariable("EP", EnvironmentVariableTarget.User);
        public static string ApiOrigin { get; private set; } = "https://localhost:7206/api";//"https://vm-webportal-t.dpwsapps.com/edoc2.0/api";
        public static string ClientOrigin { get; private set; } = "http://localhost:4200"; //"https://vm-webportal-t.dpwsapps.com/edoc-2.0";
        public static string MappedDrivePath { get; set; } = @"\\10.101.100.109\APP Storage\eDocument\Attachments\";
        public static string ADPath { get; private set; } = "LDAP://spdc.com";
        public static string ADDomain { get; private set; } = "spdc.com";
    }
}
