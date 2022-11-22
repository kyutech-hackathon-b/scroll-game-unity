using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Platformer.Core;
using Platformer.Model;

public class ColorController : MonoBehaviour
{
    readonly PlatformerModel model = Simulation.GetModel<PlatformerModel>();
    void ChangeColor(string colorCode)
    {
        model.player.ChangeColor(colorCode);
    }
}
