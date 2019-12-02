using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject testObj;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began) {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit rayhit = new RaycastHit();

            if (Physics.Raycast(ray, out rayhit)){
                GameObject hitThing = rayhit.collider.gameObject;
                Renderer rend = hitThing.GetComponent<Renderer>();
                Material material = new Material(Shader.Find("Standard"));
                material.color = Color.green;
                rend.material = material;

            }
        }
    }
}
