using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalVariables : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 clickedLocation;

    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    //Variables setting


    public Vector3 getClickedLocation()
    {
        return clickedLocation;
    }

    public void setClickedLocation(Vector3 location)
    {
        clickedLocation = location;
    }


}
