using UnityEngine;

public class MoveBall : MonoBehaviour
{
    [SerializeField] private Transform[] randomPosition;
    [SerializeField] private Transform defaultPosition;
    [SerializeField] private Transform ball;
    void Start()
    {
        ball.position = defaultPosition.position;
    }

    public void MovingBall()
    {
        Vector3 oldPos;
        Vector3 newPos;

        oldPos = ball.position;
        newPos = randomPosition[Random.Range(0, randomPosition.Length)].position;
        ball.position = newPos;
    }
}

