using UnityEngine;

public class Pacer : MonoBehaviour
{
    public float speed = 5f;
    public float xMin = -7.5f;
    public float xMax = 7.5f;

    private int direction = 1;

    void Update()
    {
        float xNew = transform.position.x +
                     direction * speed * Time.deltaTime;

        if (xNew >= xMax)
        {
            xNew = xMax;
            direction *= -1;
        }
        else if (xNew <= xMin)
        {
            xNew = xMin;
            direction *= -1;
        }

        transform.position = new Vector3(
            xNew,
            transform.position.y,
            transform.position.z
        );
    }
}
