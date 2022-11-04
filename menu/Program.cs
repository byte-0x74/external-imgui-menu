using System.Numerics;
using ImGuiNET;

namespace menu;

internal static class Program
{
    private static Render? _render;

    private static bool _open = true;
    
    private static void Main()
    {
        _render = new Render("Demo Window", 750, 500);
        _render.ImguiRender += RenderOnImguiRender;
        _render.RunWindow();
    }

    private static void RenderOnImguiRender()
    {
        //remember to call these before drawing new imgui window
        ImGui.SetNextWindowSize(new Vector2(_render.Width, _render.Height));
        ImGui.SetNextWindowPos(new Vector2(0, 0));

        ImGui.Begin(_render.Title, ref _open,
            ImGuiWindowFlags.NoCollapse | ImGuiWindowFlags.NoDocking | ImGuiWindowFlags.NoResize);
        
        ImGui.TextUnformatted("Hello World");
        ImGui.Button("This is Button");
    }
}