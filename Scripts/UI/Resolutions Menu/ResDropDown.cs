using System;
using System.Collections.Generic;
using Godot;

public partial class ResDropDown : OptionButton
{

    // resolution options
    private Dictionary<string, Vector2I> _resolutionOptions = new Dictionary<string, Vector2I>
    {   { "540 x 960", new Vector2I(540,960) },
         {"1152 x 648", new Vector2I(1152, 648) },
         { "1280 x 720", new Vector2I(1280,720)},
         { "1366 x 768", new Vector2I(1366, 768)},
         { "1600 x 900", new Vector2I(1600, 900) },
         { "1920 x 1080", new Vector2I(1920, 1080)}
    };

    public override void _Ready()
    {
        foreach (var key in _resolutionOptions.Keys)
        {
            AddItem(key);
        }

        ItemSelected += HandleItemSelected;
    }

    private void HandleItemSelected(long index)
    {
        var resChoice = GetItemText((int)index);
        var screenSize = _resolutionOptions[resChoice];
        DisplayServer.WindowSetSize(screenSize);

    }
}