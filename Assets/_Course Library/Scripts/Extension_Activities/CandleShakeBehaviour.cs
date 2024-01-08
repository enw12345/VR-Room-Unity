using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandleShakeBehaviour : MonoBehaviour
{
    [SerializeField] private ParticleSystem candleFlame;

    // Start is called before the first frame update
    void Start()
    {
        candleFlame = GetComponent<ParticleSystem>();
    }

    private void FixedUpdate()
    {

    }
}
