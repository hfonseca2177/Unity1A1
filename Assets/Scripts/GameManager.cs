using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
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
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            InstantiateCube(this.redCub);
        }
    }

    private void InstantiateCube(GameObject cube)
    {
        Instantiate(cube, new Vector3(0, 0, 0), Quaternion.identity);
    }
}
