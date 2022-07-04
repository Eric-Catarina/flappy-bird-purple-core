using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeraCanos : MonoBehaviour
{
    [SerializeField]
    private GameObject prefabCano;
    private void SpawnaCanos(){
        
        GameObject instanciaCano = Instantiate(prefabCano, new Vector3(4.5f, Random.Range(-3, 3), 0),Quaternion.identity);
        Destroy(instanciaCano, 10.5f);
    }

    
    
    void Start()
    {
       InvokeRepeating(nameof(SpawnaCanos), 0f, 2f);
    }
            
    

    
    
}
