using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    private float speed = 1;
    public GameObject bala;
    

    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
      transform.position += transform.forward * speed;
      Destroy(bala, 3f);
    }
   private void OnCollisionEnter(Collision collisionInfo) {

     if(collisionInfo.gameObject.tag == "Inimigo"){
         collisionInfo.gameObject.GetComponent<Enemy>().vida -= 34;
         Destroy(bala);
      }
      if(collisionInfo.gameObject.tag == "Boss"){
         collisionInfo.gameObject.GetComponent<Boss>().vida -= 34;
         Destroy(bala);
      }
      
      
    
   }
    
}
