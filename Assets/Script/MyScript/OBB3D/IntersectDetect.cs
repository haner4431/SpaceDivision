using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntersectDetect : MonoBehaviour
{
    public OBB a;
    public OBB b;
    public int count = 500;
    List<OBB> collider = new List<OBB>();
    private void Start()
    {
        for (int i = 0; i < count; i++)
        {
           var go =  GameObject.Instantiate(b);
            go.transform.position= new Vector3(8*(i+1),0,0);
            collider.Add(go);
        }
    }

    void Update()
    {
        bool isIntersects = false;
        for (int i = 0;i < collider.Count; i++)
        {
            if (a.Intersects(collider[i]))
            {
                isIntersects = true;
                collider[i].gizmosColor = Color.red;
            }
            else
            {
                collider[i].gizmosColor = Color.white;
            }
        }

        if (isIntersects)
        {
            a.gizmosColor = Color.red;
        }
        else
        {
            a.gizmosColor = Color.white;
        }


    }
}