using Godot;

namespace PrisonBreak.Utilities;

public partial class GameConstants : Node
{
    // inputs
    public static readonly StringName INPUT_MOVE_LEFT = "move_left";
    public static readonly StringName INPUT_MOVE_RIGHT = "move_right";
    public static readonly StringName INPUT_MOVE_FORWARD = "move_forward";
    public static readonly StringName INPUT_MOVE_BACKWARD = "move_backward";
    public static readonly StringName INPUT_JUMP = "jump";

    public static readonly StringName GRAB_MOUSE_FOCUS = "grab_mouse_focus";
    public static readonly StringName FREE_MOUSE_FOCUS = "free_mouse_focus";

    // animation names
    public static readonly StringName ANIM__LOCKED = "locked";
    public static readonly StringName ANIM__IDLE = "idle";
    public static readonly StringName ANIM__WALK = "walk";
    public static readonly StringName ANIM__RUN = "run";
    public static readonly StringName ANIM__JUMP = "jump";
    public static readonly StringName ANIM__FALL = "fall";
    public static readonly StringName ANIM__DASH = "dash";
    public static readonly StringName ANIM__CRAWL = "crawl";

    // state notification 
    public const int STATE_ENABLED_NOTIFICATION = 5001;
    public const int STATE_DISABLED_NOTIFICATION = 5002;

}
