using Godot;

namespace PrisonBreak.Characters.Abstract
{
    public partial class Character : CharacterBody3D
    {
        [ExportGroup("movement nodes")]

        [Export]
        protected MeshInstance3D characterMeshNode;
        [Export]
        protected AnimationPlayer characterAnimatorNode;
        [Export]
        protected AnimationTree characterAnimationTreeNode;

        // exported variables
        [ExportGroup("movement variables")]
        [Export]
        protected float walkSpeed = 5.0f;
        [Export]
        protected float runSpeed = 10.0f;
        [Export]
        protected float gravity = 9.8f;
        [Export]
        protected float crawlSpeed = 3.0f;
        [Export]
        protected float jumpSpeed = 20.0f;
        [Export]
        protected float jumpHeight = 1.0f;

    }
}