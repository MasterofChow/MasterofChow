
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(Animator))]
public class Player1Controller : MonoBehaviour {


    SpriteRenderer Srend;
    public Animator anim;


    //change these variables if you wish to test different speeds and jump heights
    [SerializeField]
    public float horizontalForce = 1f;
    public float jumpForce = 10f;


    //this variable is used for the screen wrapping
    float screenHalfWidthInWorldUnits;

    bool screenWrap = false;

    float distanceToGround;

    float horizontalMove = 0f;

    void Start()
    {
        Srend = GetComponentInChildren<SpriteRenderer>();
        anim = GetComponentInChildren<Animator>();

        //these lines are used to calculate screen wrapping
        float halfPlayerWidth = transform.localScale.x / 2f;
        screenHalfWidthInWorldUnits = Camera.main.aspect * Camera.main.orthographicSize + halfPlayerWidth;
    }
    // Update is called once per frame
    void Update () {
        //anim.SetBool("idle", true);
        anim.SetBool("MoveRight", false);
        anim.SetBool("MoveLeft", false);
        anim.SetBool("isAttacking", false);

        horizontalMove = Input.GetAxisRaw("Horizontal") * horizontalForce;

        // Debug.Log(horizontalMove);

        distanceToGround = GetComponent<Collider2D>().bounds.extents.y;
        //controller and sprite manipulation
        #region
        //controller and sprite manipulation

        //Debug.Log(isGrounded());

        if (isGrounded()) {
            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(Vector2.up * Time.fixedDeltaTime * jumpForce);
            }
            else
            {

            }
        }
        if (Input.GetKey(KeyCode.D))
        {
            anim.SetBool("lookRight", true);
            anim.SetBool("MoveRight", true);
            transform.Translate(Vector2.right * Time.fixedDeltaTime * horizontalForce);
        }
        else
        {
        }

        if (Input.GetKey(KeyCode.A))
        {
            anim.SetBool("lookRight", false);
            anim.SetBool("MoveLeft", true);
            transform.Translate(Vector2.left * Time.fixedDeltaTime * horizontalForce);
        }
        else
        {
        }       

        if (Input.GetKey(KeyCode.T))
        {
            anim.SetBool("isAttacking", true);
        }


        #endregion // //controls and sprite manipulation
        //camera wrap
        #region
        //controls the camera wrap
        if (screenWrap)
        {


            if (transform.position.x < -screenHalfWidthInWorldUnits)
            {
                transform.position = new Vector2(screenHalfWidthInWorldUnits, transform.position.y);
            }

            if (transform.position.x > screenHalfWidthInWorldUnits)
            {
                transform.position = new Vector2(-screenHalfWidthInWorldUnits, transform.position.y);
            }
        }
        #endregion//camera wrap 
    }
    //make sure u replace "floor" with your gameobject name.on which player is standing
    bool isGrounded()
    {
        return Physics2D.Raycast(transform.position, Vector3.down, distanceToGround);
    }
}

