using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reciclavel : MonoBehaviour
{
    public GameObject drop;
    // Start is called before the first frame update
    void Start()
    {
       // GetComponent<Transform>().transform.position.y// position.y = 10; // SetTransformY(10f);
    }

    // Update is called once per frame
    void Update()
    {
        SetTransformY(11f);
    }
    private void OnCollisionStay(Collision other) {
        if(other.gameObject.tag == "Player"){
            

            other.gameObject.GetComponent<Player>().reciclavel += 1;
            other.gameObject.GetComponent<Player>().coletados += 1;
            Destroy(drop);
            
        }
        
    }
    void SetTransformY(float n){
    transform.position = new Vector3(transform.position.x, n , transform.position.z);
}
}
