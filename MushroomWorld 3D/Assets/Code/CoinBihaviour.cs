using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBihaviour : MonoBehaviour
{
    public GameObject me;

    void OnTriggerEnter()
    {
        Destroy(me);
    }

}
