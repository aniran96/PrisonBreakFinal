using Godot;


public partial class SoundManager : Node
{
    #region sound file keys


    #endregion

    #region  sound file dictionaries

    #endregion

    //singleton
    public static SoundManager Instance { get; private set; }

    public override void _Notification(int what)
    {
        base._Notification(what);
        if (what == NotificationSceneInstantiated) { Instance = this; }
    }

    public static void PlayNonPositionalSound(AudioStreamPlayer player, string key)
    {
        player.Stop();
        // player.Stream = .....
        player.Play();
    }

    public static void Play2DPositionalSound(AudioStreamPlayer2D player, string key)
    {
        player.Stop();
        // player.Stream = .....
        player.Play();
    }

    public static void Play3DPositionalSound(AudioStreamPlayer player, string key)
    {
        player.Stop();
        // player.Stream = .....
        player.Play();
    }

}
