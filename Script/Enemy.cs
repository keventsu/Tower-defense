using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    
    public float speed = 0.1f;
    public bool muro = false;
    public float vida = 100;
    public GameObject enemy;
    public bool morto = false;
    public GameObject drop;
    
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {  
         if (!morto)
        {
        
        
            if(vida <= 0){
                morto = true;
                GetComponent<Animator>().Play("Die");
                


                GameObject value = Instantiate(drop,enemy.gameObject.GetComponent<Rigidbody>().position, Quaternion.Euler(45f,0f,0f));
                Destroy(enemy,0.5f);
                

            
            }
            if(muro){ 
                GetComponent<Rigidbody>().transform.Translate(0,0,0);
                GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition | RigidbodyConstraints.FreezeRotation;
            }else{
                GetComponent<Rigidbody>().transform.Translate(Vector3.forward * speed);
                GetComponent<Animator>().Play("IdleNormal");
            

            
            }
        }
           
    }
    

}
