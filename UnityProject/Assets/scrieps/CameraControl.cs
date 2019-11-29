using UnityEngine;

public class CameraControl : MonoBehaviour
{
    [Header("follow")]
    public Transform target;
    [Header("imthefast"), Range(0f, 100f)]
    public float speed = 1.5f;
    private void Track()
    {
        float limitY = Mathf.Clamp(target.position.y, 0f, 3f);
        Vector3 targetPos = new Vector3(target.position.x, limitY, -10);
        transform.position = Vector3.Lerp(transform.position, targetPos, 0.3f * speed * Time.deltaTime);
    }
    private void LateUpdate()
    {
        Track();
    }
}
