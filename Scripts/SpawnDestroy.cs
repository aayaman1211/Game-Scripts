using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDestroy : MonoBehaviour
{
    public float destroyTime = 14f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        destroyTime -= Time.deltaTime;
        if (destroyTime < 0)
            Destroy(this.gameObject);
    }
}
