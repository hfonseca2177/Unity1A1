using UnityEngine;

/**
 * Game manager that receives and process the user spawn options
 */
public class GameManager : MonoBehaviour
{
    
    [Header("Cub prefab and variants references")]
    [SerializeField]
    private GameObject redCub;
    [SerializeField]
    private GameObject blueCub;
    [SerializeField]
    private GameObject greenCub;

    // Update is called once per frame
    void Update()
    {
        //If press 1 spawn red cube
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            InstantiateCube(ref this.redCub);
        //If press 2 spawn blue cube
        }else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            InstantiateCube(ref this.blueCub); 
        //If press 3 spawn green cube    
        }else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            InstantiateCube(ref this.greenCub);
        }
    }
    //Instantiate the desired cube prefab
    private void InstantiateCube(ref GameObject cube)
    {
        Instantiate(cube, new Vector3(0, 5, 0), Quaternion.identity);
    }
}
