using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{


    [SerializeField]float movementSpeed = 10f;
    Rigidbody2D rigidBody;
    [SerializeField]int jumpForce = 15;
    int timeBeforeEnd = 5;

    bool isPlayerGrounded;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {

        float horizontalMovement = Input.GetAxis("Horizontal");

        rigidBody.linearVelocity = new Vector2(horizontalMovement * movementSpeed, rigidBody.linearVelocity.y);    

      if(Input.GetButtonDown("Jump") && isPlayerGrounded ==  true)
      {
            rigidBody.linearVelocity =  new Vector2(rigidBody.linearVelocity.x, jumpForce);
            
      }
   
        if(this.gameObject.transform.position.y <= -6f)
        {
            Invoke("EndGame", timeBeforeEnd);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Ground") == true)
        {
            isPlayerGrounded = true;
            float horizontalMovement = Input.GetAxis("Horizontal");

            rigidBody.linearVelocity = new Vector2(horizontalMovement * movementSpeed, rigidBody.linearVelocity.y);
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground") == true)
        {
            isPlayerGrounded = true;
            float horizontalMovement = Input.GetAxis("Horizontal");

            rigidBody.linearVelocity = new Vector2(horizontalMovement * movementSpeed, rigidBody.linearVelocity.y);

        }
    }


    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Ground") == true)
        {
            isPlayerGrounded = false;
            float horizontalMovement = Input.GetAxis("Horizontal");

            rigidBody.linearVelocity = new Vector2(horizontalMovement * movementSpeed, rigidBody.linearVelocity.y);

        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Lion"))
        {
            FirstAidCounter firstAidCounter = GetComponent<FirstAidCounter>();
            ScoreTracker scoreTracker = GetComponent<ScoreTracker>();
            if(firstAidCounter.initialFirst_AidCount == 6 && scoreTracker.startScore == 20)
            {
                Invoke("EndGame", timeBeforeEnd);
            }
            
            
        }
    }

    void EndGame()
    {
        EditorApplication.isPlaying = false;
        Application.Quit();


    }

}
