using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class Dialogue : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;
    public int idx;
    public bool done = false;
    // Start is called before the first frame update
    void Start()
    {
        textComponent.text = string.Empty;
        StartDialogue();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            if (textComponent.text == lines[idx]) {
                NextLine();
            } else {
                StopAllCoroutines();
                textComponent.text = lines[idx];
                
            }
        }
    }
    public void StartDialogue() {
        idx = 0;
        StartCoroutine(TypeLine());
    }
    IEnumerator TypeLine() {
        //type out each character 1 by 1
        foreach(char c in lines[idx].ToCharArray()) {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }
    void NextLine() {
        Debug.Log(idx);
        if (idx < lines.Length - 1) {
            idx++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        } else {
            lines = null;
            textComponent.text = "";
            gameObject.SetActive(false);  
            done = true;
        }
    }

}
