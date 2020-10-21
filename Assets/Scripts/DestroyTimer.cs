using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTimer : MonoBehaviour
{
    private void Awake()
    {
        Destroy(gameObject, 10);
    }
}
