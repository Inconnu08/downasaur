using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;

    public float forwardForce = 1000f;
    public float sidewaysForce = 500f;

    private float screenCenterX;

    void Start () {
        // save the horizontal center of the screen
        screenCenterX = Screen.width * 0.5f;
    }
	
	// Unity likes physics related updates in FU
	void FixedUpdate () {
        // add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        // right side movement
        if (Input.GetKey("d"))
        {
            rb.AddForce(200 * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        // left side movement
        if (Input.GetKey("a"))
        {
            rb.AddForce(-200 * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(0, 10000 * Time.deltaTime, 0);
        }
        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }

    void Update()
    {
        // if there are any touches currently
        if (Input.touchCount > 0)
        {
            // get the first one
            Touch firstTouch = Input.GetTouch(0);

            // if it began this frame
            if (firstTouch.phase == TouchPhase.Began)
            {
                if (firstTouch.position.x > screenCenterX)
                {
                    // if the touch position is to the right of center
                    // move right
                    rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
                }
                if (firstTouch.position.x < screenCenterX)
                {
                    // if the touch position is to the left of center
                    // move left
                    rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
                }
            }
        }
    }
}
