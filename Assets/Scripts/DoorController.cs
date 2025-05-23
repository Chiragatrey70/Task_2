using UnityEngine;

public class DoorController : MonoBehaviour
{
    private Vector3 closedPosition;
    private Vector3 openPosition;
    public float openDistance = 3f;
    public float moveSpeed = 2f;
    private bool isOpen;

    void Start() => closedPosition = transform.position;

    void Update()
    {
        openPosition = closedPosition + Vector3.up * openDistance;
        Vector3 target = isOpen ? openPosition : closedPosition;
        transform.position = Vector3.Lerp(transform.position, target, moveSpeed * Time.deltaTime);
    }

    public void OpenDoor() => isOpen = true;
    public void CloseDoor() => isOpen=false;
}