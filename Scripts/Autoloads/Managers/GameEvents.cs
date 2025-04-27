using Godot;

namespace PrisonBreak.Autoloads.Managers;

public partial class GameEvents : Node
{
    //singleton
    public static GameEvents Instance { get; private set; }

    public override void _Notification(int what)
    {
        base._Notification(what);
        if (what == NotificationSceneInstantiated) { Instance = this; }
    }
}
