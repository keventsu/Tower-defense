using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    
    private bool morto = false;
    public bool muro = false;
    public float speed = 0.1f;
    public float vida = 650;
    public GameObject[] drop;
    public GameObject boss;
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
                

                //animaçao boss morrendo
                GetComponent<Animator>().Play("Die");

                int dropAleatorio = Random.Range(0, drop.Length);
                GameObject value0 = Instantiate(drop[dropAleatorio],boss.gameObject.GetComponent<Rigidbody>().position, Quaternion.Euler(45f,0f,0f));
                GameObject value1 = Instantiate(drop[dropAleatorio],boss.gameObject.GetComponent<Rigidbody>().position, Quaternion.Euler(45f,0f,0f));
                GameObject value2 = Instantiate(drop[dropAleatorio],boss.gameObject.GetComponent<Rigidbody>().position, Quaternion.Euler(45f,0f,0f));
                GameObject value3 = Instantiate(drop[dropAleatorio],boss.gameObject.GetComponent<Rigidbody>().position, Quaternion.Euler(45f,0f,0f));
                GameObject value4 = Instantiate(drop[dropAleatorio],boss.gameObject.GetComponent<Rigidbody>().position, Quaternion.Euler(45f,0f,0f));
                GameObject value5 = Instantiate(drop[dropAleatorio],boss.gameObject.GetComponent<Rigidbody>().position, Quaternion.Euler(45f,0f,0f));

                Destroy(boss,0.5f);
                

            
            }
            if(muro){ 
                // para o boss no muro
                GetComponent<Rigidbody>().transform.Translate(0,0,0);
                GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition | RigidbodyConstraints.FreezeRotation;
            }else{
                GetComponent<Rigidbody>().transform.Translate(Vector3.forward * speed);
                //animaçao boss andando
                GetComponent<Animator>().Play("IdleNormal");
            

            
            }
        }
      

    }
}
