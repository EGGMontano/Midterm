using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
    [SerializeField] Transform target;
    private Rigidbody _Rigidbody;

    private Vector3 moveInput;

    private void Awake()
    {
        TryGetComponent(out _Rigidbody);
    }

    private void Update()
    {
        moveInput = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
    }

    private void FixedUpdate()
    {
        _Rigidbody.position += moveInput * moveSpeed;
    }
}
