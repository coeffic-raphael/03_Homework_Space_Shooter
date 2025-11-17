
using System.Collections;
using UnityEngine;
public class HeartSpawner : MonoBehaviour
{
    [SerializeField] private GameObject heartPrefab;
    [SerializeField] private float minDelay = 5f;
    [SerializeField] private float maxDelay = 15f;
    [SerializeField] private float padding = 0.5f;
    private void Start()
    {
        StartCoroutine(SpawnLoop());
    }

    private IEnumerator SpawnLoop()
    {
        while (true)
        {
            float delay = Random.Range(minDelay, maxDelay);
            yield return new WaitForSeconds(delay);
            SpawnHeartInCamera();}
            }
    private void SpawnHeartInCamera()
    {
        if (heartPrefab == null)
        {
            Debug.LogWarning("[HeartSpawner] heartPrefab manquant !");
            return;
        }
        Camera cam = Camera.main;
        if (cam == null || !cam.orthographic)
        {
            Debug.LogWarning("[HeartSpawner] Pas de caméra orthographique trouvée.");
            return;
        }
        float height = 2f * cam.orthographicSize;
        float width = height * cam.aspect;
        Vector3 camPos = cam.transform.position;
        float minX = camPos.x - width / 2f + padding;
        float maxX = camPos.x + width / 2f - padding;
        float minY = camPos.y - height / 2f + padding;
        float maxY = camPos.y + height / 2f - padding;
        Vector2 spawnPos = new Vector2(
            Random.Range(minX, maxX),
            Random.Range(minY, maxY)
        );
        GameObject h = Instantiate(heartPrefab, spawnPos, Quaternion.identity);
        Debug.Log($"[HeartSpawner] Spawn heart at {spawnPos}, obj = {h.name}");
    }
}
