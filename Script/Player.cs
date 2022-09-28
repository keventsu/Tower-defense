using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public FixedJoystick joystikPlayer;
    public Text org,rec;
    public double vida = 3;
    public double speed;
    public GameObject canhao;

    public int organico,reciclavel;
    public int coletados;
    
     public GameObject spawner;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        org.text = organico.ToString();
        rec.text = reciclavel.ToString();
        if (joystikPlayer.Horizontal > 0)
        {
            GetComponent<Animator>().SetFloat("Turn",joystikPlayer.Horizontal);
            player.transform.Rotate(Vector3.up * 0.30f,Space.Self);
        }else if(joystikPlayer.Horizontal < 0)
        {
            player.transform.Rotate(Vector3.up * -0.30f,Space.Self);
            GetComponent<Animator>().SetFloat("Turn",joystikPlayer.Horizontal);
        }
        if (joystikPlayer.Vertical > 0)
        {
            
            //player.transform.Translate(Vector3.forward * 0.30f,Space.Self);
            //GetComponent<Animator>().Play("Walk");

            GetComponent<Animator>().SetFloat("Walk",joystikPlayer.Vertical);
        }
    }
    
    private void OnCollisionStay(Collision other) {
        if(other.gameObject.tag == "Corganico"){
            int numMuni = Random.Range(3, 6);
            canhao.GetComponent<Canhao>().municao += numMuni * organico;
            organico = 0;
        }
        if(other.gameObject.tag == "Creciclavel"){
            int numMuni = Random.Range(3, 6);
            canhao.GetComponent<Canhao>().municaoRec += numMuni * reciclavel;
            reciclavel = 0;
        }
    }
     
}
