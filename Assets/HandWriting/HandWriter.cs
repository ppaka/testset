using UnityEngine;

public class HandWriter : MonoBehaviour
{
    private void Awake()
    {
        Application.targetFrameRate = 60;
    }

    public LineRenderer lr;
    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out var hit, 1000))
            {
                if(hit.transform.CompareTag("Note"))
                    lr.SetPosition((++lr.positionCount)-1, hit.point);
            }
        }
    }
}
