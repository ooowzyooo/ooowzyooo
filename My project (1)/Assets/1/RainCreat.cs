using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainCreat : MonoBehaviour
{
    public GameObject rainPoint;
    public float creatX,creatY;
    private int creatCount, setCount=4;
    void Start()
    {
        
    }
    private void FixedUpdate()
    {
        creatCount++;
        if (creatCount >= setCount)
        {
            GameObject go = Instantiate(rainPoint, transform);
            Vector2 pos = transform.position;
            pos = new Vector2(pos.x + Random.Range(-creatX, creatX), pos.y + Random.Range(-creatY, creatY));
            go.transform.position = pos;
            Destroy(go, 2f);
            creatCount = 0;
        }
    }

    void Update()
    {
        
    }
}
