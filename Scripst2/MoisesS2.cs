using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoisesS2 : MonoBehaviour
{
    public List <int> m_List = new List <int>();

    // Start is called before the first frame update
    void Start()
    {
       
        for (int i = 0; i < 5; i++)
        {
            m_List.Add (i);
        }

        m_List.Reverse();

        foreach (int j in m_List)
        {
            Debug.Log("[" + j + "]");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
