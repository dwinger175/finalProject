using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishMove : MonoBehaviour
{
    private int time = 0;
    public GameObject gameObj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObj.transform.Translate(Vector3.forward * Time.deltaTime * 6);



        gameObj.transform.eulerAngles = new Vector3(
        gameObj.transform.eulerAngles.x,
        gameObj.transform.eulerAngles.y + 1,
        gameObj.transform.eulerAngles.z
                                        );



    }
}
