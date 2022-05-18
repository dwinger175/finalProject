using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Collect : MonoBehaviour
{
    public Text scoretext;
    private int toCollect = 3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public void Collected ()
    {
        toCollect--;
        scoretext.text = "Items to Collect : " + toCollect;

        if (toCollect == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
