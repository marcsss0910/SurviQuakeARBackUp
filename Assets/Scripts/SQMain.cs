using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SQMain : MonoBehaviour {

    public static SQMain Instance; 

    public SQWeb SQWeb;

    // Start is called before the first frame update
    void Start() {
        Instance = this;
        SQWeb = GetComponent<SQWeb>();
    }

}
