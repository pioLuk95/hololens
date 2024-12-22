using UnityEngine;
using Microsoft.MixedReality.Toolkit;
using Microsoft.MixedReality.Toolkit.Input;
using Microsoft.MixedReality.Toolkit.Utilities;

public class DartSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject dartPrefab; // Prefab for the dart object

    [SerializeField]
    private Transform spawnPoint; // Optional: point where darts should spawn (e.g., in front of the user)

    public void Update()
    {
        // For mouse click testing in Unity Editor
        if (Input.GetMouseButtonDown(0))
        {
            SpawnDart();
        }

        // For HoloLens: Detect pinch gestures using MRTK
        if (IsPinching(Handedness.Right) || IsPinching(Handedness.Left))
        {
            SpawnDart();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Air Tap Detected");
            SpawnDart();
        }
    }

    bool IsPinching(Handedness handedness)
    {
        // Check if the hand joint poses are available
        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.IndexTip, handedness, out MixedRealityPose indexPose) &&
            HandJointUtils.TryGetJointPose(TrackedHandJoint.ThumbTip, handedness, out MixedRealityPose thumbPose))
        {
            // Measure the distance between the thumb and index finger
            float distance = Vector3.Distance(indexPose.Position, thumbPose.Position);

            // Return true if the distance is small enough to consider it a pinch
            return distance < 0.02f; // Adjust this threshold as needed
        }
        return false;
    }

    private void SpawnDart()
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
