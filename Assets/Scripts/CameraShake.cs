using UnityEngine;

public class CameraShake : MonoBehaviour
{
    public float duration = 0.5f;
    public float magnitude = 0.2f;
    public float frequency = 25f;

    private Vector3 originalPosition;
    private float elapsed = 0f;
    private bool isShaking = false;

    public void TriggerShake(float dur, float mag, float freq)
    {
        duration = dur;
        magnitude = mag;
        frequency = freq;
        originalPosition = transform.localPosition;
        elapsed = 0f;
        isShaking = true;
    }

    void Update()
    {
        if (!isShaking) return;

        if (elapsed < duration)
        {
            float x = Mathf.Sin(Time.time * frequency) * magnitude;
            float y = Mathf.Sin(Time.time * frequency * 1.1f) * magnitude;

            transform.localPosition = originalPosition + new Vector3(x, y, 0);

            elapsed += Time.deltaTime;
        }
        else
        {
            isShaking = false;
            transform.localPosition = originalPosition;
        }
    }
}
