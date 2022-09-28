using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Muro : MonoBehaviour
{
    public float vidaAtual = 100;
    public float vidaMax = 100;
    public Image barraVida;
    private float timeCount;
    public float danotime = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        AtualizarVida();
    }
    void OnCollisionStay(Collision collisionInfo)
    {
        if(collisionInfo.gameObject.tag == "Inimigo"){
            collisionInfo.gameObject.GetComponent<Enemy>().muro = true;
            timeCount += Time.deltaTime;
            if (timeCount >= danotime )
             {
                vidaAtual -= 5;
                timeCount = 0;
            }

            
        }
        
        
        
           
    }
    private void AtualizarVida(){
        barraVida.fillAmount = vidaAtual / vidaMax;

    }
}
