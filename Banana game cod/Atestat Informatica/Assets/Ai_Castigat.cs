using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class Ai_Castigat : MonoBehaviour
{
    public IEnumerator WaitForSceneLoad()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("Level2");
    }

    public Text Win;
    void OnCollisionEnter(Collision collision)
    {
        Win.text = "Ai castigat!!!";
        StartCoroutine(WaitForSceneLoad());
    }
}
