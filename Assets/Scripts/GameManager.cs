using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    [Header("Cub prefab references")]
    [SerializeField]
    private GameObject redCub;
    [SerializeField]
    private GameObject blueCub;
    [SerializeField]
    private GameObject greenCub;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //If press 1 spawn red cube
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            InstantiateCube(this.redCub);
        //If press 2 spawn blue cube
        }else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            InstantiateCube(this.blueCub); 
        //If press 3 spawn green cube    
        }else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            InstantiateCube(this.greenCub);
        }
    }

    private void InstantiateCube(GameObject cube)
    {
        Instantiate(cube, new Vector3(0, 0, 0), Quaternion.identity);
    }
}
