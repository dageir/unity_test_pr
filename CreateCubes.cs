using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCubes : MonoBehaviour
{

    public GameObject myCube;

    void CreateCube(Vector3 vector3)
    {
        myCube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        myCube.transform.position = vector3;
    }
    // Start is called before the first frame update
    void Start()
    {   
        print("startr creating cube");
        CreateCube(new Vector3(5, 5, 5));
        print("cube is created");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
