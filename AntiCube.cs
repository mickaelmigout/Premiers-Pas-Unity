using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntiCube : MonoBehaviour
{
    void Kaboom(GameObject other) {
    Destroy(other.gameObject);
    Destroy(gameObject);

    }
    void OnCollisionEnter(Collision other) {
        
        string layerName = LayerMask.LayerToName(other.gameObject.layer);
        // si le layer de l'autre est "FX" ou "Default", on se casse direct 
        // (pas de Kabooom possible)
        if (layerName == "FX" || layerName == "Default") {
            return;
        }

        // 1. On récupère le RigidBody de "l'autre" (c'est un essai)
        // 2. Si le RigidBody n'est pas nul (il existe), alors KABOOOOOOOM !!!
        Rigidbody otherBody = other.gameObject.GetComponent<Rigidbody>();
        if (otherBody != null) {
            Kaboom(other.gameObject);
        }
      
    }
}
