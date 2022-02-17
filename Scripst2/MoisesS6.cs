using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoisesS6 : MonoBehaviour
{

    public double userNumber = 0.0;

    double media = 0;
    
    // Start is called before the first frame update
    void Start()
    {
       List <double> numeros = new List<double> {-2.5,4.6,7.8,-1.6,6.7,1.2,2.4,-9.8,7.7,userNumber};

       for (int i=0;i<10;i++){
           media += numeros[i];
       }

       if (userNumber > 0){
           media = media/10;
       }else{
           media = media/9;
       }

       Debug.Log("Media: " + media);
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
