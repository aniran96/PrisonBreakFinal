using Godot;

namespace PrisonBreak.UI.ScrollOptions;

public partial class VolumeSlider : HSlider
{
    // get up the bus name
    [Export]
    private StringName _busName = "";

    // bus index
    private int _busIndex = 0;

    public override void _Ready()
    {
        _busIndex = AudioServer.GetBusIndex(_busName);

        ValueChanged += HandleVolumeValueChanged;

        Value = AudioServer.GetBusVolumeLinear(_busIndex);
    }

    private void HandleVolumeValueChanged(double value)
    {
        AudioServer.SetBusVolumeDb(_busIndex, (float)value);
    }
}
