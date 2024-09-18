using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class ReticleBehavior : MonoBehaviour
{
    public float minSize = 1;
    public float maxSize = 4;
    public float currentReticleSize = 1f;
    public float increaseReticleByOnClick = 0.1f;
    public float shrinkByPerSecond = 1f;
    public float pauseOnShotFor = 0.5f;
    [SerializeField]
    float currentHeatState;
    private float timer;


    // Start is called before the first frame update
    void Start()
    {
        currentReticleSize = minSize;
        UnityEngine.Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.Lerp(transform.position, Camera.main.ScreenToWorldPoint(Input.mousePosition), 1f);
        if (Input.GetMouseButtonDown(0))
        {
            increaseReticleSize();
        }
    }

    private void increaseReticleSize()
    {
        if(currentReticleSize+increaseReticleByOnClick < maxSize) {
            currentReticleSize += increaseReticleByOnClick;
        }
        else
        {
            currentReticleSize = maxSize;
        }
        
    }
}
