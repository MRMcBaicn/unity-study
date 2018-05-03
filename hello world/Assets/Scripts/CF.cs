using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CF : MonoBehaviour {
   // public Transform hero;
    private Transform player;
    public float xMargin = 1;
    public float yMargin = 1;
    public float xSmooth = 8;
    public float ySmooth = 8;
    public Vector2 maxXAndY;
    public Vector2 minXAndY;

	// Use this for initialization
	void Start () {

        player = GameObject.FindGameObjectWithTag("Player").transform;

    }
	
	// Update is called once per frame
	void Update () {
       // transform.position = new Vector3(hero.position.x, hero.position.y, transform.position.z);

    }
    void FixedUpdate()
    {
        TrackPlayer();
    }
    bool xMarginCheack()
    {
        return Mathf.Abs(transform.position.x - player.position.x) > xMargin;
    }
    bool yMarginCheack()
    {
        return Mathf.Abs(transform.position.y - player.position.y) > yMargin;
    }
    void TrackPlayer()
    {
        float targetX = transform.position.x;
        float targetY = transform.position.y;

        if(xMarginCheack())
        {
            targetX = Mathf.Lerp(transform.position.x, player.position.x, xSmooth * Time.deltaTime);
        }
        if (yMarginCheack())
        {
            targetY = Mathf.Lerp(transform.position.y, player.position.y, ySmooth * Time.deltaTime);
        }

        targetX = Mathf.Clamp(targetX, minXAndY.x, maxXAndY.x);
        targetY = Mathf.Clamp(targetY, minXAndY.y, maxXAndY.y);

        transform.position = new Vector3(targetX, targetY, transform.position.z);
    }
}
