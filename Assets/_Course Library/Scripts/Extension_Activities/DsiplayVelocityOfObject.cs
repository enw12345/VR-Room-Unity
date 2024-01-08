using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DsiplayVelocityOfObject : MonoBehaviour
{
    TMP_Text _displayText;
    [SerializeField] private Rigidbody _rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        _displayText = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        _displayText.text = $"Rigidbody Velocity {_rigidbody.velocity.magnitude}";
    }
}
