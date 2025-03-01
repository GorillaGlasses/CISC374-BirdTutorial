using UnityEngine;
using UnityEngine.UIElements;

public class CharacterController : MonoBehaviour
{   public Rigidbody2D MyRigidbody2D;

    public float JumpForce = 10;
    public LogicScript logic;
    public bool birdIsAlive = true;
    public AudioSource music;
    public AudioSource flap;
    public AudioSource pipe;
    public Animation wingFlap;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && birdIsAlive){
            Jump();
        }
    }

    void Jump() {
        wingFlap.Play();
        MyRigidbody2D.linearVelocity = Vector2.up * JumpForce;
        flap.Play();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == 6){
            pipe.Play();
            music.Stop();
            logic.gameOver();
            birdIsAlive = false;
        }
    }
}
