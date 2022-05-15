using UnityEngine;

public class Player : MonoBehaviour
{
    private float speed = 10f;
    private Rigidbody playerRigidBody;
    
    void Start()
    {
        //Null 처리 어떻게 함?
        playerRigidBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputZ = Input.GetAxis("Vertical");
        float fallSpeed = playerRigidBody.velocity.y;

        Vector3 velocity = new Vector3(inputX, 0, inputZ);
        velocity = velocity * speed;
        velocity.y = fallSpeed;

        playerRigidBody.velocity = velocity;
    }
}
