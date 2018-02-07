using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public Transform player;
    public Vector3 offset;

	// Update is called once per frame
	void Update () {
        // if not capital T, it means current objs transform.
        // transform.position = player.position; first person follow
        transform.position = player.position + offset;
    }
}
