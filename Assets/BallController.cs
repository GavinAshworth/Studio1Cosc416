using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private Rigidbody sphereRigidBody;
    [SerializeField] private float ballSpeed = 2f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void MoveBall(Vector2 inputVector){
        Vector3 inputXZPlane = new(inputVector.x,0,inputVector.y);
        sphereRigidBody.AddForce(inputXZPlane * ballSpeed);
    }
}
