using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WASMClientLibrary;

public class TestScript : MonoBehaviour
{
    Vector3 Vec;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        WASMReader wasmReader = new WASMReader();

        Vec = transform.localPosition;
        Vec.y += (float)wasmReader.ExecuteWasSum(1, 5) / 1000;
        transform.localPosition = Vec;
    }
}
