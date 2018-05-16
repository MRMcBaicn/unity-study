using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class APlayerHealth : MonoBehaviour {
    public float health = 100f;
    //public float repeatDamagePeriod = 2f;
    //pubiic AudioClip[] ouchClips;
    public float hurtForce = 10f;
    public float damageAmount = 10f;
    private SpriteRenderer healthBar;
    private float lastHitTime;
    private Vector3 healthScale;
    private PlayerControl playerControl;
    private Animator anim;	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
