using UnityEngine;

/*
 * Script to perform and grant movement for cubes
 * receives the user inputs and apply the physics to the cubes
 */
public class CubeMovement : MonoBehaviour
{
    //Reference to the rigid body
    private Rigidbody _rigidbody;
    //a Vector to capture the coordinate changes
    private Vector3 _directionChange;
    [Header("Movement speed coefficient for cubes")]
    [SerializeField]
    private float speed;
    
    // Start is called before the first frame update
    private void Start()
    {
        //cache rigid body to avoid too much search in the component tree
        this._rigidbody = GetComponent<Rigidbody>();
        //initial direction value
        _directionChange = Vector3.zero;
    }

    // Update is called once per frame
    private void Update()
    {
        //collect the user input for each axis
        _directionChange.x = Input.GetAxisRaw("Horizontal");
        //using z axis instead of y axis to move over the platform
        _directionChange.z = Input.GetAxisRaw("Vertical");
        CalculateMovement();
    }
    
    
    //Process the movement based on speed coefficient and  
    private void CalculateMovement()
    {
        //Checks if there was any movement
        //Magnitude represents length of a vector, if it is zero, means all coords are zero or not significant 
        if (_directionChange.magnitude > 0)
        {
            //Assign a new position to the cube based on user input direction and preset speed
            //delta time is used in the calc to make it independent of frame-rate
            _rigidbody.MovePosition(transform.position + (_directionChange * speed * Time.deltaTime));    
        }
        
    }

}
