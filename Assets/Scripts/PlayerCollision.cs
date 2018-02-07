using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public PlayerMovement movement;
    public Animation runningAnim;
    public AudioSource runningSound;
    public AudioSource hitSound;

    // bool gameHasEnded = false;

    void OnCollisionEnter(Collision collisionInfo)
    {
       if (collisionInfo.collider.tag == "Obstacle")
        {
            hitSound.Play();
            movement.enabled = false;
            runningAnim.enabled = false;
            runningSound.enabled = false;
            Debug.Log("Function executing: EndGame()");
            FindObjectOfType<GameManager>().EndGame();
            Debug.Log("Function passed: EndGame()");
        }
    }


}
