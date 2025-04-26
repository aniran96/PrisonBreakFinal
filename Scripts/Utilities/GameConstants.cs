using Godot;

namespace PrisonBreak.Utilities;

public partial class GameConstants : Node
{
    public static readonly StringName INPUT_MOVE_LEFT = "move_left";
    public static readonly StringName INPUT_MOVE_RIGHT = "move_right";
    public static readonly StringName INPUT_MOVE_FORWARD = "move_forward";
    public static readonly StringName INPUT_MOVE_BACKWARD = "move_backward";
    public static readonly StringName INPUT_JUMP = "jump";

    public static readonly StringName GRAB_MOUSE_FOCUS = "grab_mouse_focus";
    public static readonly StringName FREE_MOUSE_FOCUS = "free_mouse_focus";

}
