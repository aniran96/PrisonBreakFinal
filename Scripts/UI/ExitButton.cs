using Godot;

namespace PrisonBreak.UI;

public partial class ExitButton : Button
{
    public override void _Ready()
    {
        Pressed += () => GetTree().Quit();
    }
}
