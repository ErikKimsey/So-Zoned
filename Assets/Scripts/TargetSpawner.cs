using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject m_BH;

    private GameObject obj;


    // Spawn Bounds:
    // -- Left:
    // ---- Bottom (-2.8, 2.26, 6-8)
    // ---- Top (-2.8, 6.4, 6-8)
    // -- Right:
    // ---- Bottom (2.8, 2.26, 6-8)
    // ---- Top (2.8, 6.4, 6-8)


    void Start()
    {
        if (obj == null)
        {
            obj = Instantiate(m_BH, new Vector3(-1f, 4.4f, 8f), Quaternion.identity);
        }
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}