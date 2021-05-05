using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClonePlate : MonoBehaviour
{
    public Transform cloneLocation;

    private void OnTriggerEnter(Collider other) {
        // On clone "l'autre" à une position précise (cloneLocation).
        Vector3 position = cloneLocation.position;
        Quaternion rotation = Quaternion.identity;
        Instantiate(other.gameObject, position, rotation);

        // On désactive le prefab (gameObject).
        gameObject.SetActive(false);
    }
}