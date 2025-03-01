using UnityEngine;

public class BoundryScript : MonoBehaviour
{
    public CharacterController bird;
    public LogicScript logic;
    public AudioSource music;
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
            music.Stop();
            logic.gameOver();
            bird.birdIsAlive = false;
        }
    }
}
