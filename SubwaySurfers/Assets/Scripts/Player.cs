using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Components")]
    public PlayerLocomotion locomotion;
    public PlayerCollision collision;
    public PlayerPickup pickup;

    public void Die()
    {
        Debug.Log("Player muerto");
        GameManager.Instance.EndRun();
    }
}
