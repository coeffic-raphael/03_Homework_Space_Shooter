using UnityEngine;
using UnityEngine.SceneManagement;

public class GotoNextLevel : MonoBehaviour
{
    [SerializeField] string triggeringTag;
    [SerializeField] [Tooltip("Name of scene to move to when triggering the given tag")] string sceneName;

    [SerializeField] bool isFinalLevel = false;
    //[SerializeField] NumberField scoreField;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == triggeringTag)
        {
            if (isFinalLevel && AudioManager.Instance != null)
            {
                AudioManager.Instance.StopMusic();
                AudioManager.Instance.PlayVictory();
            }
            Debug.Log("Moving " + this + " to zero");
            this.transform.position = Vector3.zero;
            SceneManager.LoadScene(sceneName);
        }
    }
}
