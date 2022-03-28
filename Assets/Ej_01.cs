/* Realizá un programa donde se cree una variable entera llamada num1, que inicialmente 
 valdrá 0. Luego incrementá su valor en 2 y mostralo por pantalla. Después mostrá el
 resultado de multiplicarlo por sí mismo.
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej_01: MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int num1 = 0;
        //int num2 =2;
        //int res = num1 +=2;
        int res2;

        num1 += 2;

        Debug.Log("num1 + 2 = " + num1 + "");

        res2 = num1 * num1;

        Debug.Log("El resultado de num1 x num1 es " + res2 + "");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
