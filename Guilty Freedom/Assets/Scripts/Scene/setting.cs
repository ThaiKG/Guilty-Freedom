using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;
[RequireComponent(typeof(Slider))]
public class setting : MonoBehaviour
{
    Slider slider {
        get {return GetComponent<Slider>();}
    }

    public AudioMixer mixer;
    public string volumeName;
    public void UpdateValueOnChange(float change) {
        mixer.SetFloat(volumeName, change);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnHome() {
        SceneManager.LoadScene(0);
    }
}
