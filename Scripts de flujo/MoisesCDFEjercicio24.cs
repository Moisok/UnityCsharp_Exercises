using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoisesCDFEjercicio24 : MonoBehaviour
{
    // Start is called before the first frame update

    public int pago= 0;
    int b100 = 0;
    int b50 = 0;
    int b20= 0;
    int b10= 0;
    int b5= 0;
    int b2= 0;
    int b1= 0;
    void Start()
    {
        while (pago > 1){

            if (pago > 100){
                pago = pago - 100;
                b100++;
            }
            else if (pago > 50){
                pago = pago - 50;
                b50++;
            }
            else if (pago > 20){
                pago = pago - 20;
                b20++;
            }
            else if (pago > 10){
                pago = pago - 10;
                b10++;
            }
            else if (pago > 5){
                pago = pago - 5;
                b5++;
            }
            else if (pago > 2){
                pago = pago - 2;
                b2++;
            }
            else if (pago > 1){
                pago = pago - 1;
                b1++;
            }
        }

    Debug.Log("Has pagado con...");    
    Debug.Log("Billetes de 100: " + b100);
    Debug.Log("Billetes de 50: " + b50);
    Debug.Log("Billetes de 20: " + b20);
    Debug.Log("Billetes de 10: " + b10);
    Debug.Log("Billetes de 5: " + b5);
    Debug.Log("Billetes de 2: " + b2);
    Debug.Log("Billetes de 1: " + b1);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
