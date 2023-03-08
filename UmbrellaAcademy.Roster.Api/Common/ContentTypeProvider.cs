using Microsoft.AspNetCore.StaticFiles;

namespace UmbrellaAcademy.Roster.Api.Common
{
    public static class ContentTypeProvider
    {
        public static FileExtensionContentTypeProvider Default()
        {
            var provider = new FileExtensionContentTypeProvider();
            // Add new mappings
            provider.Mappings[".trx"] = "application/xml";

            return provider;
        }
    }
}
