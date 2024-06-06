using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dontdestroyonlaod_instantiator : MonoBehaviour
{
    public GameObject dontdestroyonload_prefab;     //instantiate edilen ddol objesi
    
    
    /* en ba�ta sahnede dont ddol objesi oldu�u zaman ��k�p girdi�imde 2 tane ddol oluyodu ��nk� ba�taki sahnede zaten ddol vard�. bu y�zden sahneye oyun ba�lad���nda instantiate etmem gerekiyodu ama bunu sadece daha �nce zaten
     yapmad�ysam yapmam gerekiyodu. o y�zden ddol_instantiator ba�ta ddol instantiate ediyo sonra ad�n� alreadyinstantiated yap�yo. daha sonra alreadyinstantiated varsa yeniden instantiate edilmemesi sa�lan�yo */

    void Awake()
    {
        if (!GameObject.Find("dontdestroyonload_alreadyinstantiated"))
        {
            GameObject instantiated_dontdestroyonload_prefab = Instantiate(dontdestroyonload_prefab);
            instantiated_dontdestroyonload_prefab.name = "dontdestroyonload";
        }
    }

    void OnEnable()
    {
        GameObject ddol = GameObject.Find("dontdestroyonload");
        DontDestroyOnLoad(ddol);
        GameObject.Find("dontdestroyonlaod_instantiator").name = "dontdestroyonload_alreadyinstantiated";
    }

    void Start()
    {
        GameObject.Find("dontdestroyonload_alreadyinstantiated").transform.parent = GameObject.Find("dontdestroyonload").transform;
        
    }

    

    
}
