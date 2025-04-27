using Godot;



public partial class NewGame : Button
{
    private PackedScene MainGame = GD.Load<PackedScene>("res://Scenes/GamePlay/Main.tscn");

    public override void _Ready()
    {
        Pressed += () => GetTree().ChangeSceneToPacked(MainGame);
    }
}
