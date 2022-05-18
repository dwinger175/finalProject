using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class mainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    
    public void PlayGame ()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        

    }

    public void Update()
    {

        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        
        
    }

    public void Restart()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
       

    }


}
