using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Interactor : MonoBehaviour
{
    public LayerMask interactableLayermask = 6;
    public Interactable interactable;
    public Sprite interactImage;
    public Sprite defaultIcon;
    public Sprite defaultInteract;
    public Canvas canvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, 4, interactableLayermask)) 
        {
            if(interactable == null || interactable.ID != hit.collider.GetComponent<Interactable>().ID)
            {
                interactable = hit.collider.GetComponent<Interactable>();
                
               
            
            
            }
           
          
            if (Input.GetKeyDown(KeyCode.E ))
            {

                interactable.onInteract.Invoke();
            }
        }
        
        
    
    }
}
