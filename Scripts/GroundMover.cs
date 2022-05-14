using UnityEngine;

public class GroundMover : MonoBehaviour
{
    [SerializeField] private float _speedMovemend;

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.Translate(Vector2.right * _speedMovemend * Time.deltaTime);
    }
}
