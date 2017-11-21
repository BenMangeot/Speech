using UnityEngine;
using System.Collections;

public class SetupMicrophone : MonoBehaviour {

	// Use this for initialization
	void Start () {
        var audio = GetComponent<AudioSource>();
        audio.clip = Microphone.Start(null, true, 5, AudioSettings.outputSampleRate);
        while (Microphone.GetPosition(null) <= 0) {}
        audio.Play();
    }
}
