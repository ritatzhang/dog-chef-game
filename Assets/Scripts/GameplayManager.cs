using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameplayManager : MonoBehaviour
{
    private bool win = false;
    private Vector2 inputMovement;
    private PurpleConeMovement purpleCone;
    private GreenConeBehavior greenCone;
    private PinkConeBehavior pinkCone;
    private OrangeConeBehavior orangeCone;
    private int chosenFlavor = -1;

    void Awake(){
        purpleCone = GameObject.FindObjectOfType<PurpleConeMovement>();
        greenCone = GameObject.FindObjectOfType<GreenConeBehavior>();
        pinkCone = GameObject.FindObjectOfType<PinkConeBehavior>();
        orangeCone = GameObject.FindObjectOfType<OrangeConeBehavior>();
    }

    void Update()
    {
        inputMovement = new Vector2 (Input.GetAxisRaw("Horizontal"),0);
    }

    public void updateFlavor(int flavor){
        chosenFlavor = flavor;
    }
    
    public void updateGame(bool gameWin){
        win = gameWin;
    }

    public bool getGameStatus(){
        return win;
    }

    private void FixedUpdate() {
        switch(chosenFlavor)
        {
            case 0:
                purpleCone.move(inputMovement); 
                break;
            case 1:
                greenCone.move(inputMovement);
                break;
            case 2:
                pinkCone.move(inputMovement);
                break;
            case 3:
                orangeCone.move(inputMovement);
                break;
        }
    }
}
