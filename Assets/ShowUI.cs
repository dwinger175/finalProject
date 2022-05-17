using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowUI : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject uiObject;
    private int n = 0;
    public float offsetTime = 4f;
    private float timer = 1f;


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
            Debug.Log("UI Active");

            if (uiObject.activeSelf)
            {
                timer += Time.deltaTime;
                if (timer > offsetTime)
                {
                   
                   
                    timer = 0f;
                }




            }


                    
               


        }
    }

    public void turnOff()
    {
          uiObject.SetActive(false);
          Destroy(gameObject);
          Debug.Log("UI Active");
    }
   
}
