using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawn : MonoBehaviour
{

    public Text stageTxt;
    public GameObject[] inimigos;
    public GameObject boss;
    public GameObject player;
    public Transform[] pontosDeSpawn;
    //public GameObject prefab;
    public float spawntime = 5;
    public float nextStage = 20;
    private float timeCount;
    public int numInimigos = 5;
    public int numInimigosfase = 5;
    public int numInimigosMortos = 0;

    public bool chefao = false;

    public int stage =1;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        numInimigosMortos = player.gameObject.GetComponent<Player>().coletados;
        timeCount += Time.deltaTime;
        
        if (timeCount >= spawntime )
        {
            if(numInimigos > 0){
                Spawner();
                timeCount = 0f;
                numInimigos -= 1;
                
            }
           
        }
        if (numInimigos == 0 && numInimigosMortos == numInimigosfase)
        {
            stage += 1;
            stageTxt.text = stage.ToString();
            player.gameObject.GetComponent<Player>().coletados = 0;
            numInimigosfase += 1;
            numInimigos = numInimigosfase;
            
           
            

            
           


            
        }

        
        
    }
    private void Spawner(){
        int inimigoAleatorio = Random.Range(0, inimigos.Length);
        int pontoAleatorio = Random.Range(0, pontosDeSpawn.Length);

        Instantiate(inimigos[inimigoAleatorio],pontosDeSpawn[pontoAleatorio].position, Quaternion.Euler(0f,-90f,0f));

    }
    private void BossSpawner(){
       chefao = true;

        Instantiate(boss,pontosDeSpawn[0].position, Quaternion.Euler(0f,-90f,0f));

    }
    public bool VerificaStage(int valor)
{
   int resultado = valor % 5;
   if(resultado.Equals(0))
   {
      return true;
   }
   else
   {
      return false;
   }
}
}
