using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Transform player;
    [SerializeField] private float aheadDistance;
    [SerializeField] private float cameraSpeed;

    //-----------------
    private float PosX;
    private Vector3 velocity = Vector3.zero;
    private float lookAhead;

    //-----------------
    private void Update()
    {
        transform.position = new Vector3(player.position.x, transform.position.y, transform.position.z);
        lookAhead = Mathf.Lerp(lookAhead, (aheadDistance * player.localScale.x), Time.deltaTime * cameraSpeed);
    }
}
