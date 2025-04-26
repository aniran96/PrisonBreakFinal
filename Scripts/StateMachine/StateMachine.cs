using Godot;
using PrisonBreak.Utilities;

public partial class StateMachine : Node
{
    [Export]
    private Node _currentState;
    [Export]
    private Node[] _states;

    public void ChangeState<T>()
    {
        Node nextState = null;

        foreach (Node state in _states)
        {
            if (state is T)
            {
                nextState = state;
            }
        }
        if (nextState == null)
        {
            return;
        }
        _currentState._Notification(GameConstants.STATE_DISABLED_NOTIFICATION);

        _currentState = nextState;

        _currentState._Notification(GameConstants.STATE_ENABLED_NOTIFICATION);
    }

}
