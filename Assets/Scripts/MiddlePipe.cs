using System;
using UnityEngine;

public class MiddlePipe : MonoBehaviour
{
    public LogicScript logic;
    public CharacterController bird;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        bird = GameObject.FindGameObjectWithTag("Bird").GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 3 && bird.birdIsAlive){
            logic.addScore(1);
        }
    }
}
