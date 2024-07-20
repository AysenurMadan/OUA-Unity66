using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target; // Kameran�n takip edece�i hedef (�rne�in, karakter)
    public float smoothSpeed = 0.125f; // Kameran�n hareket h�z�n� yumu�atmak i�in kullan�lan h�z
    public Vector3 offset; // Kameran�n hedefe olan ofseti

    // Kameran�n s�n�rlar�n� belirlemek i�in kullan�lan minimum ve maksimum de�erler
    public Vector2 minPosition;
    public Vector2 maxPosition;

    void LateUpdate()
    {
        Vector3 desiredPosition = target.position + offset;

        // X ve Y koordinatlar�n� belirli s�n�rlar i�erisinde tut
        float clampedX = Mathf.Clamp(desiredPosition.x, minPosition.x, maxPosition.x);
        float clampedY = Mathf.Clamp(desiredPosition.y, minPosition.y, maxPosition.y);

        Vector3 clampedPosition = new Vector3(clampedX, clampedY, desiredPosition.z);

        // Kameran�n yumu�ak hareketi
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, clampedPosition, smoothSpeed);
        transform.position = smoothedPosition;
    }
}

