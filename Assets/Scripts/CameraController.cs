using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target; // Kameranýn takip edeceði hedef (örneðin, karakter)
    public float smoothSpeed = 0.125f; // Kameranýn hareket hýzýný yumuþatmak için kullanýlan hýz
    public Vector3 offset; // Kameranýn hedefe olan ofseti

    // Kameranýn sýnýrlarýný belirlemek için kullanýlan minimum ve maksimum deðerler
    public Vector2 minPosition;
    public Vector2 maxPosition;

    void LateUpdate()
    {
        Vector3 desiredPosition = target.position + offset;

        // X ve Y koordinatlarýný belirli sýnýrlar içerisinde tut
        float clampedX = Mathf.Clamp(desiredPosition.x, minPosition.x, maxPosition.x);
        float clampedY = Mathf.Clamp(desiredPosition.y, minPosition.y, maxPosition.y);

        Vector3 clampedPosition = new Vector3(clampedX, clampedY, desiredPosition.z);

        // Kameranýn yumuþak hareketi
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, clampedPosition, smoothSpeed);
        transform.position = smoothedPosition;
    }
}

