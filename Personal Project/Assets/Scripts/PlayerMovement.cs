using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private Rigidbody rb;

    public float speed = 10f;
    private float horizontalInput;
    private float verticalInput;

    private float bottomBound = -17f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();



    }

    // Update is called once per frame
    void Update()
    {   
        // Inputs
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        
        PlayerBoundary();

    }





    private void FixedUpdate()
    {
        // Movement
        rb.AddForce(Vector3.right * speed * horizontalInput);
        rb.AddForce(Vector3.forward * speed * verticalInput);


    }


    void PlayerBoundary()
    {
        // Z-axis bottom boundary 
        if (transform.position.z < bottomBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, bottomBound);
        }
    }


}
