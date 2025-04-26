using Godot;
using PrisonBreak.Utilities;

namespace PrisonBreak.Characters.Player;

public partial class Player : CharacterBody3D
{
    // exported variables
    [ExportGroup("mvoement variables")]
    [Export]
    private float _walkSpeed = 5.0f;
    [Export]
    private float _runSpeed = 10.0f;
    [Export]
    private float _gravity = 9.8f;
    [Export]
    private float _crawlSpeed = 3.0f;
    [Export]
    private float _jumpSpeed = 20.0f;
    [Export]
    private float _jumpHeight = 1.0f;

    // variables
    private Vector2 _inputVector = Vector2.Zero;
    private Vector3 _inputDirection = Vector3.Zero;
    private Vector3 _velocity = Vector3.Zero;

    private float _movementSpeed = 0.0f;

    public override void _Ready()
    {
        Input.MouseMode = Input.MouseModeEnum.Captured;
    }

    public override void _PhysicsProcess(double delta)
    {

        if (!IsOnFloor()) { _velocity.Y -= _gravity * (float)delta; }

        Velocity = _velocity;
        MoveAndSlide();
    }

    public override void _Input(InputEvent evt)
    {
        _inputVector = Input.GetVector(
            GameConstants.INPUT_MOVE_LEFT,
            GameConstants.INPUT_MOVE_RIGHT,
            GameConstants.INPUT_MOVE_FORWARD,
            GameConstants.INPUT_MOVE_BACKWARD
        );

        _inputDirection = new Vector3(
            _inputVector.X,
            0.0f,
            _inputVector.Y
        );
        _velocity = Transform.Basis * _inputDirection.Normalized();

        if (Input.IsActionJustPressed(GameConstants.INPUT_JUMP))
        {
            _velocity.Y += _jumpSpeed;
        }

    }

    public override void _UnhandledInput(InputEvent evt)
    {
        if (evt.IsActionPressed(GameConstants.FREE_MOUSE_FOCUS)) { Input.MouseMode = Input.MouseModeEnum.Visible; }
        if (evt.IsActionPressed(GameConstants.GRAB_MOUSE_FOCUS)) { Input.MouseMode = Input.MouseModeEnum.Captured; }
    }

}
