using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
public class Ai_pierdut : MonoBehaviour
{
    private IEnumerator WaitForSceneLoad()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("Start");
    }

    public Text ScorText;
    void OnCollisionEnter(Collision collision)
    {
        ScorText.text = "Ai pierdut!!!";
        StartCoroutine(WaitForSceneLoad());
    }
}
