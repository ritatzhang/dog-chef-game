using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DogBehavior : MonoBehaviour
{
    public GameObject Dog;
    private GameplayManager gameplayManager;
    private string[] messages = {"something ube would be nice ... ",
                                 "i haven't brushed my teeth in a while ...",
                                 "i love the band red hot chili peppers.",
                                 "feeling a little down, want something bright like the sun."};

    public Text flavorHint;

    void Awake(){
        gameplayManager = GameObject.FindObjectOfType<GameplayManager>();
    }

    // void Start()
    // {
    //     velocity = new Vector2(speed,speed);
    //     characterBody = GetComponent<Rigidbody2D>();
    // }

    // Update is called once per frame
    void Update()
    {
        bool win = gameplayManager.getGameStatus();

        if(win){
            Dog.GetComponent<Animator>().Play("Dog-Win");
        } 
        else {
            Dog.GetComponent<Animator>().Play("Dog-Lose");
        }

        // if(Input.GetButtonDown("Fire1")){
        //     Debug.Log("win");
        //     Dog.GetComponent<Animator>().Play("Dog-Win");
        // } 
        // else if(Input.GetButtonDown("Fire3")) {
        //     Debug.Log("lose");
        //     Dog.GetComponent<Animator>().Play("Dog-Lose");
        // }
        // else if(Input.GetButtonDown("Jump")){
        //     Dog.GetComponent<Animator>().Play("Dog-Default");
        // }
    }
}
