using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Canhao : MonoBehaviour
{
    public FixedJoystick joystiCannon;
    public Text muni;
    public Button troca,atirar;
    public GameObject bala;
    public GameObject canhao;
    public GameObject saida;
    public double municaoRec;
    public double municao ;
    public string tipoMuni = "municao";
    


    // Start is called before the first frame update
    void Start()
    {
        troca.onClick.AddListener(TaskOnClick);
        atirar.onClick.AddListener(TaskOnClick2);
    }

    // Update is called once per frame
    void Update()
    {

        
        if (joystiCannon.Horizontal > 0)
        {
            canhao.transform.Rotate(Vector3.up * 0.10f,Space.Self);
        }else if(joystiCannon.Horizontal < 0)
        {
            canhao.transform.Rotate(Vector3.up * -0.10f,Space.Self);
        }
        
        /*else if(Input.GetKeyDown("w"))
        {
            
           if (tipoMuni == "municao" && municao >= 1)
           {
            GameObject balaTemp = Instantiate(bala,saida.transform.position,saida.transform.rotation);
            municao -= 1;
             muni.text = municao.ToString();
           }else if (tipoMuni == "municaoRec" && municaoRec >= 1)
           {
            GameObject balaTemp = Instantiate(bala,saida.transform.position,saida.transform.rotation);
            municaoRec -= 1;
            muni.text = municaoRec.ToString();
           }


        }else if(troca.onClick.AddListener(TaskOnClick))
        {
            if (tipoMuni == "municao")
            {
                tipoMuni = "municaoRec";
                muni.text = municaoRec.ToString();
            }else
            {
                tipoMuni = "municao";
                muni.text = municao.ToString();
            }
        }*/

        

        
    }
    void TaskOnClick(){
		if (tipoMuni == "municao")
            {
                tipoMuni = "municaoRec";
                muni.text = municaoRec.ToString();
            }else
            {
                tipoMuni = "municao";
                muni.text = municao.ToString();
            }
	}
     void TaskOnClick2(){
		if (tipoMuni == "municao" && municao >= 1)
           {
            GameObject balaTemp = Instantiate(bala,saida.transform.position,saida.transform.rotation);
            municao -= 1;
             muni.text = municao.ToString();
           }else if (tipoMuni == "municaoRec" && municaoRec >= 1)
           {
            GameObject balaTemp = Instantiate(bala,saida.transform.position,saida.transform.rotation);
            municaoRec -= 1;
            muni.text = municaoRec.ToString();
           }
	}

   
}
