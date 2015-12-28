using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent (typeof(AudioSource))]
[RequireComponent (typeof(Text))]

public class AutoTyping : MonoBehaviour {

    public string[] Mensaje = new string[1]; 
    public float retrasoInicial = 2f; 
    public float retrasoIntermedio = 0.01f; 
    public AudioClip sonido; 
    Text t; 
    int a = 0;

    void Start() 
    {
        StartCoroutine("Comenzar");
    }

    void Awake() 
    {
        t = GetComponent<Text>();
    }

    public IEnumerator Comenzar() 
    {
        for (int f = 0; f < Mensaje.Length; f++)
        {
            a = f;
            StartCoroutine("Escribir"); 
            yield return new WaitForSeconds(retrasoIntermedio*Mensaje[a].Length*2 + retrasoInicial*1.5f); 
        }
    }
    public IEnumerator Escribir()  
    {
        yield return new WaitForSeconds(retrasoInicial);
        for (int i = 0; i < Mensaje[a].Length+1 ; i++)  
        {
            t.text = Mensaje[a].Substring(0, i); 

            if(sonido != null)
                GetComponent<AudioSource>().PlayOneShot(sonido);
            Debug.Log("Que buen chiste");
            yield return new WaitForSeconds(retrasoIntermedio); 
         }
    }

}

