using UnityEngine;

public class TouchEffector : MonoBehaviour
{
    public ParticleSystem particle;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var mousePos = Input.mousePosition;
            mousePos.z = Camera.main.nearClipPlane;
            var pos = Camera.main.ScreenToWorldPoint(mousePos);
            Instantiate(particle, pos, Quaternion.identity);
        }
    }
}
