using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePlanets : MonoBehaviour
{
    [SerializeField] private GameObject PObject;
    [SerializeField] private LayerMask Planets;
    private Collider[] HitColliders = new Collider[1];
    // Start is called before the first frame update
    void Start()
    {
        int i = 0;
        while ( i < 25)
        {
            Vector3 PlanetPos = new Vector3(Random.Range(0f,60f),Random.Range(0f,15f),Random.Range(0f,60f));

            int res = Physics.OverlapSphereNonAlloc(PlanetPos, 5f, HitColliders, Planets);
            if (res == 0 )
            {
                Instantiate(PObject, PlanetPos, Quaternion.identity);
                i++;
            }
            
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
