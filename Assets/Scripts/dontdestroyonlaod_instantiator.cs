using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dontdestroyonlaod_instantiator : MonoBehaviour
{
    public GameObject dontdestroyonload_prefab;     //instantiate edilen ddol objesi
    
    
    /* en baþta sahnede dont ddol objesi olduðu zaman çýkýp girdiðimde 2 tane ddol oluyodu çünkü baþtaki sahnede zaten ddol vardý. bu yüzden sahneye oyun baþladýðýnda instantiate etmem gerekiyodu ama bunu sadece daha önce zaten
     yapmadýysam yapmam gerekiyodu. o yüzden ddol_instantiator baþta ddol instantiate ediyo sonra adýný alreadyinstantiated yapýyo. daha sonra alreadyinstantiated varsa yeniden instantiate edilmemesi saðlanýyo */

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
