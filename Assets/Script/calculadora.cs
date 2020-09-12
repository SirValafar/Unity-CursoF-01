using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class calculadora : MonoBehaviour
{

    public int bill;
    public float porc;
    public float resultado;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            resultado = bill * (porc/100);
            Debug.Log("En la billetera hay " + resultado);
        }
        
    }
}
