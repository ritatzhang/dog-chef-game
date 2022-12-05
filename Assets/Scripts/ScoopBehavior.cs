using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ScoopBehavior : MonoBehaviour
{
    public int speed = 10;
    private Rigidbody2D characterBody;
    private Vector2 velocity;
    public GameplayManager gameplayManager;

    void Awake(){
        gameplayManager = GameObject.FindObjectOfType<GameplayManager>();
    }

    void Start()
    {
        velocity = new Vector2(speed,speed);
        characterBody = GetComponent<Rigidbody2D>();
    }


    public void move(Vector2 inputMovement) {
        Vector2 delta = inputMovement * velocity * Time.deltaTime;
        Vector2 newPosition = characterBody.position+ delta;
        characterBody.MovePosition(newPosition);
    }

    public abstract void OnMouseDown();
}
