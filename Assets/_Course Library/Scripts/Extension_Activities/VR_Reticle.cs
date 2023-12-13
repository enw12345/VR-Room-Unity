using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VR_Reticle : MonoBehaviour
{
    private Transform _reticleTransform;
    [SerializeField] private float _RotateSpeed;
    [SerializeField] private float _ScaleSpeed;

    // Start is called before the first frame update
    void Start()
    {
        _reticleTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Rotate();
        Scale();
    }

    void Scale()
    {
        float scaleAmount = Mathf.Abs(Mathf.Sin(Time.time * _ScaleSpeed)) + .5f;
        Vector3 scale =
            new Vector3(scaleAmount, scaleAmount, scaleAmount);

        _reticleTransform.localScale = scale;
    }

    void Rotate()
    {
        float angle = Time.time * _RotateSpeed;

        Quaternion rotation =
           Quaternion.Euler(_reticleTransform.localEulerAngles.x, angle, _reticleTransform.localEulerAngles.z);

        _reticleTransform.localRotation = rotation;
    }
}
