using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConeBehavior : MonoBehaviour
{
    // private bool win = false;
    private GameplayManager gameplayManager;

    void Awake(){
        gameplayManager = GameObject.FindObjectOfType<GameplayManager>();
    }

    private void OnTriggerStay2D(Collider2D collision) {
        Debug.Log("touch made");
        gameplayManager.updateGame(true);
    }

    private void OnTriggerExit2D(Collider2D other) {
        Debug.Log("touch left");
        gameplayManager.updateGame(false);
    }
}
