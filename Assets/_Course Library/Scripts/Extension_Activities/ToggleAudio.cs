using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]

public class ToggleAudio : MonoBehaviour
{
    AudioSource _audioSource;

    public void Toggle()
    {
        _audioSource = GetComponent<AudioSource>();

        // Check if _audioSource is not null to avoid potential issues
        if (_audioSource != null)
        {
            // Use the ternary operator to toggle between Pause and Play
            _audioSource.isPlaying? _audioSource.Pause() : _audioSource.Play();
        }
        else
        {
            Debug.LogError("AudioSource component not found.");
        }
    }
}
