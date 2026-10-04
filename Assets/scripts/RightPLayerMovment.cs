using Unity.VisualScripting;
using UnityEngine;

public class splayerMovment : MonoBehaviour
{
    [SerializeField] private Rigidbody2D myRigidbody2d;
    [SerializeField] private float playerMovingStrenght = 4f; 
    void Start()
    {
        
    }

    void Update()
    {
        playerMovment();
    }

    private void playerMovment()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            myRigidbody2d.linearVelocity = Vector2.up * playerMovingStrenght;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            myRigidbody2d.linearVelocity = Vector2.down * playerMovingStrenght;
        }
        else
        {
            myRigidbody2d.linearVelocity = Vector2.zero;
        }
    }
}