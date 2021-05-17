// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SwervesBar.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "c:\Users\austi\OneDrive\Desktop\SwervesBar\SwervesBarPodcast.github.io\SwervesBar\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\austi\OneDrive\Desktop\SwervesBar\SwervesBarPodcast.github.io\SwervesBar\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Users\austi\OneDrive\Desktop\SwervesBar\SwervesBarPodcast.github.io\SwervesBar\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\Users\austi\OneDrive\Desktop\SwervesBar\SwervesBarPodcast.github.io\SwervesBar\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\Users\austi\OneDrive\Desktop\SwervesBar\SwervesBarPodcast.github.io\SwervesBar\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\Users\austi\OneDrive\Desktop\SwervesBar\SwervesBarPodcast.github.io\SwervesBar\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\Users\austi\OneDrive\Desktop\SwervesBar\SwervesBarPodcast.github.io\SwervesBar\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\Users\austi\OneDrive\Desktop\SwervesBar\SwervesBarPodcast.github.io\SwervesBar\_Imports.razor"
using SwervesBar;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "c:\Users\austi\OneDrive\Desktop\SwervesBar\SwervesBarPodcast.github.io\SwervesBar\_Imports.razor"
using SwervesBar.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/dndArchive")]
    public partial class DndArchive : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "c:\Users\austi\OneDrive\Desktop\SwervesBar\SwervesBarPodcast.github.io\SwervesBar\Pages\DndArchive.razor"
       


    //Added DndEpisode object. Didn't want to flood the page with a lot of table rows for each individual episode.
    // Now all details about the Dnd Episodes are stored in dnd.json file so that we only need to edit the json file
    // dnd.json is in wwwroot folder
    private DndEpisode[] dndEpisodes;

    protected override async Task OnInitializedAsync()
    {
        dndEpisodes = await Http.GetFromJsonAsync<DndEpisode[]>("dnd-episodes/dnd.json");
    }

    public class DndEpisode
    {
        public int Episode { get; set; }
        public string Broadcasters { get; set; }

        public string Link { get; set; }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
