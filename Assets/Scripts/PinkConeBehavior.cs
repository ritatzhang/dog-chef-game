using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinkConeBehavior : ScoopBehavior
{
    public override void OnMouseDown() {
        Debug.Log("Mouse Click Detected");
        gameplayManager.updateFlavor(2);
    }
}
