using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateSlowDown : MonoBehaviour
{

    public Camera cam;
    public GameObject vignette;
    public SpriteRenderer vigSprite;
    [Range(0,1)]
    public float delta;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cam.orthographicSize = Mathf.Lerp(5,2,delta);
        Time.timeScale = Mathf.Lerp(1,0.1f,delta);
        vignette.transform.localScale = Vector3.Lerp(Vector3.one*5,Vector3.one/2,delta);
        vigSprite.color = Color.Lerp(new Color(0,0,0,0), new Color(0,0,0,1), delta);
        delta -= Time.deltaTime*2;
        delta = Mathf.Clamp01(delta);
    }
}
