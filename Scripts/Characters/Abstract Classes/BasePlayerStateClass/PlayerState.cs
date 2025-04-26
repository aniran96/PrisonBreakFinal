using Godot;
using PrisonBreak.Utilities;

namespace PrisonBreak.Characters.Abstract.BasePlayerStateClass
{
    public partial class PlayerState : Node
    {
        public override void _Ready()
        {
            ChangeStateStatus(false);
        }

        public override void _Notification(int what)
        {
            base._Notification(what);

            switch (what)
            {
                case GameConstants.STATE_ENABLED_NOTIFICATION:
                    ChangeStateStatus(true);
                    break;
                case GameConstants.STATE_DISABLED_NOTIFICATION:
                    ChangeStateStatus(false);
                    break;
            }
        }

        protected void ChangeStateStatus(bool flag)
        {
            SetProcess(flag);
            SetPhysicsProcess(flag);
            SetProcessInput(flag);
        }
    }
}