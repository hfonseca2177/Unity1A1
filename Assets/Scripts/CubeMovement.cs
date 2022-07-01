using UnityEngine;
using UnityEngine.Serialization;

/*
 * Script to perform and grant movement for cubes
 * 
 */
public class CubeMovement : MonoBehaviour
{
    //Reference to the rigid body
    private Rigidbody _rigidbody;
    //a Vector to capture the coordinate changes
    private Vector3 _change;
    [Header("Movement speed coefficient for cubes")]
    [SerializeField]
    private float speed;
    
    // Start is called before the first frame update
    private void Start()
    {
        this._rigidbody = GetComponent<Rigidbody>();
        _change = Vector3.zero;
    }

    // Update is called once per frame
    private void Update()
    {
        //collect the user input for each axis
        _change.x = Input.GetAxisRaw("Horizontal");
        //using z axis instead of y axis to move over the platform
        _change.z = Input.GetAxisRaw("Vertical");
        CalculateMovement();
    }
    
    
    //Process the movement based on speed coefficient and  
    private void CalculateMovement()
    {
        //Checks if there was any movement
        if (_change.magnitude > 0)
        {
            _rigidbody.MovePosition(transform.position + (_change * speed * Time.deltaTime));    
        }
        
    }

}
