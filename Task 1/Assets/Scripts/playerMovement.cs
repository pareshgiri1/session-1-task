using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public List<Transform>  cubes;
    int i = 0;

    void Start()
    {
                
        
    }

    
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            // for the moving
            transform.position = Vector3.MoveTowards(transform.position , cubes[i].position,0.1f);
            // this is for the move 1 point to second point and move in loop
            if(transform.position == cubes[i].position)
            {
                i++;
                if (i >= cubes.Count)
                {
                    i = 0;
                }
            }
        }
    }
}
