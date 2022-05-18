using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowUI : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject uiObject;




    void Start()
    {
        uiObject.SetActive(false);
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider Player)
    {
        if (Player.gameObject.tag == "Player")
        {
            uiObject.SetActive(true);
          


                    
               


        }
    }

    public void turnOff()
    {
          uiObject.SetActive(false);
          Destroy(gameObject);
         
    }
   
}
