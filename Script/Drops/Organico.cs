using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Organico : MonoBehaviour
{
    public GameObject drop;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SetTransformY(20f);
    }
     
    private void OnCollisionStay(Collision other) {
        if(other.gameObject.tag == "Player"){
        

            other.gameObject.GetComponent<Player>().organico += 1;
            other.gameObject.GetComponent<Player>().coletados += 1;
            Destroy(drop);
            
        }
        
    }
    void SetTransformY(float n){
    transform.position = new Vector3(transform.position.x, n , transform.position.z);
    transform.rotation = Quaternion.Euler(-10f,0,-45f);
    }



}
