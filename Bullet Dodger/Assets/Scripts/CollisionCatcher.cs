using System;
using UnityEngine;

public class CollisionCatcher : MonoBehaviour
{
    public event Action<Collider> OnTriggerEnterEvent;
    public event Action<Collider> OnTriggerExitEvent;
    public event Action<Collision> OnCollisionEnterEvent;
    public event Action<Collision> OnCollisionExitEvent;

    private void OnTriggerEnter(Collider other) => OnTriggerEnterEvent?.Invoke(other);
    private void OnTriggerExit(Collider other) => OnTriggerExitEvent?.Invoke(other);
    private void OnCollisionEnter(Collision other) => OnCollisionEnterEvent?.Invoke(other);
    private void OnCollisionExit(Collision other) => OnCollisionExitEvent?.Invoke(other);
}
