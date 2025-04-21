using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mensaje : MonoBehaviour
{
    public float TiempoDeVida = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TiempoDeVida -= Time.deltaTime;
        if (TiempoDeVida <= 0)
        {
            this.gameObject.SetActive (false);
            TiempoDeVida = 3;
        }
    }
}
