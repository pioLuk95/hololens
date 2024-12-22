using UnityEngine;

public class CustomPointer : MonoBehaviour
{
    [SerializeField]
    private GameObject dartPrefab; // Prefab for the dart object

    [SerializeField]
    private Transform spawnPoint; // Optional: point where darts should spawn (e.g., in front of the user)

    // This method will be triggered when the object is clicked
    public void ShowMessage1()
    {
        Debug.Log("Cube was clicked!");
        Debug.LogError("Error123");
    }

    public void SpawnDart()
    {
        if (dartPrefab == null)
        {
            Debug.LogError("Dart prefab not assigned!");
            return;
        }

        // Spawn dart at the designated spawn point or at a default position
        Vector3 spawnPosition = spawnPoint != null ? spawnPoint.position : Camera.main.transform.position + Camera.main.transform.forward * 0.5f;
        Quaternion spawnRotation = Quaternion.identity;

        Instantiate(dartPrefab, spawnPosition, spawnRotation);
        Debug.Log("Dart spawned!");
    }
}