using UnityEngine;

public class Movement : MonoBehaviour
{


    [SerializeField]float movementSpeed = 10f;
    Rigidbody2D rigidBody;
    [SerializeField]int jumpForce = 15;


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

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Ground") == true)
        {
            isPlayerGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Ground") == true)
        {
            isPlayerGrounded = false;
        }
    }

}
