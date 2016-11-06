using Orchard.UI.Resources;

namespace MarkBartha.Bootstrap
{
    public class ResourceManifest : IResourceManifestProvider
    {
        public void BuildManifests(ResourceManifestBuilder builder)
        {
            var manifest = builder.Add();

            manifest.DefineStyle("App").SetUrl("/MarkBartha.Bootstrap/Styles/app.css");
        }
    }
}
