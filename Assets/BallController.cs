using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private Rigidbody sphereRigidBody;
    [SerializeField] private float ballSpeed = 2f;
    [SerializeField] private float jumpForce = 3f;
    [SerializeField] private bool isOnGround = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void MoveBall(Vector2 inputVector){
        Vector3 inputXZPlane = new(inputVector.x,0,inputVector.y);
        sphereRigidBody.AddForce(inputXZPlane * ballSpeed);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            Jump();
        }
    }

    private void Jump()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround= true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = false;
        }
    }
}
