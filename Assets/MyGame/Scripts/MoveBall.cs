using UnityEngine;

public class MoveBall : MonoBehaviour
{
    public Transform[] positions;
    public Transform ball;
    public void MovingBall()
    {
        ball.position = positions[Random.Range(0, positions.Length)].position;
    }
}

